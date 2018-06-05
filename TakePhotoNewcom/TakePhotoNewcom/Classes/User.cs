using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakePhotoNewcom.Classes
{
    class User
    {
        string usuario = null;
        string pass = null;
        string bancoDados = null;
        string servidor = null;
        SqlConnection connection;

        public User(string serverName, string databaseName, string user = null, string password = null)
        {
            servidor = serverName;
            bancoDados = databaseName;
            usuario = user;
            pass = password;
        }

        private SqlConnection openConnectionWindowsAuthentication(string serverName, string databaseName)
        {
            string connetionString = string.Format("Server={0};Database={1};Trusted_Connection=True;", serverName, databaseName);
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SqlDataAdapter getAllUsersSqlDataAdapter(bool authenticationWindows = true)
        {
            try
            {
                SqlConnection sqlConnection = openConnectionWindowsAuthentication(servidor, bancoDados);

                if (sqlConnection != null)
                {
                    string sql = "SELECT id, n_identificador, nome, rg FROM pessoas";
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    closeConnection();
                    return sqlDataAdapter;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
