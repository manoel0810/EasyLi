using System;

namespace biblioteca
{
    public class Email
    {
        public static void EnviarEmail(string body, string subject, string email)
        {
            Global.EmailControl.SendEmail(email, subject, body);
        }
    }

    public class EmailFormatProvider
    {
        public static string FormartString(EmailFormat Request, string[] Args)
        {
            if (Request == EmailFormat.InOutRequest)
                if (Args.Length < 4)
                    throw new ArgumentException("Número inválido de argumentos para criar uma cadeia de caracteres no formato EmailFormat.InOurRequest");
                else
                    return Format(InOutRequest, Args, 0x4);
            else if (Request == EmailFormat.BlockRequest)
                if (Args.Length < 1)
                    throw new ArgumentException("Número inválido de argumentos para criar uma cadeia de caracteres no formato EmailFormat.BlockRequest");
                else
                    return Format(BlockRequest, Args, 0x1);

            return null;
        }

        private static string Format(string Model, string[] Args, int ArgsCount)
        {
            string MeModel = Model;
            for (int i = 0; i < ArgsCount; i++)
                MeModel = MeModel.Replace($"@param{i + 1}", Args[i]);

            return MeModel;
        }


        [Flags]

        public enum EmailFormat : int
        {
            InOutRequest = 0,
            BlockRequest = 1
        }


        #region EmailFormats

        private static readonly string InOutRequest = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta charset='UTF-8'>\r\n    <title>@param1</title>\r\n    <style>\r\n        body {\r\n           background-color: white;\r\n            margin: 0;\r\n            padding: 0;\r\n        }\r\n        \r\n        .container-table {\r\n            width: 600px;\r\n            margin: 10px auto;\r\n            border-radius: 10px;\r\n            overflow: hidden;\r\n        }\r\n\r\n        .header-table {\r\n            background: rgba(173, 216, 230, 0.7);\r\n            padding: 15px;\r\n            text-align: left;\r\n        }\r\n\r\n        .assunto {\r\n            color: black;\r\n            font-size: 18px;\r\n            text-align: center;\r\n        }\r\n\r\n        .conteudo-table {\r\n            background: linear-gradient(-45deg, white, lightblue);\r\n        }\r\n\r\n        .conteudo {\r\n            display: flex;\r\n            align-items: center;\r\n            padding: 20px;\r\n        }\r\n\r\n        .conteudo img {\r\n            width: 100px;\r\n            height: 150px;\r\n            margin-right: 10px;\r\n            border-radius: 10px;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <table class='container-table'>\r\n        <tr>\r\n            <td class='header-table'>\r\n                <div class='assunto'>@param2</div>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class='conteudo-table'>\r\n                <div class='conteudo'>\r\n                    <img src='@param3' alt='Capa do livro'>\r\n                    <div class='mensagem'>@param4</div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
        private static readonly string BlockRequest = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta charset='UTF-8'>\r\n    <title>EasyLi</title>\r\n    <style>\r\n\r\n        body {\r\n            background-color: white;\r\n            margin: 0;\r\n            padding: 0;\r\n        }\r\n    \r\n        .container {\r\n            width: 600px;\r\n            margin: 20px auto;\r\n            padding: 20px;\r\n            border-radius: 10px;\r\n            background: linear-gradient(-45deg, lightgray, rgba(255, 0, 0, 0.4));\r\n        }\r\n\r\n        .mensagem {\r\n            font-size: 20px;\r\n            margin-bottom: 20px;\r\n            text-align: center;\r\n            color: black;\r\n        }\r\n\r\n        .msg{\r\n            font-size: 18px;\r\n            margin-bottom: 20px;\r\n            text-align: justify;\r\n            color: black;\r\n        }\r\n\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class='container'>\r\n        <div class='mensagem'>Atenção</div>\r\n        <div class='msg'>@param1</div>\r\n        \r\n    </div>\r\n</body>\r\n</html>";

        #endregion
    }
}
