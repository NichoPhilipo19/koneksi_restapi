using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace koneksi_restapi.models
{
    public class UsersContext
    {
        public string ConnectionString { get; set; }

        public UsersContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> list = new List<UserModel>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModel()
                        {
                            recid = reader.GetInt32("recid"),
                            fullname = reader.GetString("fullname"),
                            email = reader.GetString("email"),
                            username = reader.GetString("username"),
                            password = reader.GetString("password"),

                            isActive = reader.GetInt32("isActive"),
                            isBanned = reader.GetInt32("isBanned"),

                        });
                    }
                }
            }
            return list;
        }

        public List<UserModel> GetUsers(string recid)
        {
            List<UserModel> list = new List<UserModel>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE recid = @recid", conn);
                cmd.Parameters.AddWithValue("@recid", recid);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModel()
                        {
                            recid = reader.GetInt32("recid"),
                            isActive = reader.GetInt32("isActive"),
                            isBanned = reader.GetInt32("isBanned"),
                            fullname = reader.GetString("fullname"),
                            email = reader.GetString("email"),
                            username = reader.GetString("username"),
                            password = reader.GetString("password"),
                        });
                    }
                }
            }
            return list;
        }
    }
}
