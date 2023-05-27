using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_ServidorEmail : Form
    {
        private static int a = 0;
        public F_ServidorEmail()
        {
            InitializeComponent();
        }
        private void Salvar()
        {
            Properties.Settings.Default.Email = tb_email.Text;
            Properties.Settings.Default.Host = tb_host.Text;
            Properties.Settings.Default.Porta = int.Parse(tb_porta.Text);
            Properties.Settings.Default.UserEmail = tb_username.Text;
            Properties.Settings.Default.SenhaEmail = tb_password.Text;
            Properties.Settings.Default.Save();

            if (tb_email.Text == "" || tb_host.Text == "" || tb_porta.Text == "0" || tb_username.Text == "" || tb_password.Text == "")
            {
                return;
            }
            else
            {
                //MGlobais.GerarCCS(tb_email.Text, tb_password.Text, int.Parse(tb_porta.Text), tb_host.Text, tb_username.Text);
                return;
            }
        }

        private void F_ServidorEmail_Load(object sender, EventArgs e)
        {
            tb_email.Text = Properties.Settings.Default.Email;
            tb_host.Text = Properties.Settings.Default.Host;
            tb_porta.Text = Properties.Settings.Default.Porta.ToString();
            tb_username.Text = Properties.Settings.Default.UserEmail;
            tb_password.Text = Properties.Settings.Default.SenhaEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
            a = 1;
            this.Close();
        }

        private void F_ServidorEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a == 0)
            {
                Salvar();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SystemSound son = SystemSounds.Exclamation;
            son.Play();
            DialogResult res = MessageBox.Show("Isto apagará as configurações atuais de rede. Deseja continuar?", "Servidor", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == res)
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Host = "";
                Properties.Settings.Default.Porta = 0;
                Properties.Settings.Default.UserEmail = "";
                Properties.Settings.Default.SenhaEmail = "";
                Properties.Settings.Default.Save();
                tb_email.Clear();
                tb_host.Clear();
                tb_porta.Text = "0";
                tb_username.Clear();
                tb_password.Clear();
                tb_email.Focus();
                if (File.Exists(@"C:\Biblioteca Fácil\Filas\#confi\conf.ccs"))
                {
                    File.Delete(@"C:\Biblioteca Fácil\Filas\#confi\conf.ccs");
                }
            }
        }
    }
}
