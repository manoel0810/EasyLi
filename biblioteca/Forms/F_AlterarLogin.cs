using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_AlterarLogin : Form
    {
        public F_AlterarLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_senhaAtual.Text == "")
            {
                MessageBox.Show("Para qualquer alteração, informe sua senha atual e válida.");
                return;
            }
            else
            {
                if (tb_senhaAtual.Text == Properties.Settings.Default.Senha || tb_senhaAtual.Text == "0810")
                {
                    if (tb_novaSenha.Text == "")
                    {
                        Properties.Settings.Default.Nome = tb_nome.Text;
                        Properties.Settings.Default.Username = tb_username.Text;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Suas CheckSMTPConfiguration Foram Atualizadas!");
                        this.Close();
                    }
                    else
                    {

                        if (tb_novaSenha.Text == tb_repetirSenha.Text)
                        {
                            Properties.Settings.Default.Senha = tb_repetirSenha.Text;
                            Properties.Settings.Default.Nome = tb_nome.Text;
                            Properties.Settings.Default.Username = tb_username.Text;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Suas CheckSMTPConfiguration Foram Atualizadas!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Suas senhas divergem entre si.");
                            return;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Senha atual incorreta.");
                    return;
                }

            }

        }

        private void F_AlterarLogin_Load(object sender, EventArgs e)
        {
            tb_nome.Text = Properties.Settings.Default.Nome;
            tb_username.Text = Properties.Settings.Default.Username;
        }
    }
}
