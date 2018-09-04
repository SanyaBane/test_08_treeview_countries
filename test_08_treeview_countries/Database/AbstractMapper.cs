using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_08_treeview_countries.Database
{
    public abstract class AbstractMapper<T> where T : new()
    {
        abstract protected void DoLoad(T obj, IDataReader reader);

        public int ExecuteNonQuery(MySqlCommand command)
        {
            using (var conn = new MySqlConnection(DB_Constants.ConnectionString))
            {
                command.Connection = conn;
                conn.Open();

                return command.ExecuteNonQuery();
            }
        }

        public MySqlDataReader ExecuteReader(MySqlCommand command)
        {
            var conn = new MySqlConnection(DB_Constants.ConnectionString);
            command.Connection = conn;
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public IList<T> abstractFindMany(MySqlCommand command)
        {
            IList results = new List<T>();
            IDataReader reader = null;

            try
            {
                reader = this.ExecuteReader(command);

                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        var item = new T();
                        DoLoad(item, reader);
                        results.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return (IList<T>)results;
        }

    }
}
