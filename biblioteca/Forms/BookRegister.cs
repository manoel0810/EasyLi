using ISBNQuery;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class BookRegister : Form
    {
        private bool HasCover = false;

        public BookRegister()
        {
            InitializeComponent();
        }

        private void BookRegister_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            MGlobais.SetNumericFieldOnly(ref Tombo);

            Cover.Image = Properties.Resources.no_image;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Titulo.Text) || string.IsNullOrEmpty(Tombo.Text))
            {
                MessageBox.Show("Informe os campos obrigatórios, título e tombo", "Registrar livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DatabaseController.DQL($"select * from tb_livros where id = '{Tombo.Text}'").Rows.Count > 0)
            {
                MessageBox.Show($"O tombo informado já está em uso. Informe outro para registro do livro", "Registrar livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "INSERT INTO tb_livros (id, t_titulo, dt_datain, isbn13, isbn10, publicacao, autor) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7)";
            object[] values = new object[]
            {
                Tombo.Text,
                MGlobais.SanitizeString(Titulo.Text, true),
                MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString()),
                MGlobais.RemoveAllCases(ISBN13.Text, new string[] { "-", "." }),
                MGlobais.RemoveAllCases(ISBN10.Text, new string[] { "-", "." }),
                MGlobais.SanitizeString(Publicacao.Text, true),
                MGlobais.SanitizeString(Autor.Text, true)
            };

            DatabaseController.InsertData(query, values);
            if (HasCover)
                BookImageRegister();


            if (DialogResult.Yes == MessageBox.Show("Livro registrado com êxito. Deseja efetuar mais entradas?", "Registrar livros", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (Control c in Dados.Controls)
                    if (c is TextBox Box)
                        Box.Clear();
                    else if (c is MaskedTextBox Mask)
                        Mask.Clear();

                if (HasCover)
                {
                    Cover.Image = Properties.Resources.no_image;
                    Cover.Update();
                    HasCover = false;
                }

                Titulo.Focus();
            }
            else
                Close();
        }

        private void BookImageRegister()
        {
            if (!Directory.Exists($"{Application.StartupPath}\\img\\covers\\"))
                Directory.CreateDirectory($"{Application.StartupPath}\\img\\covers\\");

            try
            {
                Bitmap myBitmap;
                ImageCodecInfo myImageCodecInfo;
                Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;

                // Create a Bitmap object based on a BMP file.
                myBitmap = new Bitmap(Cover.Image);

                // Get an ImageCodecInfo object that represents the JPEG codec.
                myImageCodecInfo = GetEncoderInfo("image/jpeg");
                myEncoder = Encoder.Quality;
                myEncoderParameters = new EncoderParameters(1);

                // Save the bitmap as a JPEG file with quality level 75.
                myEncoderParameter = new EncoderParameter(myEncoder, 75L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                myBitmap.Save($"{Application.StartupPath}\\img\\covers\\{MGlobais.RemoveAllCases(ISBN10.Text, new string[] { "-", "." })}.jpg", myImageCodecInfo, myEncoderParameters);

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar a capa. Erro: {e.Message}", "Registro de livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }

            return null;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            ISBNSearch Search = new ISBNSearch();
            Search.ShowDialog();

            if (Search.Finished)
            {
                Book Livro = Search.Livro;
                Image CoverISBN = Search.Cover;

                if (Cover != null)
                {
                    Cover.Image = CoverISBN;
                    HasCover = true;
                }

                Titulo.Text = Livro.Title;
                Autor.Text = Livro.Author;
                ISBN13.Text = Livro.ISBN13;
                ISBN10.Text = Livro.ISBN10;
                Publicacao.Text = Livro.Publish_Date;
            }

            Search.Dispose();
        }
    }
}
