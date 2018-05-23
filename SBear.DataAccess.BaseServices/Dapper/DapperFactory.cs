using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace SBear.DataAccess.BaseServices.Dapper
{
    public class DapperFactory
    {
        private readonly string _connectionString;
        private readonly string _databaseType;
        public DapperFactory(string dataBaseType, string connectionString)
        {
            _connectionString = connectionString;
            _databaseType = dataBaseType;
        }
        public IDbConnection CreateDbConnection()
        {
            IDbConnection connection = null;
            switch (_databaseType)
            {
                case "postgresql":
                    connection = new NpgsqlConnection(_connectionString);
                    break;
                case "mssql":
                    connection = new System.Data.SqlClient.SqlConnection(_connectionString);
                    break;
            }
            return connection;
        }
    }
}
