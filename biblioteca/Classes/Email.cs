namespace biblioteca
{
    public class Email
    {
        public static void EnviarEmail(string body, string subject, string email)
        {
            MGlobais.GerarACC(subject, body, email);
        }
    }
}
