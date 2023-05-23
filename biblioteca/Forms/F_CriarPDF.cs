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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_CriarPDF_Load(object sender, EventArgs e)
        {
            string vqueryTurmas = @" SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turma.DisplayMember = "N_TURMA";
            cb_turma.ValueMember = "N_IDTURMA";
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            if (mask_data1.MaskCompleted == false || mask_data2.MaskCompleted == false)
            {
                MessageBox.Show("Essa ferramenta exige que um intervalo de tempo seja fornecido", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cb_estado.SelectedIndex == -1)
            {
                MessageBox.Show("Essa ferramenta exige que um estado seja fornecido", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveFileDialog localFile = new SaveFileDialog();
            localFile.Title = "Escolha o local para salvar: ";
            localFile.Filter = "(*.pdf)|*.pdf";
            localFile.ShowDialog();
            string local = localFile.FileName;
            string vquery = "";

            //Início do processo de criação da String de comando
            if (cb_todasTurmas.Checked == true)
            {
                vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_TURMA AS 'Turma', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA BETWEEN '" + MGlobais.FormatarDataSQL(mask_data1.Text) + "' AND '" + MGlobais.FormatarDataSQL(mask_data2.Text) + "' AND T_STATUS = '" + cb_estado.Text + "'ORDER BY T_TURMA, T_ALUNO";
            }

            if (cb_todasTurmas.Checked == false)
            {
                vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_TURMA AS 'Turma', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA BETWEEN '" + MGlobais.FormatarDataSQL(mask_data1.Text) + "' AND '" + MGlobais.FormatarDataSQL(mask_data2.Text) + "' AND T_TURMA = '" + cb_turma.Text + "' AND T_STATUS = '" + cb_estado.Text + "' ORDER BY T_TURMA, T_ALUNO";
            }
            //Fim do processo de ciração da String de comando

            if (local == "")
            {
                return;
            }
            else
            {

                btn_gerar.Enabled = false;
                btn_gerar.Cursor = Cursors.No;
                string nomeArquivo = local;
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.jpg");
                logo.ScaleToFit(50f, 50f);
                logo.Alignment = Element.ALIGN_CENTER;

                DateTime da = DateTime.Today;
                string data = da.ToShortDateString();

                string dados = "";

                Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
                paragrafo1.Alignment = Element.ALIGN_LEFT;
                paragrafo1.Add("    " + data);

                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("\nListas - Biblioteca Fácil\n");

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("ESCOLA DE REFERÊNCIA EREM OLIVEIRA LIMA\n");

                string textp = "BIBLIOTECA FÁCIL EREMOL - ESPECÍFICO (" + cb_estado.Text + ")";
                string pessoal = "SOLICITANTE: " + Globais.user;

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(textp + "\n");

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(pessoal + "\n");

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("(" + mask_data1.Text + " || " + mask_data2.Text + ")" + "\n\n");

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

                PdfPCell cell = new PdfPCell(new Phrase("LISTA", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, preto)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = corCabeçalho;
                cell.Colspan = 4;
                tabela.AddCell(cell);

                PdfPCell C0 = new PdfPCell(new Phrase("ALUNO", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C0.BackgroundColor = corCabeçalho;
                PdfPCell C1 = new PdfPCell(new Phrase("LIVRO", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C1.BackgroundColor = corCabeçalho;
                PdfPCell C2 = new PdfPCell(new Phrase("DATA", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C2.BackgroundColor = corCabeçalho;
                PdfPCell C3 = new PdfPCell(new Phrase("TURMA", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C3.BackgroundColor = corCabeçalho;

                tabela.AddCell(C0);
                tabela.AddCell(C1);
                tabela.AddCell(C2);
                tabela.AddCell(C3);

                DataTable dt = new DataTable();
                dt = Banco.DQL(vquery);
                pgb_pdf.Maximum = dt.Rows.Count;
                int controleLinha = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PdfPCell cell2 = new PdfPCell(new Phrase(dt.Rows[i].Field<string>("Aluno").ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell cell3 = new PdfPCell(new Phrase(dt.Rows[i].Field<string>("Livro").ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell cell4 = new PdfPCell(new Phrase(dt.Rows[i].Field<DateTime>("Data").ToShortDateString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell cell5 = new PdfPCell(new Phrase(dt.Rows[i].Field<string>("Turma").ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));

                    if (controleLinha == 1)
                    {
                        controleLinha = 0;
                    }
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
                    pgb_pdf.Value = i;
                }
                pgb_pdf.Value = dt.Rows.Count;

                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();

                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    System.Diagnostics.Process.Start(local);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void cb_todasTurmas_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todasTurmas.Checked)
            {
                cb_turma.Enabled = false;
                cb_turma.Cursor = Cursors.No;
            }
            else
            {
                cb_turma.Enabled = true;
                cb_turma.Cursor = Cursors.Default;
            }
        }
    }
}
