using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NTiersPattern.DAL
{
    public class DbConnection
    {
       public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H7EKMAJ\HADEEL;Initial Catalog=task1;Integrated Security=True");

    }
}
