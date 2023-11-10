using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private int tamanho = 0;
        private bool IsSerialValid = false;
        private ToolTip Tip = null;
        private Global.UserPrivilege UserSerial = Global.UserPrivilege.Normal;

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateClick(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox Box)
                    if (string.IsNullOrWhiteSpace(Box.Text))
                    {
                        MessageBox.Show("Informe todos os campos corretamente", "Cadastro de usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

            if (!IsSerialValid)
                return;

            if (MGlobais.AntiSQLInjection(Username.Text) || MGlobais.AntiSQLInjection(Senha.Text))
            {
                MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar seu cadastro, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarUser(Username.Text))
            {
                string vquery = String.Format("INSERT INTO tb_login (T_USER, T_TOKEN, T_NOMECOMPLETO, N_PRIV) VALUES ('{0}', '{1}', '{2}', '{3}')", MGlobais.SanitizeString(Username.Text), MGlobais.GenereteUserToken(Username.Text, Senha.Text), MGlobais.SanitizeString(Nome.Text), (int)UserSerial);
                DatabaseController.DataManipulationLanguage(vquery);

                MessageBox.Show("Cadastro efetuado com êxito!", "Cadastro de usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Já existe um usuário com este Username registrado. Escolha outro para seu login.", "Cadastro de usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private bool ValidarUser(string Username)
        {
            DataTable dt = DatabaseController.DataQueryLanguage($"SELECT * FROM tb_login WHERE T_USER = '{Username}'");
            return !(dt.Rows.Count > 0);
        }

        private void SerialTextChenged(object sender, EventArgs e)
        {
            if (Serial.Text.Length >= 10)
            {
                int tipo = MGlobais.TipoSerial(Serial.Text);
                if ((int)Global.UserPrivilege.Superuser == tipo)
                {
                    lb_nível.Visible = true;
                    lb_nível.Text = "Avançado";
                    lb_nível.ForeColor = Color.DarkGreen;
                    lb_nível.Refresh();

                    UserSerial = (Global.UserPrivilege)(tipo);
                    IsSerialValid = true;
                    return;
                }
                else if ((int)Global.UserPrivilege.Normal == tipo)
                {
                    lb_nível.Visible = true;
                    lb_nível.Text = "Básico";
                    lb_nível.ForeColor = Color.DarkBlue;
                    lb_nível.Refresh();

                    UserSerial = (Global.UserPrivilege)(tipo);
                    IsSerialValid = true;
                    return;
                }
                else if ((int)Global.UserPrivilege.NotDefined == tipo)
                {
                    lb_nível.Visible = true;
                    lb_nível.Text = "Inválido";
                    lb_nível.ForeColor = Color.DarkRed;
                    lb_nível.Refresh();
                    IsSerialValid = false;
                    return;
                }
            }

            if (Serial.Text.Length < 10 && lb_nível.Visible)
            {
                IsSerialValid = false;
                lb_nível.Visible = false;
            }
        }

        private void SenhaChenged(object sender, EventArgs e)
        {
            tamanho = Senha.Text.Length;
        }

        private void RSenhaChenged(object sender, EventArgs e)
        {
            if (RSenha.Text.Length >= tamanho)
            {
                if (Senha.Text != RSenha.Text)
                {
                    lb_senhas.Visible = true;
                    lb_senhas.Text = "Suas Senhas Estão Diferentes";
                    lb_senhas.ForeColor = Color.DarkRed;
                    lb_senhas.Refresh();
                    return;
                }
            }

            if (lb_senhas.Visible && RSenha.Text.Length < tamanho)
            {
                lb_senhas.Visible = false;
                lb_senhas.Refresh();
                return;
            }
        }

        private void Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            var KEA = MGlobais.FormatNameCamp(e, (TextBox)sender);
            Nome = KEA.TXT;
        }

        private void Serial_MouseHover(object sender, EventArgs e)
        {
            Tip?.Dispose();
            Tip = new ToolTip();

            Tip.SetToolTip((TextBox)sender, "Os seriais podem ser encontrados na documentação do software");
        }
    }
}
