using BackUp_DataBase.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp_DataBase
{
    class connect
    {
        // var de conn
        public MySqlConnection conn;

        //creation du constructeur avec les parametres de connection à la base de données 'mysql'
        public connect()
        {
            string host = Settings.Default.host;
            string database = Settings.Default.database;
            string username = Settings.Default.user;
            string password = Settings.Default.password;
            string port = Settings.Default.port;
            string connection_string = "server=" + host + "; port=" + port + "; user=" + username + "; password=" + password + "; database=" + database + "";

            conn = new MySqlConnection(connection_string);
        }
    }
}
