using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_CriarPDF : Form
    {
        public F_CriarPDF()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            Turmas.DataSource = DatabaseController.DataQueryLanguage("SELECT * FROM tb_turmas ORDER BY N_TURMA");
            Turmas.DisplayMember = "N_TURMA";
            Turmas.ValueMember = "N_IDTURMA";
        }

        private void GenerateClick(object sender, EventArgs e)
        {
            if (Start.MaskCompleted == false || End.MaskCompleted == false)
            {
                MessageBox.Show("Essa ferramenta exige que um intervalo de tempo seja fornecido", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Estados.SelectedIndex == -1)
            {
                MessageBox.Show("Essa ferramenta exige que um estado seja fornecido", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveFileDialog Save = new SaveFileDialog
            {
                Title = "Escolha o local para salvar: ",
                Filter = "Arquivo pdf|*.pdf"
            };

            bool FileOkay = false;
            Save.FileOk += (_, args) =>
            {
                FileOkay = true;
            };

            Save.ShowDialog();
            if (!FileOkay)
                return;
            else
            {

                string Query = $"SELECT T_USER AS 'Usuário', T_LIVRO AS 'Livro', T_TURMA AS 'Turma', T_DATA AS 'Data' FROM registry WHERE T_DATA BETWEEN '{MGlobais.FormatarDataSQL(Start.Text)}' AND '{MGlobais.FormatarDataSQL(End.Text)}' {(TodasAsTurmas.Checked ? "" : $"AND T_TURMA = '{Turmas.Text}'")} AND T_STATUS = '{(int)MGlobais.GetDescription(Estados.Text)}' ORDER BY T_TURMA, T_USER";

                Generate.Enabled = false;
                Generate.Cursor = Cursors.No;
                FileStream arquivoPDF = new FileStream(Save.FileName, FileMode.Create);
                Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
                _ = PdfWriter.GetInstance(doc, arquivoPDF);

                Image logo = Image.GetInstance(Properties.Resources.pdfIcon, BaseColor.WHITE);
                if (File.Exists($"{Application.StartupPath}\\logo.jpg"))
                    Image.GetInstance($"{Application.StartupPath}\\logo.jpg");

                logo.ScaleToFit(50f, 50f);
                logo.Alignment = Element.ALIGN_CENTER;

                Paragraph paragrafo1 = new Paragraph("", new Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular))
                {
                    Alignment = Element.ALIGN_LEFT
                };

                paragrafo1.Add("    " + DateTime.Today.ToShortDateString());
                Paragraph paragrafo = new Paragraph("", new Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold))
                {
                    Alignment = Element.ALIGN_CENTER
                };

                paragrafo.Add("\nListas - EasyLi Reports\n");
                paragrafo.Font = new Font(new Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add($"EasyLi Report - ESPECÍFICO ({Estados.Text})" + "\n");

                paragrafo.Font = new Font(new Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add($"SOLICITANTE: {Global.CurrentUserFullname}" + "\n");

                paragrafo.Font = new Font(new Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add($"({Start.Text} || {End.Text})\n\n");

                doc.Open();
                doc.Add(logo);
                doc.Add(paragrafo);

                BaseColor preto = BaseColor.BLACK;
                BaseColor corCinza = new BaseColor(System.Drawing.Color.FromArgb(236, 236, 236));
                BaseColor corCabeçalho = new BaseColor(System.Drawing.Color.LightBlue);

                PdfPTable tabela = new PdfPTable(4);
                float[] medidas = { 35, 35, 10, 10 };
                tabela.PaddingTop = 10;
                tabela.WidthPercentage = 92;
                tabela.SetWidths(medidas);

                PdfPCell cell = new PdfPCell(new Phrase("LISTA", new Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, preto)))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    BackgroundColor = corCabeçalho,
                    Colspan = 4
                };

                tabela.AddCell(cell);
                foreach (string s in new string[] { "Usuário", "Livro", "Data", "Turma" })
                {
                    PdfPCell C0 = new PdfPCell(new Phrase(s, new Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)))
                    {
                        BackgroundColor = corCabeçalho
                    };

                    tabela.AddCell(C0);
                }

                DataTable dt = DatabaseController.DataQueryLanguage(Query);
                Progress.Maximum = dt.Rows.Count;

                int controleLinha = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PdfPCell cell2 = new PdfPCell(new Phrase(dt.Rows[i].Field<string>("Usuário").ToString(), new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell cell3 = new PdfPCell(new Phrase(dt.Rows[i].Field<string>("Livro").ToString(), new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell cell4 = new PdfPCell(new Phrase(dt.Rows[i].Field<DateTime>("Data").ToShortDateString(), new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell cell5 = new PdfPCell(new Phrase(dt.Rows[i].Field<string>("Turma").ToString(), new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));

                    if (controleLinha == 1)
                        controleLinha = 0;
                    else
                    {
                        controleLinha = 1;
                        cell2.BackgroundColor = corCinza;
                        cell3.BackgroundColor = corCinza;
                        cell4.BackgroundColor = corCinza;
                        cell5.BackgroundColor = corCinza;
                    }

                    tabela.AddCell(cell2);
                    tabela.AddCell(cell3);
                    tabela.AddCell(cell4);
                    tabela.AddCell(cell5);
                    Progress.Value = i;
                }

                Progress.Value = dt.Rows.Count;

                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();

                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    System.Diagnostics.Process.Start(Save.FileName);
                    Save.Dispose();
                    Close();
                }
                else
                {
                    Save.Dispose();
                    Close();
                }

            }
        }

        private void AllClassesCheckCheged(object sender, EventArgs e)
        {
            if (TodasAsTurmas.Checked)
            {
                Turmas.Enabled = false;
                Turmas.Cursor = Cursors.No;
            }
            else
            {
                Turmas.Enabled = true;
                Turmas.Cursor = Cursors.Default;
            }
        }
    }
}
