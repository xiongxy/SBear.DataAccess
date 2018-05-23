using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace SBear.DataAccess.BaseServices.Dapper
{
    public abstract class DapperContext
    {
        protected DapperContext()
        {

        }
        protected virtual string ConnName { get; set; }
        protected virtual string DataBaseType { get; set; }
        protected virtual string ConnectionString { get; set; }
        public virtual IDbConnection Connection()
        {
            var dapperFactory = new DapperFactory(DataBaseType, ConnectionString);
            return dapperFactory.CreateDbConnection();
        }
    }
}
