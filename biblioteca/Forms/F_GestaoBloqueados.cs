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

        private static readonly string emaill;
        private static DataTable ddt;
        private static string matri = "";

        private void F_GestaoBloqueados_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM registry WHERE T_STATUS='" + (int)Global.UserState.Blocked + "'";

            dgv_bloqueados.DataSource = DatabaseController.DQL(vquery);
            dgv_bloqueados.Columns[0].Width = 50;
            dgv_bloqueados.Columns[1].Width = 220;
            dgv_bloqueados.Columns[2].Width = 100;
            dgv_bloqueados.Columns[3].Width = 220;
            dgv_bloqueados.Columns[4].Width = 100;

            KeyPreview = true;
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Notification(object sender, EventArgs e)
        {
            if (dgv_bloqueados.SelectedRows.Count <= 0)
                return;

            string email = emaill;
            string body = String.Format("Olá {0}, estamos notificando você via e-mail devido uma pendência ativa do livro {1} que foi pego em {2}, Você se encontra bloqueado no sistema EasyLi pelo mesmo.\n\nPedimos que faça a devolução do mesmo.\n\nNotificado por: {3}\n\nEasyLi", ddt.Rows[0].Field<string>("T_USER"), ddt.Rows[0].Field<string>("T_LIVRO"), ddt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString(), Global.CurrentUserFullname);
            string subject = "Notificação de Livro";

            if (MGlobais.CheckSMTPConfiguration() && MGlobais.Internet())
            {
                Email.EnviarEmail(body, subject, email);
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
                DataTable dt = DatabaseController.DQL($"SELECT * FROM registry WHERE N_REGISTRYCODE='{dgv_bloqueados.SelectedRows[0].Cells[0].Value}'");
                ddt = dt;

                tb_nome.Text = dt.Rows[0].Field<string>("T_USER");
                tb_livro.Text = dt.Rows[0].Field<string>("T_LIVRO");
                tb_id.Text = dt.Rows[0].Field<Int64>("N_REGISTRYCODE").ToString();
                tb_nota.Text = dt.Rows[0].Field<string>("T_NOTAS");
                mask_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                matri = dt.Rows[0].Field<string>("T_MATRICULA");
                string email = dt.Rows[0].Field<string>("T_EMAIL");
                tb_nome.ForeColor = Color.Red;

                btn_notificar.Enabled = !string.IsNullOrWhiteSpace(email);
            }
        }

        private void UnblockCkick(object sender, EventArgs e)
        {
            if (dgv_bloqueados.SelectedRows.Count <= 0)
                return;

            DialogResult res = MessageBox.Show("Deseja remover o bloqueio desse usuário? Ao fazer isso, ele poderá fazer novos empréstimos no sistema", "Registros", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == res)
            {
                string query = $"UPDATE users SET user_status = '{(int)Global.UserState.Free}' WHERE code = '{matri}'";
                DatabaseController.DML(query);
                dgv_bloqueados.Rows.Remove(dgv_bloqueados.CurrentRow);
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

        }
    }
}
