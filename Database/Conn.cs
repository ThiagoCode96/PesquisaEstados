using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEstados.Database
{
    static class Conn
    {
        private const string server = "localhost";
        private const string database = "telephone";
        private const string user = "telefonia";
        private const string password = "12345telephone";
        static public string strConn = $"server={server};User id={user};" +
            $"database={database}; password={password}";
    }
}
