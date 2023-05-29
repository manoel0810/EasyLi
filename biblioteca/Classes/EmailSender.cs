using biblioteca;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading;

/// <summary>
/// Sub-rotina para envio de notificações do sistema
/// </summary>

public class EmailSender
{
    private readonly string smtpHost;
    private readonly int smtpPort;
    private readonly string smtpUsername;
    private readonly string smtpPassword;
    private readonly string smtpEmail;

    private readonly Queue<EmailData> emailQueue = new Queue<EmailData>();
    private object queueLock = new object();
    private bool isProcessingQueue = false;

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="host">Host para acesso do smtp</param>
    /// <param name="port">Porta de acesso ao host</param>
    /// <param name="username">Username do email smtp</param>
    /// <param name="password">Senha do smtp</param>
    /// <param name="email">Email do smtp</param>

    public EmailSender(string host, int port, string username, string password, string email)
    {
        smtpHost = host;
        smtpPort = port;
        smtpUsername = username;
        smtpPassword = password;
        smtpEmail = email;

        Global.Log.Log($"Starting EmailSender");
    }

    /// <summary>
    /// Empilha um email para envio
    /// </summary>
    /// <param name="toEmail">Destinatário</param>
    /// <param name="subject">Subject do email</param>
    /// <param name="body">Body do email</param>

    public void SendEmail(string toEmail, string subject, string body)
    {
        Global.Log.Log($"Email send request recived");

        lock (queueLock)
        {
            emailQueue.Enqueue(new EmailData(toEmail, subject, body));
            if (!isProcessingQueue)
            {
                isProcessingQueue = true;
                ThreadPool.QueueUserWorkItem(ProcessEmailQueue);
            }
        }
    }

    private void ProcessEmailQueue(object state)
    {
        while (true)
        {
            EmailData emailData;

            lock (queueLock)
            {
                if (emailQueue.Count > 0)
                {
                    emailData = emailQueue.Dequeue();
                }
                else
                {
                    isProcessingQueue = false;
                    return;
                }
            }

            try
            {
                using (SmtpClient client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(smtpEmail)
                    };

                    mail.To.Add(emailData.ToEmail);
                    mail.Subject = emailData.Subject;
                    mail.Body = emailData.Body;
                    mail.IsBodyHtml = true;

                    client.Send(mail);
                    Global.Log.Log($"Email request sent");
                }
            }
            catch (Exception ex)
            {
                Global.Log.Log($"Email request send error: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Representa um objeto do tipo Email
    /// </summary>

    private class EmailData
    {
        public string ToEmail { get; }
        public string Subject { get; }
        public string Body { get; }

        public EmailData(string toEmail, string subject, string body)
        {
            ToEmail = toEmail;
            Subject = subject;
            Body = body;
        }
    }
}
