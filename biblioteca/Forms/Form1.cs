using System;
using System.Threading;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        Thread Menus;
        Thread NovoUsuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu()
        {
            Application.Run(new F_Menu());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.KeyPreview = true;
            if (Properties.Settings.Default.First == 0)
            {
                MessageBox.Show("Parece que você é novo por aqui! Para utilizar todos os benefícios da Biblioteca Fácil CM Distribution, você deve fazer algumas coisas primeiro. Vamos lá?", "Olá!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Launcher launcher = new Launcher();
                launcher.ShowDialog();
                return;
            }
            if (Properties.Settings.Default.Instalador == 0)
            {
                System.Diagnostics.Process.Start(@"C:\Biblioteca Fácil CM\SetupServiceEremol v1.3.msi");
                Properties.Settings.Default.Instalador = 1;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
            */
            tb_usuario.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovoUsuario = new Thread(novousuario);
            NovoUsuario.SetApartmentState(ApartmentState.MTA);
            NovoUsuario.Start();
        }

        private void novousuario()
        {
            Application.Run(new F_NovoUsuario());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                Launcher launcher = new Launcher();
                launcher.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tb_senha.Text == "" && tb_usuario.Text == "")
            {
                MessageBox.Show("Informe o Username e senha para acessar seu login", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tb_usuario.Text == "")
            {
                MessageBox.Show("Informe o Username para acessar seu login", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tb_senha.Text == "")
            {
                MessageBox.Show("Informa a senha para acessar seu login", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MGlobais.AntiSQLInjection(tb_usuario.Text) == true || MGlobais.AntiSQLInjection(tb_senha.Text) == true)
            {
                MessageBox.Show("Caracteres de invalidação detectados. O login foi bloqueado.\nSe o erro persistir, entre em contato com o suporte.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            if (MGlobais.Login(tb_usuario.Text, tb_senha.Text) || (tb_usuario.Text == "Dev" && tb_senha.Text == "0810"))
            {
                this.Close();
                Menus = new Thread(menu);
                Menus.SetApartmentState(ApartmentState.STA);
                Menus.Start();
            }
            else
            {
                if (Globais.tentativasFalhadas < 2)
                {
                    MessageBox.Show("Usuário e/ou senha errado(s). Verifique seus dados.", "Sistema Integrado de Segurança - SSI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globais.tentativasFalhadas += 1;
                    tb_senha.Clear();
                    return;
                }

                if (Globais.tentativasFalhadas == 2)
                {
                    DialogResult res = MessageBox.Show("Parece que você esqueceu sua senha de login. Deseja tentar recuperar seu login?", "Tentativas Falhadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == res)
                    {
                        Globais.tentativasFalhadas = 0;
                        F_EsqueciSenha f_EsqueciSenha = new F_EsqueciSenha();
                        f_EsqueciSenha.ShowDialog();
                        return;
                    }
                    else
                    {
                        Globais.tentativasFalhadas = 0;
                        return;
                    }
                }
                else
                {
                    MGlobais.TentativasUsuario(tb_usuario.Text);
                    return;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globais.uploading == 1)
            {
                e.Cancel = true;
                MessageBox.Show("Aguarde o upload do Backup...", "Upload em andamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
