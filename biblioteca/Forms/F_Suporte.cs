using System;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Suporte : Form
    {
        public F_Suporte()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Suporte_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            string data = dt.ToShortDateString();

            lb_solicitante.Text = Global.CurrentUserFullname;
            lb_sistema.Text = String.Format(Environment.MachineName + "; " + Environment.OSVersion + "; " + Environment.Version);
            lb_data.Text = data;
            lb_versao.Text = Global.VERSION;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "" || tb_dados.Text == "")
            {
                MessageBox.Show("Informe corretamente todos os campos de texto");
                return;
            }

            if (tb_email.Text.Contains("@gmail.com") || tb_email.Text.Contains("@hotmail.com") || tb_email.Text.Contains("@outlook.com"))
            {
                try
                {
                    button1.Enabled = false;
                    button1.Cursor = Cursors.No;
                    Email.EnviarEmail(tb_dados.Text, "E-Mail de Suporte Técnico", tb_email.Text);
                    button1.Enabled = true;
                    button1.Cursor = Cursors.Default;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Não foi possível enviar sua notificação. Por favor, tente mais tarde e verifique sua conexão com a intenet.");
                    return;
                }
            }
            else
            {
                lb_aprovado.ForeColor = Color.Red;
                lb_aprovado.Text = "Informe um E-mail válido";
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            if (lb_aprovado.Text != "")
            {
                lb_aprovado.Text = "";
            }
        }
    }
}
