using System.Collections.Generic;

namespace biblioteca.Classes
{
    public class DatabaseUpdatesDictionary
    {
        protected const string PRIMARY_TABLE = "CREATE TABLE db_updates (    UPID        VARCHAR  PRIMARY KEY,    description VARCHAR,    inst_date   DATETIME);";

        protected Dictionary<string, string> GetUpdates()
        {
            Dictionary<string, string> RET = new Dictionary<string, string>();
            foreach (var i in Querys)
                RET.Add(i[0], i[1]);

            return RET;
        }

        private readonly List<string[]> Querys = new List<string[]>
        {
            /*
             * Aqui, irão todas as futuras atualizações no banco de dados
             */

            new string[]{ "0x0" , "drop table tb_matriculas" }
        };
    }
}
