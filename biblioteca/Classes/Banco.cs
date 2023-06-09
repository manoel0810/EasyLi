using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace biblioteca
{
    class DatabaseController
    {
        private static SQLiteConnection EasyLiConnection = null;

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

        public static void DML(string CommandLine)
        {
            try
            {
                var vcon = OpenConnection();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = CommandLine;
                _ = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InsertData(string query, params object[] values)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, OpenConnection()))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    string parameterName = $"@param{i + 1}";
                    command.Parameters.AddWithValue(parameterName, values[i]);
                }

                command.ExecuteNonQuery();
            }
        }

        public static void KillConnection()
        {
            EasyLiConnection?.Dispose();
            EasyLiConnection = new SQLiteConnection();
        }
    }
}
