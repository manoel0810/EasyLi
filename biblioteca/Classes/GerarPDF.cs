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
        public static void CriarPDF(DataTable dataTable, string nome, string estado)
        {
            SaveFileDialog localFile = new SaveFileDialog();
            localFile.Title = "Escolha o local para salvar: ";
            localFile.Filter = "(*.pdf)|*.pdf";
            localFile.ShowDialog();

            if (String.IsNullOrEmpty(localFile.FileName))
            {
                return;
            }
            else
            {
                string nomeArquivo = localFile.FileName;
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

                string textp = "BIBLIOTECA FÁCIL EREMOL - " + estado;
                string pessoal = "SOLICITANTE: " + Globais.user;

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(textp + "\n");

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(pessoal + "\n\n");

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

                DataTable dt = dataTable;
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
                }

                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();

                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    System.Diagnostics.Process.Start(localFile.FileName);
                }
                else
                {
                    return;
                }
            }
        }

        public static void RelatorioAnual(string vquery, bool todasAsTurmas, bool todosOsEstados, string dataRelatorio)
        {
            SaveFileDialog localFile = new SaveFileDialog();
            localFile.Title = "Escolha o local para salvar: ";
            localFile.Filter = "(*.pdf)|*.pdf";
            localFile.ShowDialog();

            if (String.IsNullOrEmpty(localFile.FileName))
            {
                return;
            }
            else
            {
                int todos = 0;
                int empretados = 0;
                int devolvidos = 0;
                int perdidos = 0;
                int bloqueados = 0;
                string nomeArquivo = localFile.FileName;
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

                string textp = "BIBLIOTECA FÁCIL EREMOL - Relatório Anual";
                string pessoal = "SOLICITANTE: " + Globais.user;

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(textp + "\n");

                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(pessoal + "\n\n");

                //Informações
                Paragraph paragrafoInfo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
                paragrafoInfo.Alignment = Element.ALIGN_LEFT;
                //Fim informações

                doc.Open();
                doc.Add(logo);
                doc.Add(paragrafo);

                BaseColor preto = BaseColor.BLACK;
                BaseColor corCinza = new BaseColor(System.Drawing.Color.FromArgb(236, 236, 236));
                BaseColor corCabeçalho = new BaseColor(System.Drawing.Color.LightBlue);
                var font = FontFactory.GetFont(FontFactory.TIMES, 8, preto);

                if (todosOsEstados == true)
                {
                    string query = "";
                    DataTable ress = new DataTable();

                    //Todos do ano "Emprestados"
                    query = "SELECT N_IDLIVROALUNO FROM tb_dadosaluno WHERE T_DATA LIKE '" + Globais.dataRelatorio + "%' AND T_STATUS = 'Emprestado'";
                    ress = Banco.DQL(query);
                    empretados = ress.Rows.Count;
                    //Todos do ano "Devolvidos"
                    query = "SELECT N_IDLIVROALUNO FROM tb_dadosaluno WHERE T_DATA LIKE '" + Globais.dataRelatorio + "%' AND T_STATUS = 'Devolvido'";
                    ress = Banco.DQL(query);
                    devolvidos = ress.Rows.Count;
                    //Todos "Perdidos"
                    query = "SELECT N_IDLIVROALUNO FROM tb_dadosaluno WHERE T_DATA LIKE '" + Globais.dataRelatorio + "%' AND T_STATUS = 'PERDIDO'";
                    ress = Banco.DQL(query);
                    perdidos = ress.Rows.Count;
                    //Todos "Bloquados"
                    query = "SELECT N_IDLIVROALUNO FROM tb_dadosaluno WHERE T_DATA LIKE '" + Globais.dataRelatorio + "%' AND T_STATUS = 'BLOQUEADO'";
                    ress = Banco.DQL(query);
                    bloqueados = ress.Rows.Count;
                    todos = empretados + devolvidos + perdidos + bloqueados;
                    paragrafoInfo.Add(String.Format("Informações Gerais: Nº Total de movimentos: {0}; Nº Emprestados: {1}; Nº Devolvidos: {2}; Nº Perdidos: {3}; Nº Bloqueados: {4}\n\n", todos, empretados, devolvidos, perdidos, bloqueados));
                }

                PdfPTable tabela = new PdfPTable(4);
                float[] medidas = { 35, 35, 10, 10 };
                tabela.WidthPercentage = 92;
                tabela.SetWidths(medidas);
                PdfPCell cell = new PdfPCell(new Phrase("LISTA", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, preto)));
                cell.BackgroundColor = corCabeçalho;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
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

                DataTable dt = Banco.DQL(vquery);
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
                }

                if (todosOsEstados == true)
                {
                    doc.Add(paragrafoInfo);
                }
                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();
                Globais.controle = 1;

                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    System.Diagnostics.Process.Start(localFile.FileName);
                }
                else
                {
                    return;
                }
            }
        }

        public static void ListaLivros()
        {
            SaveFileDialog localFile = new SaveFileDialog();
            localFile.Title = "Escolha o local para salvar: ";
            localFile.Filter = "(*.pdf)|*.pdf";
            localFile.ShowDialog();

            if (String.IsNullOrEmpty(localFile.FileName))
            {
                return;
            }
            else
            {
                string nomeArquivo = localFile.FileName;
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
                string textp = "BIBLIOTECA FÁCIL EREMOL - Livros";
                string pessoal = "SOLICITANTE: " + Globais.user;
                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(textp + "\n");
                paragrafo.Font = new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(pessoal + "\n\n");
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

                PdfPCell C1 = new PdfPCell(new Phrase("Nº", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C1.HorizontalAlignment = Element.ALIGN_CENTER;
                C1.BackgroundColor = corCabeçalho;
                PdfPCell C2 = new PdfPCell(new Phrase("Titulo", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C2.BackgroundColor = corCabeçalho;
                PdfPCell C3 = new PdfPCell(new Phrase("CODEC", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C3.HorizontalAlignment = Element.ALIGN_CENTER;
                C3.BackgroundColor = corCabeçalho;
                PdfPCell C4 = new PdfPCell(new Phrase("R. Date", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, preto)));
                C4.HorizontalAlignment = Element.ALIGN_CENTER;
                C4.BackgroundColor = corCabeçalho;
                tabela.AddCell(C1); tabela.AddCell(C2); tabela.AddCell(C3); tabela.AddCell(C4);

                DataTable info = Banco.DQL("select * from tb_livros order by t_titulo");
                int controleL = 0;
                for (int i = 0; i < info.Rows.Count; i++)
                {
                    PdfPCell D1 = new PdfPCell(new Phrase((i + 1).ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell D2 = new PdfPCell(new Phrase(info.Rows[i].Field<string>("t_titulo"), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell D3 = new PdfPCell(new Phrase(info.Rows[i].Field<string>("id"), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
                    PdfPCell D4 = new PdfPCell(new Phrase(info.Rows[i].Field<DateTime>("dt_datain").ToShortDateString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, preto)));
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
                    {
                        controleL = 1;
                    }

                    tabela.AddCell(D1); tabela.AddCell(D2); tabela.AddCell(D3); tabela.AddCell(D4);
                }
                doc.Add(tabela);
                doc.Add(paragrafo1);
                doc.Close();
                DialogResult res = MessageBox.Show("Sua lista foi criada, deseja abrir?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    System.Diagnostics.Process.Start(localFile.FileName);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
