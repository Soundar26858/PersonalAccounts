using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PersonalAccounts.DataAccessLayer
{
    public class CategoryDAL
    {
        string ConnStr = string.Empty;
        public CategoryDAL(IConfiguration configuration)
        {
            ConnStr = configuration.GetConnectionString("sqlconnstring");
        }
    }
}
