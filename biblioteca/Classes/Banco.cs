using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace biblioteca
{
    class DatabaseController
    {
        private static SQLiteConnection EasyLiConnection;

        private static SQLiteConnection OpenConnection()
        {
            EasyLiConnection = new SQLiteConnection($"Data Source={Application.StartupPath}\\{Global.DATABASE_NAME}");
            EasyLiConnection.Open();
            return EasyLiConnection;
        }

        public static DataTable DQL(string CommandLine)
        {
            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(CommandLine, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }


    [Obsolete]
    class Banco
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoDidaticos;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection($"Data Source={Application.StartupPath}\\Base.db");
            conexao.Open();
            return conexao;
        }

       
        public static void KillConections()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
 
        private static SQLiteConnection ConexaoBancoDidaticos() //FUNÇÃO DESABILITADA PARA O BIBLIOTECA FÁCIL CM DISTRIBUTION!!!!! --- CÓDIGO FONTO NÃO ALTERADO!!!!!!
        {
            conexaoDidaticos = new SQLiteConnection(@"Data Source=C:\Biblioteca Fácil\Didáticos\Didaticos.db");
            conexaoDidaticos.Open();
            return conexaoDidaticos;
        }

        public static DataTable DQL(string sql) //Data Query Languege
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static DataTable dqlDidaticos(string sql) //Data Query Languege
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBancoDidaticos();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static DataTable ObterTurmas(string vquery)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = vquery;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DML(string q) // Data Manipulation Languege
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_dadosaluno WHERE N_IDLIVROALUNO =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static DataTable ObterDadosEventos(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_eventos WHERE N_IDEVENTO =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static DataTable ObterDadosAgenda(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_agendamento WHERE N_IDEVENTO =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static DataTable ObterDadosTurma(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_turmas WHERE N_IDTURMA =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public static SQLiteConnection TryConnect(int db)
        {
            SQLiteConnection con = new SQLiteConnection();
            if (db == 1)
            {
                con = ConexaoBanco();
            }
            else
            {
                con = ConexaoBancoDidaticos();
            }

            return con;
        }
    }
}
