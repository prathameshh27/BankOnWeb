using Bank.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BAK
{
    public class BAL
    {
        public DataTable GetCustomers()
        {
            DAL_ADO objDAL = new DAL_ADO();

            return objDAL.GetCustomers();
        }
    }
}
