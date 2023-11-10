using ISBNQuery;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class ISBNSearch : Form
    {
        public Image Cover { get; private set; }
        public Book Livro { get; private set; }
        public bool Finished { get; private set; }
        public ISBNSearch()
        {
            InitializeComponent();
            Finished = false;
        }

        private async void Buscar_Click(object sender, EventArgs e)
        {
            Buscar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            string ISBNSanitized = MGlobais.RemoveAllCases(ISBN.Text, new string[] { "-", "." });

            if (ISBNSanitized.Length < 0xa)
            {
                MessageBox.Show("O código ISBN é inválido", "ISBN - Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar.Enabled = true;
                Cursor = Cursors.Default;
                return;
            }
            else if (!await MGlobais.Internet())
            {
                MessageBox.Show("Não foi possívels e conectar à rede de internet", "ISBN - Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                Livro = Consultas.ConsultarISBN(ISBNSanitized, false);
                if (Livro != null)
                {
                    if (Capa.Checked && Livro.HasCover)
                    {
                        Cover = Consultas.GetCompostImage(Consultas.ImageSize.M, Livro);
                    }

                    Finished = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível recuperar as informações do ISBN", "ISBN - Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
    }
}
