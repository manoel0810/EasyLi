using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private static int tamanho = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O serial serve para regrar os privilégios dentro do Softwere. Existem dois seriais, use o respectivo ao seu privilégio no programa.\n\nOs códigos podem ser encontrados na documentação do Biblioteca Fácil.", "Nota de Descrição", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "" || tb_senha.Text == "" || tb_Rsenha.Text == "" || tb_username.Text == "" || tb_serial.Text == "")
            {
                SystemSound son = SystemSounds.Exclamation;
                son.Play();
                return;
            }

            if (tb_senha.Text != tb_Rsenha.Text)
            {
                MessageBox.Show("Suas senhas estão difetentes entre si.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int TipoSerial = MGlobais.TipoSerial(tb_serial.Text);

            if (TipoSerial == 3)
            {
                MessageBox.Show("O serial fornecido é inválido. Por favor, forneça um válido", "Serial Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MGlobais.AntiSQLInjection(tb_username.Text) == true || MGlobais.AntiSQLInjection(tb_senha.Text) == true)
            {
                MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar seu cadastro, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MGlobais.ValidarUser(tb_username.Text))
            {
                string vquery = String.Format("INSERT INTO tb_login (T_USER, T_SENHA, T_NOMECOMPLETO, N_PRIV) VALUES ('{0}', '{1}', '{2}', '{3}')", MGlobais.SanitizeString(tb_username.Text), tb_Rsenha.Text, MGlobais.SanitizeString(tb_nome.Text), TipoSerial);
                Banco.DML(vquery);

                MessageBox.Show("Cadastro efetuado com êxito!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Já existe um usuário com este Username registrado. Escolha outro para seu login.", "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void tb_serial_TextChanged(object sender, EventArgs e)
        {
            if (tb_serial.Text.Length >= 10)
            {
                int tipo = MGlobais.TipoSerial(tb_serial.Text);
                if (tipo == 0)
                {
                    lb_nível.Visible = true;
                    lb_nível.Text = "Avançado";
                    lb_nível.ForeColor = Color.DarkGreen;
                    lb_nível.Refresh();
                    return;
                }
                else if (tipo == 1)
                {
                    lb_nível.Visible = true;
                    lb_nível.Text = "Básico";
                    lb_nível.ForeColor = Color.DarkBlue;
                    lb_nível.Refresh();
                    return;
                }
                else if (tipo == 3)
                {
                    lb_nível.Visible = true;
                    lb_nível.Text = "Inválido";
                    lb_nível.ForeColor = Color.DarkRed;
                    lb_nível.Refresh();
                    return;
                }
            }
            if (tb_serial.Text.Length < 10 && lb_nível.Visible == true)
            {
                lb_nível.Visible = false;
            }
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
            tamanho = tb_senha.Text.Length;
        }

        private void tb_Rsenha_TextChanged(object sender, EventArgs e)
        {
            if (tb_Rsenha.Text.Length >= tamanho)
            {
                if (tb_senha.Text != tb_Rsenha.Text)
                {
                    lb_senhas.Visible = true;
                    lb_senhas.Text = "Suas Senhas Estão Diferentes";
                    lb_senhas.ForeColor = Color.DarkRed;
                    lb_senhas.Refresh();
                    return;
                }
            }

            if (lb_senhas.Visible == true && tb_Rsenha.Text.Length < tamanho)
            {
                lb_senhas.Visible = false;
                lb_senhas.Refresh();
                return;
            }
        }
    }
}
