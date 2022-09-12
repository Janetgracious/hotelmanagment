using MySql.Data.MySqlClient; //import mysl connection class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    class Database
    {
        public MySqlConnection Conn;//connection to the database
        public MySqlCommand Command;//help create sql statement
        public MySqlDataReader Reader;//return data from the databaase

        public Database()
        {
            string source = "localhost";
            string port = "3306";
            string user = "root";
            string password = "";
            string ssl = "none";
            string database = "hotelmanagementsystem";
            //string connection = String.Format("datasource={0}; port={1}; user id={2}; password={3}; database={4}; SSL Mode={5}", source, port, user, password, database, ssl);
            string connection = $"datasource={source}; port={port}; user id={user}; password={password}; database={database}; SSL Mode={ssl}";
            //string connection = "datasource=" + source + ";port=" + port + "; user id =" + user + ";password=" + password + ";database="+database+";SSL Mode=" + ssl + "";
            Conn = new MySqlConnection(connection);
            //Command = Conn.CreateCommand();
        }
    }
}
