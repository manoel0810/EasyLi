using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_ServidorEmail : Form
    {

        public F_ServidorEmail()
        {
            InitializeComponent();
        }

        private void Salvar()
        {
            foreach (Control c in Controls)
                if (c is TextBox Box)
                    if (string.IsNullOrWhiteSpace(Box.Text))
                    {
                        MessageBox.Show("Informe todos os campos corretamente", "Configuração SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


            Properties.Settings.Default.Email = Email.Text;
            Properties.Settings.Default.Host = Host.Text;
            Properties.Settings.Default.Porta = int.Parse(Port.Text);
            Properties.Settings.Default.UserEmail = Username.Text;
            Properties.Settings.Default.SenhaEmail = Password.Text;
            Properties.Settings.Default.Save();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            Email.Text = Properties.Settings.Default.Email;
            Host.Text = Properties.Settings.Default.Host;
            Port.Text = Properties.Settings.Default.Porta.ToString();
            Username.Text = Properties.Settings.Default.UserEmail;
            Password.Text = Properties.Settings.Default.SenhaEmail;

            KeyPreview = true;
            Port.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };
        }

        private void SaveClick(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        private void ResetClick(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Isto apagará as configurações atuais de rede. Deseja continuar?", "Servidor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Host = "";
                Properties.Settings.Default.Porta = 0;
                Properties.Settings.Default.UserEmail = "";
                Properties.Settings.Default.SenhaEmail = "";
                Properties.Settings.Default.Save();

                foreach (Control c in Controls)
                    if (c is TextBox Box)
                        Box.Clear();

                Email.Focus();
            }
        }
    }
}
