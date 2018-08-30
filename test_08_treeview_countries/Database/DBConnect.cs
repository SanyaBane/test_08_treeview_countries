using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries.Database
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private static readonly DBConnect instance = new DBConnect();
        static DBConnect() { }

        private DBConnect()
        {
            Initialize();
        }

        public static DBConnect Instance
        {
            get
            {
                return instance;
            }
        }

        private void Initialize()
        {
            server = "localhost";
            database = "test_08_treeview_countries";
            uid = "root";
            password = "1113";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                }

                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable Select(MySqlCommand cmd)
        {
            if (this.OpenConnection() == true)
            {
                cmd.Connection = connection;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.CloseConnection();

                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Backup()
        {
            throw new NotImplementedException();
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }


    }
}
