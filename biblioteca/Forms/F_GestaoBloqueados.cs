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

        private static string emaill;
        private static DataTable ddt;
        private static string matri = "";

        private void F_GestaoBloqueados_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_STATUS='" + Global.BookStatus.Bloqueado + "'";
            dgv_bloqueados.DataSource = DatabaseController.DQL(vquery);
            dgv_bloqueados.Columns[0].Width = 50;
            dgv_bloqueados.Columns[1].Width = 220;
            dgv_bloqueados.Columns[2].Width = 100;
            dgv_bloqueados.Columns[3].Width = 220;
            dgv_bloqueados.Columns[4].Width = 100;

            this.KeyPreview = true;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_notificar_Click(object sender, EventArgs e)
        {
            if (dgv_bloqueados.SelectedRows.Count <= 0)
            {
                return;
            }
            btn_notificar.Cursor = Cursors.WaitCursor;
            string email = emaill;
            string body = String.Format("Olá {0}, estamos notificando você via e-mail devido uma pendência ativa do livro {1} que foi pego em {2}, Você se encontra bloqueado no sistema BF Fácil pelo mesmo.\n\nPedimos que faça a devolução do mesmo.\n\nNotificado por: {3}\n\nEquipe EREMOL", ddt.Rows[0].Field<string>("T_ALUNO"), ddt.Rows[0].Field<string>("T_LIVRO"), ddt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString(), Globais.user);
            string subject = "Notificação de Livro";
            if (MGlobais.CheckSMTPConfiguration() && MGlobais.Internet() == false)
            {
                Email.EnviarEmail(body, subject, email);
                btn_notificar.Cursor = Cursors.Hand;
                MessageBox.Show("O aluno será notificado.", "Serviço SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Não é possível notificar. Verifique suas credênciais e conexão com a internet.", "ERRO SMTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_notificar.Cursor = Cursors.Hand;
                return;
            }
        }

        private void dgv_bloqueados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            DataTable dt = new DataTable();
            if (contLinhas > 0)
            {
                int id = int.Parse(dgv_bloqueados.SelectedRows[0].Cells[0].Value.ToString());
                dt = Banco.DQL("SELECT * FROM tb_dadosaluno WHERE N_IDLIVROALUNO=" + id);
                ddt = dt;
                tb_nome.Text = dt.Rows[0].Field<string>("T_ALUNO");
                tb_nome.ForeColor = Color.Red;
                tb_livro.Text = dt.Rows[0].Field<string>("T_LIVRO");
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDLIVROALUNO").ToString();
                tb_nota.Text = dt.Rows[0].Field<string>("T_NOTAS");
                mask_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                matri = dt.Rows[0].Field<string>("T_MATRICULA");
                string email = dt.Rows[0].Field<string>("T_EMAIL");
                if (email == "")
                {
                    btn_notificar.Enabled = false;
                }
                else
                {
                    btn_notificar.Enabled = true;
                    emaill = email;
                }
            }
        }

        private void btn_desbloquear_Click(object sender, EventArgs e)
        {
            if (dgv_bloqueados.SelectedRows.Count <= 0)
            {
                return;
            }
            DialogResult res = MessageBox.Show("Ao desbloquear o registro, ele passará a ser 'Devolvido'.\nDeseja continuar?", "Registros", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == res)
            {
                string vquery = "UPDATE tb_dadosaluno SET T_STATUS='" + Global.BookStatus.Devolvido + "', T_DATAP = '" + MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString()) + "' WHERE N_IDLIVROALUNO='" + tb_id.Text + "'";
                Banco.DML(vquery);

                string query = "UPDATE tb_matriculas SET T_ESTADO = 'ATIVO' WHERE T_MATRICULA = '" + matri + "'";
                Banco.DML(query);
                dgv_bloqueados.Rows.Remove(dgv_bloqueados.CurrentRow);
            }
        }

        private void F_GestaoBloqueados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
