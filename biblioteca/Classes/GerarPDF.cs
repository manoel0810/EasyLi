using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace biblioteca
{
    public class GerarPDF
    {
        //TODO: Refactory all the class

        public static void CriarPDF(DataTable dataTable, string Modo)
        {
            SaveFileDialog Save = new SaveFileDialog
            {
                Title = "Escolha o local para salvar: ",
                Filter = "Arquivos pdf|*.pdf",
                FileName = "Relatório"
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
                string nomeArquivo = Save.FileName;
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
                _ = PdfWriter.GetInstance(doc, arquivoPDF);

                Image logo = Image.GetInstance(Properties.Resources.pdfIcon, BaseColor.WHITE);
                if (File.Exists($"{Application.StartupPath}\\logo.jpg"))
                    Image.GetInstance($"{Application.StartupPath}\\logo.jpg");

                logo.ScaleToFit(50f, 50f);
                logo.Alignment = Element.ALIGN_CENTER;

                DateTime Today = DateTime.Today;
                Paragraph paragrafo1 = new Paragraph("", new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular))
                {
                    Alignment = Element.ALIGN_LEFT
                };

                paragrafo1.Add("    " + Today.ToShortDateString());
                Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold))
                {
                    Alignment = Element.ALIGN_CENTER
                };

                paragrafo.Add("\nListas - EasyLi Reports\n");
                paragrafo.Font = new Font(new Font(Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("EasyLi Reports - " + Modo + "\n");

                paragrafo.Font = new Font(new Font(Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("SOLICITANTE: " + Global.CurrentUserFullname + "\n\n");

                BaseColor preto = BaseColor.BLACK;
                BaseColor corCinza = new BaseColor(System.Drawing.Color.FromArgb(236, 236, 236));
                BaseColor corCabeçalho = new BaseColor(System.Drawing.Color.LightBlue);

                doc.Open();
                doc.Add(logo);
                doc.Add(paragrafo);

                PdfPTable tabela = new PdfPTable(4);
                float[] medidas = { 35, 35, 10, 10 };
                tabela.WidthPercentage = 92;
                tabela.SetWidths(medidas);
                PdfPCell cell = new PdfPCell(new Phrase("LISTA", new Font(Font.NORMAL, 12f, Font.NORMAL, preto)))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    BackgroundColor = corCabeçalho,
                    Colspan = 4
                };

                tabela.AddCell(cell);
                foreach (string s in new string[] { "Usuário", "Livro", "Data", "Turma" })
                {
                    PdfPCell C0 = new PdfPCell(new Phrase(s, new Font(Font.NORMAL, 10f, Font.NORMAL, preto)))
                    {
                        BackgroundColor = corCabeçalho
                    };

                    tabela.AddCell(C0);
                }

                int controleLinha = 1;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    PdfPCell cell2 = new PdfPCell(new Phrase(dataTable.Rows[i].Field<string>("Usuário").ToString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    PdfPCell cell3 = new PdfPCell(new Phrase(dataTable.Rows[i].Field<string>("Livro").ToString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    PdfPCell cell4 = new PdfPCell(new Phrase(dataTable.Rows[i].Field<DateTime>("Data").ToShortDateString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    PdfPCell cell5 = new PdfPCell(new Phrase(dataTable.Rows[i].Field<string>("Turma").ToString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));

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
                }

                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();

                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                    System.Diagnostics.Process.Start(Save.FileName);
                else
                    return;

            }
        }

        public static void ListaLivros()
        {
            SaveFileDialog Save = new SaveFileDialog
            {
                Title = "Escolha o local para salvar: ",
                Filter = "Arquivo pdf|*.pdf",
                FileName = "Relatório"
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
                string nomeArquivo = Save.FileName;
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
                _ = PdfWriter.GetInstance(doc, arquivoPDF);

                Image logo = Image.GetInstance(Properties.Resources.pdfIcon, BaseColor.WHITE);
                if (File.Exists($"{Application.StartupPath}\\logo.jpg"))
                    Image.GetInstance($"{Application.StartupPath}\\logo.jpg");

                Paragraph paragrafo1 = new Paragraph("", new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular))
                {
                    Alignment = Element.ALIGN_LEFT
                };

                paragrafo1.Add("    " + DateTime.Today.ToShortDateString());
                Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold))
                {
                    Alignment = Element.ALIGN_CENTER
                };

                paragrafo.Add("\nListas - EasyLi Reports\n");
                paragrafo.Font = new Font(new Font(Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("EasyLi ReportsL - Livros" + "\n");

                paragrafo.Font = new Font(new Font(Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add($"SOLICITANTE: {Global.CurrentUserFullname}\n\n");

                doc.Open();
                doc.Add(logo);
                doc.Add(paragrafo);

                BaseColor preto = BaseColor.BLACK;
                BaseColor corCinza = new BaseColor(System.Drawing.Color.FromArgb(236, 236, 236));
                BaseColor corCabeçalho = new BaseColor(System.Drawing.Color.LightBlue);

                PdfPTable tabela = new PdfPTable(4);
                float[] medidas = { 8, 60, 12, 12 };
                tabela.WidthPercentage = 92;
                tabela.SetWidths(medidas);

                foreach (string s in new string[] { "Nº", "Título", "CODEC", "R. Data" })
                {
                    PdfPCell C1 = new PdfPCell(new Phrase(s, new Font(Font.NORMAL, 10f, Font.NORMAL, preto)))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        BackgroundColor = corCabeçalho
                    };

                    tabela.AddCell(C1);
                }

                int controleL = 0;
                DataTable info = DatabaseController.DataQueryLanguage("select * from tb_livros order by t_titulo");
                for (int i = 0; i < info.Rows.Count; i++)
                {
                    PdfPCell D1 = new PdfPCell(new Phrase((i + 1).ToString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    PdfPCell D2 = new PdfPCell(new Phrase(info.Rows[i].Field<string>("t_titulo"), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    PdfPCell D3 = new PdfPCell(new Phrase(info.Rows[i].Field<Int64>("id").ToString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    PdfPCell D4 = new PdfPCell(new Phrase(info.Rows[i].Field<DateTime>("dt_datain").ToShortDateString(), new Font(Font.NORMAL, 8f, Font.NORMAL, preto)));
                    D1.HorizontalAlignment = Element.ALIGN_CENTER; D3.HorizontalAlignment = Element.ALIGN_CENTER; D4.HorizontalAlignment = Element.ALIGN_CENTER;

                    if (controleL == 1)
                    {
                        D1.BackgroundColor = corCinza;
                        D2.BackgroundColor = corCinza;
                        D3.BackgroundColor = corCinza;
                        D4.BackgroundColor = corCinza;
                        controleL = 0;
                    }
                    else
                        controleL = 1;


                    tabela.AddCell(D1); tabela.AddCell(D2); tabela.AddCell(D3); tabela.AddCell(D4);
                }

                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();

                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                    System.Diagnostics.Process.Start(Save.FileName);
                else
                    return;

            }
        }
    }
}
