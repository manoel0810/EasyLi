using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace biblioteca
{
    public class MGlobais
    {
        /// <summary>
        /// Verifica se uma cadeia de entrada possui ocorrência de aspas simples. Caso haja, substitui todos os casos por aspas duplas
        /// </summary>
        /// <param name="String">Cadeia de caracteres para validação</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>

        public static string SanitizeString(string @String)
        {
            if (string.IsNullOrEmpty(@String))
                throw new ArgumentException("O argumento de entrada era null", "@String");

            return @String.Replace("'", "''");
        }

        /// <summary>
        /// Verifica se um endereço de email está em um formato válido
        /// </summary>
        /// <param name="Email">Email para validação</param>
        /// <returns><b>true</b> se o email for válido</returns>

        public static bool ValidateEmail(string Email)
        {
            string EmailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Match match = Regex.Match(Email, EmailPattern);
            return match.Success;
        }

        /// <summary>
        /// Gera um código randômico para uso de identificação de usuários
        /// </summary>
        /// <returns>Código de 8 dígitos</returns>

        public static string GenerateStudentCode()
        {
        StartFunctionCall:;
            Random R = new Random();
            string CODE = R.Next(10000000, 99999999).ToString();

            int Count = DatabaseController.DQL($"select * from students where code = '{CODE}' limit 1").Rows.Count;
            if (Count > 0)
                goto StartFunctionCall;
            else
                return CODE;
        }

        /// <summary>
        /// Retorna uma string com a descrição do enum passado
        /// </summary>
        /// <param name="StatusCode">Bandeira enum para descrição</param>
        /// <returns></returns>

        public static string GetDescription(Global.BookStatus StatusCode)
        {
            switch (StatusCode)
            {
                case Global.BookStatus.Devolvido:
                    return "DEVOLVIDO";
                case Global.BookStatus.Emprestado:
                    return "EMPRESTADO";
                case Global.BookStatus.Perdido:
                    return "PERDIDO";
                //case Global.BookStatus.Bloqueado:
                //return "BLOQUEADO";
                default:
                    return "NONE";
            }
        }

        /// <summary>
        /// Retorna um <i>Global.BookStatus</i> associado à um identificador string
        /// </summary>
        /// <param name="Name">Identificador string</param>
        /// <returns></returns>

        public static Global.BookStatus GetDescription(string Name)
        {
            switch (Name.ToUpper())
            {
                case "DEVOLVIDO":
                    return Global.BookStatus.Devolvido;
                case "EMPRESTADO":
                    return Global.BookStatus.Emprestado;
                case "PERDIDO":
                    return Global.BookStatus.Perdido;
                //case "BLOQUEADO":
                //return Global.BookStatus.Bloqueado;
                default:
                    return Global.BookStatus.ErrorStateReturn;
            }
        }

        /// <summary>
        /// Retorna uma string com a descrição do enum passado
        /// </summary>
        /// <param name="State">Bandeira enum para descrição</param>
        /// <returns></returns>

        public static string GetDescription(Global.UserState State)
        {
            switch (State)
            {
                case Global.UserState.Free:
                    return "Livre";
                case Global.UserState.Blocked:
                    return "Bloqueado";
                default:
                    return "null";
            }
        }

        /// <summary>
        /// Verifica a ocorrência de sequências de SQL Injection
        /// </summary>
        /// <param name="Parametro">Parâmetro que será validado</param>
        /// <returns></returns>

        public static bool AntiSQLInjection(string Parametro)
        {
            List<string> combinacoes = new List<string>
            {
                ";",
                "'",
                ",",
                " or ",
                " and ",
                "select ",
                "insert ",
                "update ",
                "delete ",
                "from ",
                "where ",
                "truncate ",
                "drop ",
                "alter ",
                "create "
            };

            string cont = Parametro.ToLower();
            foreach (string combinacao in combinacoes)
                if (cont.IndexOf(combinacao, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;

            return false;
        }

        /// <summary>
        /// Efetua a sincronização de registro para notificação autônoma
        /// </summary>

        public static void SincronizarRegistros()
        {
            DataTable IB = DatabaseController.DQL("select id from tb_H_Notificacao");
            if (IB.Rows.Count >= 0)
            {
                //OPERAÇÃO
                foreach (DataRow row in IB.Rows)
                {
                    DataTable update = new DataTable();
                    update = DatabaseController.DQL("select T_STATUS, T_DATA from tb_dadosaluno where N_IDLIVROALUNO = '" + row.Field<Int64>("id") + "'");
                    if (update.Rows.Count != 0)
                        DatabaseController.DML(String.Format("update tb_H_Notificacao set t_status = '{0}', dt_dataReg = '{1}' where id = '{2}'", update.Rows[0].Field<string>("T_STATUS"), MGlobais.FormatarDataSQL(update.Rows[0].Field<DateTime>("T_DATA").ToShortDateString()), row.Field<Int64>("id")));
                }

                DatabaseController.DML("insert into tb_H_Notificacao (id, dt_dataReg, t_status) select A.N_IDLIVROALUNO, A.T_DATA, A.T_STATUS from tb_dadosaluno A where A.T_EMAIL != '' and A.T_STATUS = 'Emprestado'");
                DatabaseController.DML("delete from tb_H_Notificacao where t_status != 'Emprestado'");
                return;
            }
            else
                return;
        }

        /// <summary>
        /// Verifica se as configurações do serviço SMTP estão todas preenchidas
        /// </summary>
        /// <returns><b>true</b> se as configurações estão definidas</returns>

        public static bool CheckSMTPConfiguration()
        {
            return !string.IsNullOrEmpty(Properties.Settings.Default.Email) &&
                   !string.IsNullOrEmpty(Properties.Settings.Default.Host) &&
                   Properties.Settings.Default.Porta > 0 &&
                   !string.IsNullOrEmpty(Properties.Settings.Default.UserEmail) &&
                   !string.IsNullOrEmpty(Properties.Settings.Default.SenhaEmail);
        }


        /// <summary>
        /// Verifica a conexão com a internet
        /// </summary>
        /// <param name="timeout">Tempo em milissegundos de aguardo por resposta</param>
        /// <returns>retorna true se houver conexão</returns>

        public static bool Internet(int timeout = 3000)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send("www.google.com", timeout);
                return (reply.Status == IPStatus.Success);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se a senha e usuário existem e efetua o login no sistema
        /// </summary>
        /// <param name="Username">Username de login do usuário</param>
        /// <param name="Password">Senha de acesso do usuário</param>
        /// <returns></returns>

        public static bool Login(string Username, string Password)
        {
            var Data = DatabaseController.DQL($"SELECT * FROM tb_login WHERE T_USER = '{Username}' AND T_SENHA = '{Password}'");
            if (Data.Rows.Count == 1)
            {
                Global.CurrentUserFullname = Data.Rows[0].Field<string>("T_NOMECOMPLETO");
                Global.CurrentUsername = Data.Rows[0].Field<string>("T_USER");
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Verifica se o serial passado é válido. Caso sim, retorna seu tipo
        /// </summary>
        /// <param name="serial">Serial que será verificado</param>
        /// <returns>Um inteiro de 8 bits que define o tipo do serial</returns>

        public static int TipoSerial(string serial)
        {
            byte[] frase = Encoding.UTF8.GetBytes(serial);
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            string SHA256 = BytesToString(sha256.ComputeHash(frase)).ToLower();

            switch (SHA256)
            {
                case "2830ba23f77d4d6f159dc05834da509515f3356e3374e7b9f3108c44c0ce7453":
                    return 0x0;
                case "c821851a0ee96298136b27a0730eb1399a83c27b8c512b0fe8b4af2559ac80af":
                    return 0x1;
                default:
                    return 0x3;
            }
        }

        /// <summary>
        /// Converte um array de bytes codificados para uma sequência de caracteres string
        /// </summary>
        /// <param name="Bytes">Array com os bytes codificados</param>
        /// <returns>Uma string com a correspondência do byte array</returns>

        public static string BytesToString(byte[] Bytes)
        {
            string Partial = "";
            foreach (byte b in Bytes)
                Partial += b.ToString("X2");

            return Partial;
        }

        /// <summary>
        /// Verifica se um username já existe no sistema
        /// </summary>
        /// <param name="Username">Username para teste</param>
        /// <returns><b>false</b> se o username ainda não está em uso</returns>

        public static bool ValidarUser(string Username)
        {
            DataTable dt = DatabaseController.DQL($"SELECT * FROM tb_login WHERE T_USER = '{Username}'");
            return !(dt.Rows.Count > 0);
        }

        /// <summary>
        /// Formata uma data no padrão YYYY-MM-DD para DD-MM-YYYY
        /// </summary>
        /// <param name="data">Data para formatação</param>
        /// <returns></returns>

        public static string FormatarData(string data)
        {
            //Formato YYYY-MM-DD Para DD-MM-YYYY
            string ano = data.Substring(0, 4);
            string mes = data.Substring(5, 2);
            string dia = data.Substring(8, 2);
            string dataFormatada = String.Format("{0}-{1}-{2}", dia, mes, ano);
            return dataFormatada;
        }

        /// <summary>
        /// Formata uma data no padrão DD-MM-YYYY para YYYY-MM-DD
        /// </summary>
        /// <param name="data">Data para formatação</param>
        /// <returns></returns>

        public static string FormatarDataSQL(string data)
        {
            if (string.IsNullOrEmpty(data))
                return data;
            else
            {
                //Formato DD-MM-YYYY Para YYYY-MM-DD
                string dia = data.Substring(0, 2);
                string mes = data.Substring(3, 2);
                string ano = data.Substring(6, 4);
                string dataFormatada = String.Format("{0}-{1}-{2}", ano, mes, dia);
                return dataFormatada;
            }
        }
    }
}
