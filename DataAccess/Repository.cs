using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository
    {
        private string _connectionString;

        public Repository(string connectionString) 
        {
            _connectionString = connectionString;
        }

        public IEnumerable<T> GetItems<T>(string tableName, Func<IDataRecord, T> itemFactory, string order) 
        {
            var sql = string.Format("SELECT * FROM {0}", tableName);
            order = order.Trim();

            if (!string.IsNullOrEmpty(order))
                sql += (" ORDER BY " + order);

            using (var cn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        yield return itemFactory(rdr);
                    }
                    rdr.Close();
                }
            }
        }
    }
}
