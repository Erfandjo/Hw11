using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configuration
{
    public class Configuration
    {

        public static string ConnectionString { get; set; }


        static Configuration()
        {
            ConnectionString = "Data Source=LAPTOP-CDHPQSKA\\SQLEXPRESS;Initial Catalog=ShopDb;User ID=sa;Password=erfash3883;TrustServerCertificate=True;Encrypt=True";
            


        }
    }
}
