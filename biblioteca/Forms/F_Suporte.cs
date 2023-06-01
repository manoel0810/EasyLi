using System;
using System.Diagnostics;
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

        private void VoltarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            string data = dt.ToShortDateString();

            Solicitante.Text = Global.CurrentUserFullname;
            Sistema.Text = String.Format(Environment.MachineName + "; " + Environment.OSVersion + "; " + Environment.Version);
            Data.Text = data;
            Versao.Text = Global.VERSION;
        }

        private void EnviarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Problema.Text))
            {
                MessageBox.Show("Informe corretamente todos os campos de texto", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MGlobais.ValidateEmail(Email.Text))
            {
                try
                {
                    bool SMTPConfiguration = MGlobais.CheckSMTPConfiguration();
                    bool InternetConnection = MGlobais.Internet();

                    if (SMTPConfiguration && InternetConnection)
                    {
                        biblioteca.Email.EnviarEmail(MountProblemString(), "E-Mail de Suporte Técnico", Global.SUPORTE_EMAIL);
                        MessageBox.Show("Obrigado pelo contato com o nosso suporte", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else if (!SMTPConfiguration && InternetConnection)
                    {
                        DialogResult RES = MessageBox.Show("Você não possui configurações de SMTP. Deseja enviar o email usando aplicativo proprietário do sistema operacional?", "Suporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == RES)
                        {
                            SendSupportEmail(Global.SUPORTE_EMAIL, "Suporte téctino - EasyLi", $"{MountProblemString()}");
                            MessageBox.Show("Obrigado pelo contato com o nosso suporte", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }

                    }
                    else
                        MessageBox.Show("Não foi possível concluir a ação", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Não foi possível enviar sua notificação. Por favor, tente mais tarde e verifique sua conexão com a intenet.", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                lb_aprovado.ForeColor = Color.Red;
                lb_aprovado.Text = "Informe um E-mail válido";
            }
        }

        public void SendSupportEmail(string emailAddress, string subject, string body)
        {
            Process.Start("mailto:" + emailAddress + "?subject=" + subject + "&body="
                         + body);
        }

        string MountProblemString()
        {
            string osInfo = $"OS VERSION: {Environment.OSVersion}";
            string programInfo = $"PROGRAM_VERSION: {Global.VERSION}";
            string versionInfo = $"VERSION: {Environment.Version}";
            string is64Bit = $"x64: {Environment.Is64BitOperatingSystem}";
            string problemMessage = $"Problem message: {Problema.Text}";
            string returnEmail = $"Email para retorno de informação: {Email.Text}";
            string fullName = $"Name: {Global.CurrentUserFullname}";

            return $"{programInfo};\r\n{osInfo};\r\n{versionInfo};\r\n{is64Bit};\r\n{problemMessage};\r\n{returnEmail};\r\n{fullName}";
        }

        private void EmailTextChenged(object sender, EventArgs e)
        {
            if (lb_aprovado.Text != "")
                lb_aprovado.Text = "";
        }
    }
}
