using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
namespace biblioteca
{
    public partial class F_DevolucaoLivro : Form
    {
        private string UserEmail = string.Empty;
        private string Tombo = string.Empty;

        public F_DevolucaoLivro()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            dgv_livrosPdevol.Columns[0].Width = 40;
            dgv_livrosPdevol.Columns[1].Width = 200;
            dgv_livrosPdevol.Columns[2].Width = 200;
        }

        private void F_DevolucaoLivro_Load(object sender, EventArgs e)
        {
            dgv_livrosPdevol.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Aluno', T_LIVRO AS 'Livro' FROM registry WHERE T_STATUS = '{(int)Global.BookStatus.Emprestado}' ORDER BY T_USER");
            FormatarDGV();

            KeyPreview = true;
            FiltroMatricula.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVSelectionChenged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable UserInfo;
                UserInfo = DatabaseController.DataQueryLanguage($"select * from registry where N_REGISTRYCODE = '{dgv_livrosPdevol.SelectedRows[0].Cells[0].Value}'");

                ID.Text = UserInfo.Rows[0].Field<Int64>("N_REGISTRYCODE").ToString();
                NomeUsuario.Text = UserInfo.Rows[0].Field<string>("T_USER");
                Livro.Text = UserInfo.Rows[0].Field<string>("T_LIVRO");
                Data.Text = UserInfo.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                Turma.Text = UserInfo.Rows[0].Field<string>("T_TURMA");
                tb_matricula.Text = UserInfo.Rows[0].Field<string>("T_MATRICULA");
                UserEmail = UserInfo.Rows[0].Field<string>("T_EMAIL");
                Tombo = UserInfo.Rows[0].Field<string>("T_TOMBO");
            }
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            if (dgv_livrosPdevol.SelectedRows.Count == 0)
                return;
            else
            {
                if (Devolvido.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(UserEmail) && MGlobais.CheckSMTPConfiguration())
                    {
                        TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                        string Nome = textInfo.ToTitleCase(NomeUsuario.Text.Split(' ')[0].ToLower());
                        string LivroFormatado = textInfo.ToTitleCase(Livro.Text.ToLower());

                        string MSG = string.Format("Olá {0}. Você realizou a devolução do livro: {1} em {2}. A devolução já foi registrada e a pendência com o mesmo removida. Agradecemos a sua colaboração", Nome, LivroFormatado, DateTime.Today.ToShortDateString());
                        string Body = EmailFormatProvider.FormartString(EmailFormatProvider.EmailFormat.InOutRequest, new string[] { "EasyLi", "Devoluções - EasyLi", MGlobais.GetAPICoverPath(Tombo), MSG });
                        Email.EnviarEmail(Body, "EasyLi", UserEmail);
                    }

                    DatabaseController.DataManipulationLanguage($"UPDATE registry SET T_STATUS='{(int)Global.BookStatus.Devolvido}', T_DATAP = '{MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString())}' WHERE N_REGISTRYCODE = '{ID.Text}'");
                    dgv_livrosPdevol.Rows.Remove(dgv_livrosPdevol.CurrentRow);

                    MessageBox.Show("Devolução efetuada com sucesso", "Devoluções", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Confirme a caixa de diálogo para continuar com a operação.", "Confirmações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void FilterNameChenged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FiltroNome.Text))
            {
                dgv_livrosPdevol.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Aluno', T_LIVRO AS 'Livro' FROM registry WHERE T_STATUS = '{(int)Global.BookStatus.Emprestado}' ORDER BY T_USER");
                FormatarDGV();
                return;
            }
            else if (FiltroNome.Text.Trim().Length >= 0x2)
            {
                dgv_livrosPdevol.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Aluno', T_LIVRO AS 'Livro' FROM registry WHERE T_USER LIKE '%{FiltroNome.Text.Replace("'", "''")}%' or T_LIVRO LIKE '%{FiltroNome.Text.Replace("'", "''")}%' AND T_STATUS = '{(int)Global.BookStatus.Emprestado}'");
                FormatarDGV();
                return;
            }
        }

        private void FilterMatriculaChenged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FiltroMatricula.Text))
            {
                dgv_livrosPdevol.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Aluno', T_LIVRO AS 'Livro' FROM registry WHERE T_STATUS = '{(int)Global.BookStatus.Emprestado}' ORDER BY T_USER");
                FormatarDGV();
                return;
            }
            else if (FiltroMatricula.Text.Trim().Length >= 0x2)
            {
                dgv_livrosPdevol.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Aluno', T_LIVRO AS 'Livro' FROM registry WHERE T_MATRICULA LIKE '%{FiltroMatricula.Text}%' or T_TOMBO LIKE '%{FiltroMatricula.Text}%' AND T_STATUS = '{(int)Global.BookStatus.Emprestado}'");
                FormatarDGV();
                return;
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
