using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EvidenciaZamestnancov
{
    internal class Database
    {
        private static string connString = "server=localhost;database=evidencia_zamestnancov;uid=root;pwd=;";

        public static MySqlConnection DbConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}
