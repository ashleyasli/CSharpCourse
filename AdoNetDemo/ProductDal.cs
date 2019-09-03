using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        { SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }        
    }        
}
