using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class CorrecaoLivros : Form
    {
        private string CurrentBookIdentificarion = string.Empty;

        public CorrecaoLivros()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            Livros.Columns[0].Width = 70;
            Livros.Columns[1].Width = 275;
            Livros.Columns[2].Width = 80;
        }

        private void CorrecaoLivros_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            Livros.DataSource = DatabaseController.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros order by dt_datain");
            FormatarDGV();

            MGlobais.SetNumericFieldOnly(ref Tombo);
            MGlobais.SetNumericFieldOnly(ref FiltroTombo);
        }

        private void DGVSelectionChenged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable Book = DatabaseController.DQL($"select * from tb_livros where id = '{dgv.SelectedRows[0].Cells[0].Value}'");

                Titulo.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                DataRegistro.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                Tombo.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                CurrentBookIdentificarion = dgv.SelectedRows[0].Cells[0].Value.ToString();

                ISBN13.Text = Book.Rows[0].Field<string>("isbn13");
                ISBN10.Text = Book.Rows[0].Field<string>("isbn10");
                Publicacao.Text = Book.Rows[0].Field<string>("publicacao");
                Autores.Text = Book.Rows[0].Field<string>("autor");

            }
        }

        private void CorrecaoLivros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void VoltarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcluirClick(object sender, EventArgs e)
        {
            if (Livros.SelectedRows.Count < 1)
                return;

            if (DialogResult.Yes == MessageBox.Show("Você tem certeza que deseja apagar este registros?", "Apagar livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DatabaseController.DML(String.Format("delete from tb_livros where id = '{0}'", Livros.SelectedRows[0].Cells[0].Value.ToString()));
                Livros.Rows.Remove(Livros.CurrentRow);

                MessageBox.Show("O livro foi apagado do sistema", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvaClick(object sender, EventArgs e)
        {
            if (Livros.SelectedRows.Count < 1)
                return;

            if (string.IsNullOrEmpty(Tombo.Text) || string.IsNullOrEmpty(Titulo.Text))
            {
                MessageBox.Show("Informe todos os dados obrigatórios", "Correção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool ChangeBookID = false;
            if (Tombo.Text != Livros.SelectedRows[0].Cells[0].Value.ToString())
            {
                DataTable count = DatabaseController.DQL(String.Format("select * from tb_livros where id = '{0}'", Tombo.Text));
                if (count.Rows.Count > 0)
                {
                    MessageBox.Show("Este tombo não está disponível. Troque para outro", "Unique block", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                    ChangeBookID = true;
            }

            string query = String.Format("update tb_livros set id = '{0}', t_titulo = '{1}', dt_datain = '{2}', isbn13 = '{3}', isbn10 = '{4}', publicacao = '{5}', autor = '{6}' where id = '{7}'", Tombo.Text, MGlobais.SanitizeString(Titulo.Text, true), MGlobais.FormatarDataSQL(DataRegistro.Text), ISBN13.Text.Replace("-", "").Replace(".", ""), ISBN10.Text.Replace("-", ""), MGlobais.SanitizeString(Publicacao.Text, true), MGlobais.SanitizeString(Autores.Text, true), CurrentBookIdentificarion);
            DatabaseController.DML(query);
            if (ChangeBookID)
                DatabaseController.DML($"update registry set T_TOMBO = '{Tombo.Text}' where T_TOMBO = '{CurrentBookIdentificarion}'");

            Livros.SelectedRows[0].Cells[0].Value = Tombo.Text;
            Livros.SelectedRows[0].Cells[1].Value = Titulo.Text;
            Livros.SelectedRows[0].Cells[2].Value = DataRegistro.Text;
            MessageBox.Show("Dados salvos com êxito", "Dados salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FiltroTituloTextChenged(object sender, EventArgs e)
        {
            if (FiltroTitulo.Text.Length > 2)
            {
                Livros.DataSource = DatabaseController.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros where t_titulo like '%" + FiltroTitulo.Text + "%'");
                FormatarDGV();
            }
            else if (FiltroTitulo.Text.Length == 0)
            {
                Livros.DataSource = DatabaseController.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros order by dt_datain");
                FormatarDGV();
            }
        }

        private void FiltroTomboTextChenged(object sender, EventArgs e)
        {
            if (FiltroTombo.Text.Length > 2)
            {
                Livros.DataSource = DatabaseController.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros where id like '%" + FiltroTombo.Text + "%'");
                FormatarDGV();
            }
            else if (FiltroTombo.Text.Length == 0)
            {
                Livros.DataSource = DatabaseController.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros order by dt_datain");
                FormatarDGV();
            }
        }

        private void Autores_KeyPress(object sender, KeyPressEventArgs e)
        {
            var KEA = MGlobais.FormatNameCamp(e, (TextBox)sender);
            Autores = KEA.TXT;
        }
    }
}
