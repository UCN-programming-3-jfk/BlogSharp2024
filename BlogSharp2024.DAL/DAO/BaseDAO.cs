using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp2024.DAL.DAO
{
    public abstract class BaseDAO 
    {
        private string _connectionString;

        public BaseDAO(string connectionString) => _connectionString = connectionString;

        protected IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
