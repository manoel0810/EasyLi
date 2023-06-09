using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class ControlePessoal : Form
    {
        private string CurrentUsername = string.Empty;
        private ToolTip Tip = null;

        public ControlePessoal()
        {
            InitializeComponent();
        }

        private void F_ControleUsuarios_Load(object sender, EventArgs e)
        {

            DataTable infUser = DatabaseController.DQL($"SELECT * FROM tb_login WHERE T_TOKEN = '{Global.CurrentUserAccessToken}'");
            Nome.Text = infUser.Rows[0].Field<string>("T_NOMECOMPLETO");
            Username.Text = infUser.Rows[0].Field<string>("T_USER");
            CurrentUsername = infUser.Rows[0].Field<string>("T_USER");

            int Privilegio = int.Parse(infUser.Rows[0].Field<Int64>("N_PRIV").ToString());
            if ((int)Global.UserPrivilege.Normal == Privilegio)
            {
                lb_tipo.Text = "Simples";
                lb_tipo.ForeColor = Color.DarkBlue;
            }
            else if ((int)Global.UserPrivilege.Superuser == Privilegio)
            {
                lb_tipo.Text = "Avançado";
                lb_tipo.ForeColor = Color.DarkGreen;
            }

            KeyPreview = true;
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (MGlobais.AntiSQLInjection(Username.Text) || MGlobais.AntiSQLInjection(RepetirNovaSenha.Text))
            {
                MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar a atualização, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SenhaAtual.Text == "")
            {
                MessageBox.Show("Para qualquer alteração do usuário, é pedido a senha do mesmo.", "Informe Uma Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (Global.CurrentUserAccessToken == MGlobais.GenereteUserToken(CurrentUsername, SenhaAtual.Text))
                {
                    if (AlterarSenha.Checked)
                    {
                        if ((NovaSenha.Text != RepetirNovaSenha.Text) && NovaSenha.Text.Trim().Length == 0 && RepetirNovaSenha.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("As senhas que você digitou estão diferêntes entre si", "Correção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (NovaSenha.Text.Trim().Length < 0x4)
                        {
                            MessageBox.Show("A sua senha deve conter no mínimo quatro caracteres", "Correção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (VerifyUserAvaible(Username.Text))
                        {
                            string NewToken = MGlobais.GenereteUserToken(Username.Text, NovaSenha.Text);
                            string Query = String.Format("UPDATE tb_login SET T_USER = '{0}', T_TOKEN = '{1}', T_NOMECOMPLETO = '{2}' WHERE T_TOKEN = '{3}'", Username.Text, NewToken, Nome.Text, Global.CurrentUserAccessToken);
                            DatabaseController.DML(Query);

                            Global.CurrentUsername = Username.Text;
                            Global.CurrentUserFullname = Nome.Text;
                            Global.CurrentUserAccessToken = NewToken;
                            MessageBox.Show("Informações atualizadas.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Algum usuário já usa este Username. Escolha outro para poder registrar um novo nome de acesso", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    else
                    {
                        if (VerifyUserAvaible(Username.Text))
                        {
                            string NewToken = MGlobais.GenereteUserToken(Username.Text, SenhaAtual.Text);
                            string Query = String.Format("UPDATE tb_login SET T_USER = '{0}', T_TOKEN = '{1}', T_NOMECOMPLETO = '{2}' WHERE T_TOKEN = '{3}'", Username.Text, NewToken, Nome.Text, Global.CurrentUserAccessToken);
                            DatabaseController.DML(Query);

                            Global.CurrentUsername = Username.Text;
                            Global.CurrentUserFullname = Nome.Text;
                            Global.CurrentUserAccessToken = NewToken;
                            MessageBox.Show("Informações atualizadas.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Algum usuário já usa este Username. Escolha outro para poder registrar um novo nome de acesso", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A senha atual do usuário informada está incorreta. Confirme a senha para prosseguir com alterações", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private bool VerifyUserAvaible(string Username)
        {
            DataTable UserFind = DatabaseController.DQL($"select T_TOKEN from tb_login where T_USER = '{Username}'");
            if (UserFind.Rows.Count == 0)
            {
                UserFind.Dispose();
                return true;
            }
            else
            {
                if (UserFind.Rows[0].Field<string>("T_TOKEN") == Global.CurrentUserAccessToken)
                {
                    UserFind.Dispose();
                    return true;
                }
                else
                {
                    UserFind.Dispose();
                    return false;
                }
            }
        }


        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ExitButton.PerformClick();
            else if (e.KeyCode == Keys.Delete)
                DelteButton.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                SaveUser.PerformClick();

        }

        private void AlterarSenha_CheckedChanged(object sender, EventArgs e)
        {
            PainelSenhas.Enabled = AlterarSenha.Checked;
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SenhaAtual.Text) || MGlobais.GenereteUserToken(CurrentUsername, SenhaAtual.Text) != Global.CurrentUserAccessToken)
            {
                MessageBox.Show("Confirme a senha do usuário para efetuar essa ação", "Apagar usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Ao apagar o usuário, você será desconectado do sistema. Deseja continuar?", "Apagar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DatabaseController.DML($"delete from tb_login where T_TOKEN = '{Global.CurrentUserAccessToken}'");
                MessageBox.Show("O sistema será finalizado...", "Saindo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void SenhaAtual_MouseHover(object sender, EventArgs e)
        {
            Tip?.Dispose();
            Tip = new ToolTip();

            Tip.SetToolTip((TextBox)sender, "Campo para confirmação da senha do usuário");
        }

        private void Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            var KEA = MGlobais.FormatNameCamp(e, (TextBox)sender);
            Nome = KEA.TXT;
        }
    }
}
