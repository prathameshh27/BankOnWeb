using Bank.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BAL
{
    public class BAL_Bank
    {
        DAL_ADO objDAL;

        public DataTable GetCustomers()
        {
            objDAL = new DAL_ADO();

            return objDAL.GetCustomers();
        }

        public String CreateAccount(int accountTypeID, float accountBalance, int customerID)
        {
            objDAL = new DAL_ADO();

            return objDAL.CreateAccount(accountTypeID, accountBalance, customerID);
        }

        public String CreateCustomer(String name = "", String address = "", String age = "", String mobile = "", String gender = "")
        {
            objDAL = new DAL_ADO();

            return objDAL.CreateCustomer(name, address, age, mobile, gender);
        }

        public String DepositeAmount(float transactionAmount, int accountNo)
        {
            objDAL = new DAL_ADO();

            return objDAL.DepositeAmount(transactionAmount, accountNo);
        }

        public void InactivateAccount(float transactionAmount, int accountNo, int id)
        {
            objDAL = new DAL_ADO();

            objDAL.InactivateAccount(transactionAmount, accountNo, id);
        }

        public DataTable SearchCustomers(String accountType = "", String customerName = "", String customerAddress = "")
        {
            objDAL = new DAL_ADO();

            return objDAL.SearchCustomers(accountType, customerName, customerAddress);
        }

        public void UpdateCustomer(int id, String name = "", String address = "", String age = "", String mobile = "", String gender = "")
        {
            objDAL = new DAL_ADO();

            objDAL.UpdateCustomer(id, name, address, age, mobile, gender);
        }

        public String WithdrawAmount(float transactionAmount, int accountNo) 
        {
            objDAL = new DAL_ADO();

            return objDAL.WithdrawAmount(transactionAmount, accountNo);
        }

        public Boolean SignIn(String username, String password)
        {
            objDAL = new DAL_ADO();

            return objDAL.SignIn(username, password);
        }

    }
}
