using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_EsqueciSenha : Form
    {
        public F_EsqueciSenha()
        {
            InitializeComponent();
        }

        private static int DadosValidados = 0;
        private static int PasswordLenght = 0;

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AcaoClick(object sender, EventArgs e)
        {
            if (DadosValidados == 1)
            {
                if (Senha.Text == "" || RepetirSenha.Text == "")
                {
                    SenhaMSG.Text = "Informe corretamente os campos.";
                    SenhaMSG.Visible = true;
                    SenhaMSG.Refresh();

                    SenhaMSG.ForeColor = Color.DarkRed;
                    return;
                }
                else
                {
                    if (Senha.Text != RepetirSenha.Text)
                    {
                        SenhaMSG.Text = "Suas senhas estão diferentes.";
                        SenhaMSG.Visible = true;
                        SenhaMSG.Refresh();

                        SenhaMSG.ForeColor = Color.DarkRed;
                        return;
                    }
                    else
                    {
                        if (MGlobais.AntiSQLInjection(Username.Text) || MGlobais.AntiSQLInjection(Senha.Text))
                        {
                            MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar a atualização, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DatabaseController.DML(String.Format("UPDATE tb_login SET T_TOKEN = '{0}' WHERE T_USER = '{1}'", MGlobais.GenereteUserToken(Username.Text, RepetirSenha.Text), Username.Text));
                        MessageBox.Show("Seu cadastro foi atualizado", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }

            if (MGlobais.AntiSQLInjection(Username.Text) || MGlobais.AntiSQLInjection(Senha.Text))
            {
                MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar a atualização, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int NivelDeAcesso = NivelBasico.Checked ? (int)Global.UserPrivilege.Normal : (int)Global.UserPrivilege.Superuser;
            DataTable dt = DatabaseController.DQL($"SELECT * FROM tb_login WHERE T_USER = '{Username.Text}' AND N_PRIV = '{NivelDeAcesso}' and T_NOMECOMPLETO = '{Nome.Text}'");

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Não achamos nenhum registro com as informações fornecidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Senha.Visible = true;
                RepetirSenha.Visible = true;
                lb_senha.Visible = true;
                lb_Rsenha.Visible = true;
                Nome.Enabled = false;
                Username.Enabled = false;
                NivelAvancado.Enabled = false;
                NivelBasico.Enabled = false;
                Acao.Text = "Salvar";
                DadosValidados = 1;
            }
        }

        private void SenhaTextChenged(object sender, EventArgs e)
        {
            PasswordLenght = Senha.Text.Length;
        }

        private void RSenhaTextChenged(object sender, EventArgs e)
        {
            if (RepetirSenha.Text.Length < PasswordLenght && SenhaMSG.Visible)
            {
                SenhaMSG.Visible = false;
                SenhaMSG.Refresh();
            }

            if (RepetirSenha.Text.Length >= PasswordLenght)
            {
                if (Senha.Text != RepetirSenha.Text)
                {
                    SenhaMSG.Text = "Suas senhas estão diferentes.";
                    SenhaMSG.Visible = true;
                    SenhaMSG.ForeColor = Color.DarkRed;
                    SenhaMSG.Refresh();
                }
                else if (Senha.Text == RepetirSenha.Text)
                {
                    SenhaMSG.Visible = false;
                }
            }
        }

        private void Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            var KEA = MGlobais.FormatNameCamp(e, (TextBox)sender);
            Nome = KEA.TXT;
        }
    }
}
