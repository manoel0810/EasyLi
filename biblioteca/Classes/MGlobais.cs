using System;
using System.Data;
using System.IO;
using System.ServiceProcess;
using System.Text.RegularExpressions;

namespace biblioteca
{
    public class MGlobais
    {
        public static string ValidarString(string conteudo)
        {
            if (conteudo.Contains("\'"))
            {
                conteudo = conteudo.Replace("\'", "''");
            }
            return conteudo;
        }

        public static bool ValidateEmail(string Email)
        {
            string EmailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Match match = Regex.Match(Email, EmailPattern);
            return match.Success;
        }

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
                case Global.BookStatus.Bloqueado:
                    return "BLOQUEADO";
                default:
                    return "NONE";
            }
        }
        public static bool AntiSQLInjection(string variavel)
        {
            bool resposta = false;
            string cont = variavel.ToLowerInvariant();
            string[] combinacoes = new string[5];
            combinacoes[0] = ";";
            combinacoes[1] = "'";
            combinacoes[2] = ",";
            combinacoes[3] = " or ";
            combinacoes[4] = " and ";

            for (int i = 0; i < 5; i++)
            {
                if (cont.Contains(combinacoes[i]))
                {
                    resposta = true;
                }
            }

            return resposta;
        }

        public static void SincronizarRegistros()
        {
            DataTable IB = new DataTable();
            IB = Banco.DQL("select id from tb_H_Notificacao");
            if (IB.Rows.Count >= 0)
            {
                //OPERAÇÃO
                foreach (DataRow row in IB.Rows)
                {
                    DataTable update = new DataTable();
                    update = Banco.DQL("select T_STATUS, T_DATA from tb_dadosaluno where N_IDLIVROALUNO = '" + row.Field<Int64>("id") + "'");
                    if (update.Rows.Count != 0)
                    {
                        Banco.DML(String.Format("update tb_H_Notificacao set t_status = '{0}', dt_dataReg = '{1}' where id = '{2}'", update.Rows[0].Field<string>("T_STATUS"), MGlobais.FormatarDataSQL(update.Rows[0].Field<DateTime>("T_DATA").ToShortDateString()), row.Field<Int64>("id")));
                    }
                }
                Banco.DML("insert into tb_H_Notificacao (id, dt_dataReg, t_status) select A.N_IDLIVROALUNO, A.T_DATA, A.T_STATUS from tb_dadosaluno A where A.T_EMAIL != '' and A.T_STATUS = 'Emprestado'");
                Banco.DML("delete from tb_H_Notificacao where t_status != 'Emprestado'");
                return;
            }
            else
            {
                return;
            }
        }

        public static bool CheckSMTPConfiguration()
        {
            if (Properties.Settings.Default.Email == "" || Properties.Settings.Default.Host == "" || Properties.Settings.Default.Porta == 0 || Properties.Settings.Default.UserEmail == "" || Properties.Settings.Default.SenhaEmail == "")
                return false;
            else
                return true;
        }

        public static bool Internet()
        {
            bool falha;

            System.Uri url = new System.Uri("http://www.microsoft.com");

            System.Net.WebRequest WebR;
            System.Net.WebResponse WebRs;

            WebR = System.Net.WebRequest.Create(url);

            try
            {
                WebRs = WebR.GetResponse();
                WebRs.Close();
                WebR = null;
                falha = false;
            }
            catch
            {
                WebR = null;
                falha = true;
            }
            return falha;
        }

        public static void GerarACC(string subject, string body, string email)
        {
            Random id = new Random();
            int idd = id.Next(11111111, 99999999);
            string sufx = idd.ToString();
            StreamWriter gerar = new StreamWriter(@"C:\Biblioteca Fácil CM\Filas\ARC-" + sufx + ".acc");
            Globais.fileNameCreted = sufx + ".acc";

            //Criptografia;
            email = Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(email));
            email = Scripts.Binary_Hex.ConverToHex(email);

            subject = Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(subject));
            subject = Scripts.Binary_Hex.ConverToHex(subject);

            body = Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(body));
            body = Scripts.Binary_Hex.ConverToHex(body);

            gerar.WriteLine(email);
            gerar.WriteLine(subject);
            gerar.WriteLine("<smtp_body>");
            gerar.WriteLine(body);
            gerar.WriteLine("<smtp_body/>");
            gerar.Flush();
            gerar.Close();
        }
        public static void GerarCCS(string email, string senha, int porta, string smtp, string username)
        {
            StreamWriter escrever = new StreamWriter(@"C:\Biblioteca Fácil CM\Filas\#confi\conf.ccs");
            escrever.WriteLine(Scripts.Binary_Hex.ConverToHex(Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(email))));
            escrever.WriteLine(Scripts.Binary_Hex.ConverToHex(Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(senha))));
            escrever.WriteLine(Scripts.Binary_Hex.ConverToHex(Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(porta.ToString()))));
            escrever.WriteLine(Scripts.Binary_Hex.ConverToHex(Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(smtp))));
            escrever.WriteLine(Scripts.Binary_Hex.ConverToHex(Scripts.Binary_Hex.ConvertToBin(Cryptography.Encrypt.EncryptData(username))));
            escrever.Flush();
            escrever.Close();
        }
        public static bool VerificarServico(string nomeServiço)
        {
            bool valor = true;
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                if (service.ServiceName.ToString() == nomeServiço)
                {
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        valor = true;
                        break;
                    }
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        valor = false;
                        break;
                    }

                }
            }
            return valor;
        }

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

        public static int TipoSerial(string serial)
        {
            int rest = 0;
            string[] seriais = new string[2];
            seriais[0] = "AF2TR47B1A";
            seriais[1] = "GH65G4H541";

            if (serial == seriais[0])
            {
                rest = 0;
            }

            if (serial == seriais[1])
            {
                rest = 1;
            }

            if (serial != seriais[0] && serial != seriais[1])
            {
                rest = 3;
            }

            return rest;
        }

        public static bool ValidarUser(string user)
        {
            bool validacao;
            DataTable dt = new DataTable();
            dt = Banco.DQL("SELECT * FROM tb_login WHERE T_USER = '" + user + "'");
            int rows = dt.Rows.Count;

            if (rows > 0)
            {
                validacao = false;
            }
            else
            {
                validacao = true;
            }
            return validacao;
        }

        public static string FormatarData(string data)
        {
            //Formato YYYY-MM-DD Para DD-MM-YYYY
            string ano = data.Substring(0, 4);
            string mes = data.Substring(5, 2);
            string dia = data.Substring(8, 2);
            string dataFormatada = String.Format("{0}-{1}-{2}", dia, mes, ano);
            return dataFormatada;
        }
        public static string FormatarDataSQL(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }
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

        public static bool TryConnection(int db)
        {
            bool connected = false;
            if (ConnectionState.Open == Banco.TryConnect(db).State)
            {
                connected = true;
                Banco.KillConections();
            }
            return connected;
        }
        private static bool DependencesOn(string depedences)
        {
            bool depedencia = false;
            DataTable info = new DataTable();
            string[] codecs = depedences.Split(':');
            foreach (string stg in codecs)
            {
                info = Banco.DQL(String.Format("select * from tb_atualizacao where N_COD = '{0}'", stg));
                if (info.Rows.Count == 0)
                {
                    depedencia = true;
                }
            }
            return depedencia;
        }

        private static bool IFs(string content)
        {
            bool res;
            if (content.Contains("<end/>"))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }

        public static bool UseANSI(string cod)
        {
            string data = DateTime.Today.ToString();
            string valoratual = string.Empty;
            string codigo = string.Empty;
            string info = string.Empty;
            string query = string.Empty;
            bool resposta = true;
            int controle = 0;
            int fist = 0;
            int last = 0;
            int resu = 0;
            int no_cod = 0;

            StreamReader ler = new StreamReader(String.Format("C:\\Biblioteca Fácil CM\\Updates\\{0}.ANSI", cod));
            valoratual = ler.ReadLine();
            if (valoratual.Contains("<no_cod><no_cod/>"))
            {
                no_cod = 1;
            }
            while (controle == 0)
            {
                valoratual = ler.ReadLine();
                if (IFs(valoratual) == false)
                {
                    controle = 1;
                    ler.Close();
                    break;
                }
                else
                {
                    codigo = valoratual.Substring(0, 8);
                    DataTable dt = new DataTable();
                    if (no_cod == 0)
                    {
                        dt = Banco.DQL("SELECT * FROM tb_atualizacao WHERE N_COD = '" + codigo + "'");
                    }
                    if (dt.Rows.Count == 0)
                    {
                        if (no_cod == 0)
                        {
                            int n1 = valoratual.IndexOf("~") + 1, n2 = (valoratual.Length - n1) - 1;
                            string dep = valoratual.Substring(n1, n2);
                            bool ret = DependencesOn(dep);
                            if (ret == true)
                            {
                                //Codigo aqui
                                goto FIMWHILE;
                            }
                        }

                        fist = valoratual.IndexOf("|") + 1;
                        last = valoratual.LastIndexOf("|");
                        resu = last - 10;
                        info = valoratual.Substring(fist, resu);
                        fist = valoratual.IndexOf("§") + 2;
                        resu = (valoratual.Length - fist) - 2;
                        query = valoratual.Substring(fist, resu);

                        try
                        {
                            try
                            {
                                Banco.DML(query);
                                Banco.DML("INSERT INTO tb_atualizacao (N_COD, T_INFO, T_DATA) VALUES ('" + codigo + "', '" + info + "', '" + data + "')");

                            }
                            catch (Exception)
                            {
                                controle = 1;
                                resposta = false;
                                goto FIMWHILE;
                            }
                        }
                        catch (Exception)
                        {
                            controle = 1;
                            resposta = false;
                            goto FIMWHILE;
                        }

                    }
                    no_cod = 0;
                }
            FIMWHILE:;
            }
            return resposta;
        }
    }
}
