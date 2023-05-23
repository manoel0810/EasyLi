using System;


namespace biblioteca
{
    class Globais
    {
        public static string Serial = "AF2TR47B1A";
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomebanco = @"\Biblioteca DB.db";
        public static string caminhobanco = caminho + @"\BD\";
        public static string filtroe = "Emprestado";
        public static string filtrod = "Devolvido";
        public static string devol = "Devolvido";
        public static string perdido = "PERDIDO";
        public static string estado = "Ativo";
        public static string estadof = "Finalizado";
        public static string data = DateTime.Today.Year.ToString();
        public static string versao = "1.0 - CM DISTRIBUTION 2021.1";
        public static string bloqueado = "BLOQUEADO";
        public static string fileNameCreted = string.Empty;
        public static string user = string.Empty;
        public static string userLog = string.Empty;
        public static int uploading = 0;
        public static int id = 0;
        public static int priv = 0;
        public static int notificacao = 0;
        public static int controleSaida = 0;
        public static int tentativasFalhadas = 0;

        //Variáveis para os relatórios anuais
        public static int controle = 0;
        public static int valorProgress = 0;
        public static int avanProgress = 0;
        public static string dataRelatorio = string.Empty;

    }
}
