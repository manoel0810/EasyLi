using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_GestaoBloqueados : Form
    {
        public F_GestaoBloqueados()
        {
            InitializeComponent();
        }

        private const int MargemDeRecuo = 15;
        private string UserEmail;
        private DataTable UserInformations;

        private void FormLoad(object sender, EventArgs e)
        {
            KeyPreview = true;
            Usuarios.DataSource = DatabaseController.DQL($"select code as 'Code', user_name as 'Nome completo' from users where user_status = '{(int)Global.UserState.Blocked}'");
            FormatDGVUsers();
        }

        private void FormatDGVUsers()
        {
            Usuarios.Columns[0].Width = 50;
            Usuarios.Columns[1].Width = Usuarios.Width - (Usuarios.Columns[0].Width + MargemDeRecuo);
        }

        private void FormatDGVBooks()
        {
            Livros.Columns[0].Width = 50;
            Livros.Columns[2].Width = 80;
            Livros.Columns[1].Width = Livros.Width - (Livros.Columns[0].Width + Livros.Columns[2].Width + MargemDeRecuo);
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Notification(object sender, EventArgs e)
        {
            if (Livros.SelectedRows.Count <= 0)
                return;

            string body = String.Format("Olá {0}, estamos notificando você via e-mail devido uma pendência ativa do livro {1} que foi pego em {2}, Você se encontra bloqueado no sistema EasyLi pelo mesmo.\n\nPedimos que faça a devolução do mesmo.\n\nNotificado por: {3}\n\nEasyLi", UserInformations.Rows[0].Field<string>("T_USER"), UserInformations.Rows[0].Field<string>("T_LIVRO"), UserInformations.Rows[0].Field<DateTime>("T_DATA").ToShortDateString(), Global.CurrentUserFullname);
            string subject = "Notificação de Livro";

            if (MGlobais.CheckSMTPConfiguration() && MGlobais.Internet())
            {
                Email.EnviarEmail(body, subject, UserEmail);
                MessageBox.Show("O aluno será notificado.", "Serviço SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Não é possível notificar. Verifique suas credênciais e conexão com a internet.", "ERRO SMTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DGVSelectionChenged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = DatabaseController.DQL($"SELECT * FROM registry WHERE N_REGISTRYCODE='{Livros.SelectedRows[0].Cells[0].Value}'");
                UserInformations = dt;

                tb_nome.Text = dt.Rows[0].Field<string>("T_USER");
                tb_livro.Text = dt.Rows[0].Field<string>("T_LIVRO");
                tb_id.Text = dt.Rows[0].Field<Int64>("N_REGISTRYCODE").ToString();
                tb_nota.Text = dt.Rows[0].Field<string>("T_NOTAS");
                mask_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                UserEmail = dt.Rows[0].Field<string>("T_EMAIL");
                tb_nome.ForeColor = Color.Red;

                Notificar.Enabled = !string.IsNullOrWhiteSpace(UserEmail);
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (Usuarios.SelectedRows.Count > 0)
            {
                Livros.DataSource = DatabaseController.DQL($"SELECT N_REGISTRYCODE AS 'ID',  T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM registry WHERE T_MATRICULA = '{Usuarios.SelectedRows[0].Cells[0].Value}' and T_STATUS != '{(int)Global.BookStatus.Devolvido}'");
                FormatDGVBooks();
            }
        }
    }
}
