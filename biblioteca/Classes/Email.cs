namespace biblioteca
{
    public class Email
    {
        public static void EnviarEmail(string body, string subject, string email)
        {
            Global.EmailControl.SendEmail(email, subject, body);
        }
    }
}
