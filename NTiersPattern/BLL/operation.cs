using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NTiersPattern.DAL;

namespace NTiersPattern.BLL
{
   public class operation
   {
        public DataTable GetData()
        {
            try
            {
                DataDAL data = new DataDAL();
                return data.ReadData();
            }
            catch
            {
                throw;
            }

        }
        
      

   }
}
