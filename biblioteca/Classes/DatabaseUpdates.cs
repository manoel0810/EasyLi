using System;
using System.Collections.Generic;
using System.Data;

namespace biblioteca.Classes
{
    public class DatabaseUpdates : DatabaseUpdatesDictionary
    {
        private bool PrimaryOk = false;
        public bool AlreadyChecked { get; private set; }

        /// <summary>
        /// Cria uma nova instância para o tipo <b>DatabaseUpdates</b>
        /// </summary>

        public DatabaseUpdates()
        {
            AlreadyChecked = false;
            PrimaryOk = CheckPrimaryTable();
            Global.Log.Log("[DatabaseUpdates] object init > DatabaseUpdates");
        }

        /// <summary>
        /// Verifica se a tabela primária de controle de atualizações está presente no banco de dados
        /// </summary>
        /// <returns><b>true</b> se a tabela existir</returns>

        public bool CheckPrimaryTable()
        {
            try
            {
                DatabaseController.DataQueryLanguage("select * from db_updates");
                Global.Log.Log($"[DatabaseUpdates] method request CheckPrimaryTable() :: {true}");
                return true;
            }
            catch
            {
                Global.Log.Log($"[DatabaseUpdates] method request CheckPrimaryTable() :: {false}");
                return false;
            }
        }

        /// <summary>
        /// Obtém todas as atualizações registradas para atualização
        /// </summary>
        /// <returns></returns>

        public Dictionary<string, string> GetAllUpdates()
        {
            Global.Log.Log($"[DatabaseUpdates] method request GetAllUpdates()");
            return GetUpdates();
        }

        /// <summary>
        /// Obtém todas as atualizações registradas para atualização que estão presentes nos registros do banco de dados atual
        /// </summary>
        /// <returns></returns>

        private List<string> GetDatabaseInstalledUpdates()
        {
            Global.Log.Log($"[DatabaseUpdates] method request GetDatabaseInstalledUpdates()");
            DataTable UpdatesDatabase = DatabaseController.DataQueryLanguage("select UPID from db_updates");
            List<string> UpdatesOnDatabase = new List<string>();

            foreach (var row in UpdatesDatabase.Rows)
                UpdatesOnDatabase.Add(((DataRow)row).Field<string>("UPID"));

            return UpdatesOnDatabase;
        }

        /// <summary>
        /// Retorna um dicionário contendo a divergência de atualizações registradas e atualizações presentes no banco de dados. Dessa maneira, é filtrado todas as atualizações ausêntes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        public Dictionary<string, string> GetNotInstalledUpdates()
        {
            Global.Log.Log($"[DatabaseUpdates] method request GetNotInstalledUpdates()");

            if (!PrimaryOk)
            {
                Global.Log.Log($"[DatabaseUpdates] method request exception at GetNotInstalledUpdates() :: A tabela raiz não está instalada para esse banco de dados");
                try
                {
                    CreatePrimaryTable();
                    Global.Log.Log($"[DatabaseUpdates] method request exception at GetNotInstalledUpdates() :: A tabela raiz criada");
                }
                catch
                {
                    throw new DBError("A tabela raiz não está instalada para esse banco de dados $0");
                }
            }

            List<string> UpdatesOnDatabase = GetDatabaseInstalledUpdates();
            var RegisteredUpdates = GetUpdates();
            Dictionary<string, string> NotInstaled = new Dictionary<string, string>();

            foreach (var update in RegisteredUpdates)
            {
                bool Exists = false;
                foreach (var instaled in UpdatesOnDatabase)
                {
                    if (update.Key == instaled)
                    {
                        Exists = true;
                        break;
                    }
                }

                if (!Exists)
                    NotInstaled.Add(update.Key, update.Value);
            }

            return NotInstaled;
        }

        /// <summary>
        /// Instala todas as atualizações ausêntes no banco de dados atual
        /// </summary>
        /// <exception cref="Exception"></exception>

        public void InstallUpdates()
        {
            if (!PrimaryOk)
            {
                Global.Log.Log($"[DatabaseUpdates] method request exception at InstallUpdates() :: A tabela raiz não está instalada para esse banco de dados");
                try
                {
                    CreatePrimaryTable();
                    Global.Log.Log($"[DatabaseUpdates] method request exception at GetNotInstalledUpdates() :: A tabela raiz criada");
                }
                catch
                {
                    throw new DBError("A tabela raiz não está instalada para esse banco de dados $0");
                }
            }

            Global.Log.Log($"[DatabaseUpdates] method request InstallUpdates()");
            Dictionary<string, string> ToInstall = GetNotInstalledUpdates();
            Global.Log.Log($"[DatabaseUpdates] method request InstallUpdates() > count :: {ToInstall.Count}");

            foreach (var update in ToInstall)
            {
                Global.Log.Log($"[DatabaseUpdates] method request InstallUpdates() > installing :: $key? = {update.Key}");

                try
                {
                    DatabaseController.DataManipulationLanguage(update.Value);
                    Global.Log.Log($"[DatabaseUpdates] method request InstallUpdates() > installing :: $success? = {true}");
                }
                catch
                {
                    Global.Log.Log($"[DatabaseUpdates] method request InstallUpdates() > installing :: $success? = {false}");
                }

                string query = "INSERT INTO db_updates (UPID, description, inst_date) VALUES (@param1, NULL, @param2)";
                object[] values = new object[]
                {
                    update.Key,
                    MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString())
                };

                DatabaseController.InsertData(query, values);
            }
        }

        /// <summary>
        /// Verifica se o esquema atual do banco de dados está atualizado, baseando-se nos UPID registrados
        /// </summary>
        /// <returns><b>true</b> se o esquema estiver atualizado</returns>
        /// <exception cref="Exception"></exception>

        public bool IsUpdated()
        {
            if (!PrimaryOk)
            {
                Global.Log.Log($"[DatabaseUpdates] method request exception at IsUpdated() :: A tabela raiz não está instalada para esse banco de dados");
                try
                {
                    CreatePrimaryTable();
                    Global.Log.Log($"[DatabaseUpdates] method request exception at GetNotInstalledUpdates() :: A tabela raiz criada");
                }
                catch
                {
                    throw new DBError("A tabela raiz não está instalada para esse banco de dados $0");
                }
            }

            Dictionary<string, string> Updates = GetUpdates();
            List<string> UpdatesOnDatabase = GetDatabaseInstalledUpdates();

            foreach (var up in Updates)
                if (UpdatesOnDatabase.Contains(up.Key) == false)
                {
                    Global.Log.Log($"[DatabaseUpdates] method request IsUpdated() :: {false}");
                    return false;
                }

            Global.Log.Log($"[DatabaseUpdates] method request IsUpdated() :: {true}");
            AlreadyChecked = true;
            return true;
        }

        /// <summary>
        /// Cria a tabela primária no banco de dados atual
        /// </summary>

        public virtual void CreatePrimaryTable()
        {
            DatabaseController.DataQueryLanguage(PRIMARY_TABLE);
            PrimaryOk = true;
        }
    }

    public class DBError : Exception
    {
        public DBError(string message) : base(message)
        {
            string NunCode = message.Substring(message.IndexOf("$") + 0x1);
            Code = int.Parse(NunCode);
        }

        public int Code { get; set; }
    }
}
