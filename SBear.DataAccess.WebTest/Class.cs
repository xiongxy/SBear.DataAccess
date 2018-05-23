using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SBear.DataAccess.BaseServices;
using SBear.DataAccess.BaseServices.Dapper;

namespace SBear.DataAccess.WebTest
{
    public class Class : DapperContext
    {
        private IConfiguration _configuration;

        public Class(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetSection("Connections:ConfigDataBase").Get<DataBaseSetting>().ConnectionString;
            DataBaseType = _configuration.GetSection("Connections:ConfigDataBase").Get<DataBaseSetting>().DataBaseType;
        }
    }
}
