using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_ControleUsuarios : Form
    {
        public F_ControleUsuarios()
        {
            InitializeComponent();
        }
        DataTable InfoGlobal = new DataTable();
        private static int idU = 0;

        private void F_ControleUsuarios_Load(object sender, EventArgs e)
        {
            rb_nao.Checked = true;
            tb_RNovaSenha.Enabled = false;
            tb_novaSenha.Enabled = false;
            DataTable infUser = new DataTable();
            infUser = Banco.DQL("SELECT * FROM tb_login WHERE T_USER = '" + Globais.userLog + "'");
            InfoGlobal = infUser;

            lb_nomeCompleto.Text = infUser.Rows[0].Field<string>("T_NOMECOMPLETO");
            lb_usuario.Text = infUser.Rows[0].Field<string>("T_USER");
            idU = int.Parse(infUser.Rows[0].Field<Int64>("id").ToString());
            tb_nome.Text = lb_nomeCompleto.Text;
            tb_user.Text = lb_usuario.Text;

            string privlegio = "";
            int priv = int.Parse(infUser.Rows[0].Field<Int64>("N_PRIV").ToString());
            if (priv == 1)
            {
                privlegio = "Simples";
                lb_tipo.ForeColor = Color.DarkBlue;
                tabControl1.TabPages.Remove(tabPage2);
            }
            else
            {
                privlegio = "Avançado";
                lb_tipo.ForeColor = Color.DarkGreen;
            }

            lb_tipo.Text = privlegio;
            lb_tipo.Refresh();

            if (privlegio == "Avançado")
            {
                DataTable dgv = new DataTable();
                dgv = Banco.DQL("SELECT id AS 'ID', T_USER AS 'Usuário', T_NOMECOMPLETO AS 'Nome' FROM tb_login");
                dgv_login.DataSource = dgv;
                dgv_login.Columns[0].Width = 70;
                dgv_login.Columns[1].Width = 150;
                dgv_login.Columns[2].Width = 265;
            }

            this.KeyPreview = true;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sim.Checked)
            {
                tb_novaSenha.Enabled = true;
                tb_RNovaSenha.Enabled = true;
            }
            else
            {
                tb_novaSenha.Enabled = false;
                tb_RNovaSenha.Enabled = false;
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            string query = "";

            if (MGlobais.AntiSQLInjection(tb_user.Text) == true || MGlobais.AntiSQLInjection(tb_RNovaSenha.Text) == true)
            {
                MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar a atualização, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tb_ConfSenha.Text == "")
            {
                MessageBox.Show("Para qualquer alteração do usuário, é pedido a senha do mesmo.", "Informe Uma Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (tb_ConfSenha.Text == InfoGlobal.Rows[0].Field<string>("T_SENHA"))
                {
                    if (rb_sim.Checked)
                    {
                        if (ValidarSaida(tb_user.Text))
                        {
                            query = String.Format("UPDATE tb_login SET T_USER = '{0}', T_SENHA = '{1}', T_NOMECOMPLETO = '{2}' WHERE T_USER = '{3}'", tb_user.Text, tb_RNovaSenha.Text, tb_nome.Text, InfoGlobal.Rows[0].Field<string>("T_USER"));
                            Banco.DML(query);
                            Globais.userLog = tb_user.Text;
                            Globais.user = tb_nome.Text;

                            MessageBox.Show("Informações atualizadas.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Algum usuário já usa este Username. Escolha outro", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    else
                    {
                        if (ValidarSaida(tb_user.Text))
                        {
                            query = String.Format("UPDATE tb_login SET T_USER = '{0}', T_NOMECOMPLETO = '{1}' WHERE T_USER = '{2}'", tb_user.Text, tb_nome.Text, InfoGlobal.Rows[0].Field<string>("T_USER"));
                            Banco.DML(query);
                            Globais.userLog = tb_user.Text;
                            Globais.user = tb_nome.Text;

                            MessageBox.Show("Informações atualizadas.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Algum usuário já usa este Username. Escolha outro", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Senha Incorreta. Forneça a senha deste usuário", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private bool ValidarSaida(string user)
        {
            bool saida;
            int protocolo = 0;
            DataTable dt = new DataTable();
            DataTable consultas = new DataTable();
            string vquery = String.Format("SELECT * FROM tb_login WHERE id =" + idU);
            dt = Banco.DQL(vquery);

            if (tb_user.Text == dt.Rows[0].Field<string>("T_USER"))
            {
                saida = true;
            }
            else
            {
                consultas = Banco.DQL("SELECT * FROM tb_login WHERE T_USER = '" + tb_user.Text + "'");
                protocolo = consultas.Rows.Count;
                if (protocolo > 0)
                {
                    saida = false;
                }
                else
                {
                    saida = true;
                }
            }

            return saida;
        }

        private bool ValidarSaidaAvancado(string user, int id)
        {
            bool saida;
            int protocolo = 0;
            DataTable dt = new DataTable();
            DataTable consultas = new DataTable();
            string vquery = String.Format("SELECT * FROM tb_login WHERE id =" + id);
            dt = Banco.DQL(vquery);

            if (tb_user2.Text == dt.Rows[0].Field<string>("T_USER"))
            {
                saida = true;
            }
            else
            {
                consultas = Banco.DQL("SELECT * FROM tb_login WHERE T_USER = '" + tb_user2.Text + "'");
                protocolo = consultas.Rows.Count;
                if (protocolo > 0)
                {
                    saida = false;
                }
                else
                {
                    saida = true;
                }
            }

            return saida;
        }

        private void dgv_login_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rows = 0;
            rows = dgv.SelectedRows.Count;

            if (rows > 0)
            {
                DataTable dt = new DataTable();
                string vquery = "SELECT * FROm tb_login WHERE id ='" + dgv.SelectedRows[0].Cells[0].Value + "'";
                dt = Banco.DQL(vquery);

                tb_nomeCompleto2.Text = dt.Rows[0].Field<string>("T_NOMECOMPLETO");
                tb_senha2.Text = dt.Rows[0].Field<string>("T_SENHA");
                tb_user2.Text = dt.Rows[0].Field<string>("T_USER");
                int tipoPriv = int.Parse(dt.Rows[0].Field<Int64>("N_PRIV").ToString());
                if (tipoPriv == 0)
                {
                    cb_privi.Text = "Avançado";
                }
                else if (tipoPriv == 1)
                {
                    cb_privi.Text = "Simples";
                }
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (dgv_login.SelectedRows.Count <= 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Você deseja realmente apagar este login?", "Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string vquery = "DELETE FROM tb_login WHERE T_USER = '" + tb_user2.Text + "'";
                Banco.DML(vquery);
                dgv_login.Rows.Remove(dgv_login.CurrentRow);
            }
        }

        private void btn_aplicar2_Click(object sender, EventArgs e)
        {
            if (dgv_login.SelectedRows.Count <= 0)
            {
                return;
            }

            if (MGlobais.AntiSQLInjection(tb_user2.Text) == true || MGlobais.AntiSQLInjection(tb_senha2.Text) == true)
            {
                MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar a atualização, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarSaidaAvancado(tb_user2.Text, int.Parse(dgv_login.SelectedRows[0].Cells[0].Value.ToString())))
            {
                int valorReal = 0;
                if (cb_privi.Text == "Avançado")
                {
                    valorReal = 0;
                }
                else
                {
                    valorReal = 1;
                }
                string vquery = "UPDATE tb_login SET T_USER = '" + tb_user2.Text + "', T_NOMECOMPLETO = '" + tb_nomeCompleto2.Text + "', T_SENHA = '" + tb_senha2.Text + "', N_PRIV = '" + valorReal + "' WHERE id = '" + dgv_login.SelectedRows[0].Cells[0].Value + "'";
                Banco.DML(vquery);
                MessageBox.Show("Informações alteradas. Atualize a página para ver mudanças.", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Username que você digitou, já é de outro usuário.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void F_ControleUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
