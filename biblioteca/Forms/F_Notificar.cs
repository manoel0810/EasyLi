using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Notificar : Form
    {
        public F_Notificar()
        {
            InitializeComponent();
        }

        private void btn_notificar_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Today;
            DateTime dataS15 = hoje.AddDays(-15);

            string filtro = "";
            string vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_EMAIL AS 'Email' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' AND T_EMAIL !='" + filtro + "' AND T_DATA < '" + MGlobais.FormatarDataSQL(dataS15.ToShortDateString()) + "'";
            DataTable dt = new DataTable();
            dt = Banco.DQL(vquery);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Não existem registros com E-mail para notificar.", "Notificar Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pgb_notificando.Maximum = dt.Rows.Count;
            lb_Tregistros.Text = dt.Rows.Count.ToString();
            lb_Tregistros.Refresh();
            btn_notificar.Enabled = false;
            btn_notificar.Cursor = Cursors.No;
            int a = 0;

            //Enviar E-mail via C#
            SmtpClient client = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //Definir as confiçurações do cliente
            client.Host = Properties.Settings.Default.Host;
            client.Port = Properties.Settings.Default.Porta;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            //Definir as credenciais
            credenciais.UserName = Properties.Settings.Default.UserEmail;
            credenciais.Password = Properties.Settings.Default.SenhaEmail;

            //Definir as credenciais no cliente
            client.Credentials = credenciais;

            MailMessage message = new MailMessage();
            message.From = new MailAddress(Properties.Settings.Default.Email);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    pgb_notificando.Value = a++;
                    pgb_notificando.Refresh();
                    lb_Rnotificado.Text = i.ToString();
                    lb_Rnotificado.Refresh();
                    lb_nome.Text = dt.Rows[i].Field<string>("Aluno");
                    lb_nome.Refresh();

                    //Preparar mensagem - enviar
                    message.Subject = "Advertência de Livro - Biblioteca Fácil";
                    message.Body = String.Format("Olá {0}, consta no nosso Banco de Dados, que você está com o livro ({1}) que foi pego na data ({2}).\n\nSolicitamos a sua presença na biblioteca da escola EREM Oliveira Lima para a devolução do mesmo.\n\nCaso já tenha devolvido e retorne a ver este E-mail, entre em contato com a gestão da biblioteca.\n\nCaso esteja recebendo este E-mail antes dos 8(oito) dias úteis, desconsidere.\nEmitido por: {3}\n\nGestão Erem Oliveira Lima", dt.Rows[i].Field<string>("Aluno"), dt.Rows[i].Field<string>("Livro"), dt.Rows[i].Field<DateTime>("Data").ToShortDateString(), Globais.user);
                    message.To.Add(dt.Rows[i].Field<string>("Email"));

                    //Enviu da messagem
                    client.Send(message);
                    message.To.Clear();
                    Thread.Sleep(200);
                }
                catch
                {
                    MessageBox.Show("Houve um erro ao notificar as pendências. Verifique sua conexão com a internet.");
                    this.Close();
                    return;
                }
            }
            lb_Rnotificado.Text = dt.Rows.Count.ToString();
            pgb_notificando.PerformStep();
            btn_notificar.Enabled = true;
            btn_notificar.Cursor = Cursors.Hand;
            MessageBox.Show("A notificação terminou.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
