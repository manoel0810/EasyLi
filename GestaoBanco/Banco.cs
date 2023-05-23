using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GestaoBanco
{
    public class Banco
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoEX;
        private static SQLiteConnection conexaoEX2;
        private static SQLiteConnection conexaoRss;
        public static int RetornoCon;

        public static SQLiteConnection ConexaoBancoEX(int BX)
        {
            string local = @"Data Source=" + Globais.ConexaoBX(BX);
            try
            {
                conexaoEX = new SQLiteConnection(local);
                conexaoEX.Open();
                
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conexaoEX;
        }

        public static SQLiteConnection ConexaoBancoEX2(int BX)
        {
            string local = @"Data Source=" + Globais.ConexaoBX(BX);
            try
            {
                MessageBox.Show(local);
                conexaoEX2 = new SQLiteConnection(local);
                conexaoEX2.Open();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conexaoEX2;
        }
        public static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection(@"Data Source=C:\Biblioteca Fácil\EREMOL.db");
            conexao.Open();
            return conexao;
        }
        private static SQLiteConnection ConexaoBancoRes()
        {
            conexaoRss = new SQLiteConnection("Data Source=" + Globais.caminhoSel);
            conexaoRss.Open();
            return conexaoRss;
        }
        public static DataTable ConsultasRss(string vquery)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBancoRes();
            var cmd = vcon.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            vcon.Close();
            return dt;

        }
        public static void AlterarDadosRss(string vquery)
        {
            SQLiteDataAdapter da = null;

            var vcon = ConexaoBancoRes();
            var cmd = vcon.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            cmd.ExecuteNonQuery();
            vcon.Close();
        }
        public static SQLiteConnection TesteConexao()
        {
            conexao = new SQLiteConnection(@"Data Source=C:\Biblioteca Fácil\EREMOL.db");
            conexao.Open();
            RetornoCon = 1;
            return conexao;
        }

        public static DataTable Consultas(string vquery) //Consultas no Banco de Dados
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = ConexaoBanco();
            var cmd = con.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static void Manipular(string vquery) //Manipular Dados do Banco de Dados
        {
            SQLiteDataAdapter da = null;

            var con = ConexaoBanco();
            var cmd = con.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void ManipularBX1(string vquery) //Manipular Dados do Banco de Dados
        {
            SQLiteDataAdapter da = null;

            var con = ConexaoBancoEX(1);
            var cmd = con.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void ManipularBX2(string vquery) //Manipular Dados do Banco de Dados
        {
            SQLiteDataAdapter da = null;

            var con = ConexaoBancoEX2(2);
            var cmd = con.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable ConsultasBX1(string vquery) //Consultas no Banco de Dados
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = ConexaoBancoEX(1);
            var cmd = con.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable ConsultasBX2(string vquery) //Consultas no Banco de Dados
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = ConexaoBancoEX2(2);
            var cmd = con.CreateCommand();

            cmd.CommandText = vquery;
            da = new SQLiteDataAdapter(cmd.CommandText, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
