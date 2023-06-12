using biblioteca.Classes;
using System;
using System.Windows.Forms;

namespace biblioteca
{
    public class Global
    {
        //Constantes do sistema
        public const string DATABASE_NAME = "Base.db";
        public const string VERSION = "1.0 - EasyLi 2023";
        public const string SUPORTE_EMAIL = "td.techdevops@gmail.com";

        //Variáveis de acesso global
        public static string CurrentUsername = string.Empty;
        public static string CurrentUserFullname = string.Empty;
        public static string CurrentUserAccessToken = string.Empty;
        public static UserPrivilege CurrentUserPrivilege = UserPrivilege.Normal;
        public static EmailSender EmailControl;
        public static Logger Log = new Logger($"{Application.StartupPath}\\logs\\{MGlobais.GenerateRandomFileName()}");
        public static DatabaseUpdates DatabaseUpdateController = new DatabaseUpdates();
        public static GithubController.GitOperations GitController;

        [Flags]
        public enum UserPrivilege : int
        {
            Normal = 0,
            Superuser = 1,
            NotDefined = 3
        }

        public enum BookStatus : int
        {
            Emprestado = 1,
            Devolvido = 0,
            Perdido = 2,
            //Bloqueado = 3,
            ErrorStateReturn = -1
        }

        public enum UserState : int
        {
            Blocked = 1,
            Free = 0,
            NotDefined = -1
        }
    }
}
