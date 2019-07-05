using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL
{
    public class DAL_ADO
    {
        //In Exam Name this Class as DAL only.

        private static String conString;
        private SqlConnection con;
        
        static DAL_ADO()
        {
            conString = ConfigurationManager.ConnectionStrings["development"].ConnectionString;
        }

        public String CreateCustomer(String name = "", String address = "", String age = "", String mobile = "", String gender = "")
        {
            con = new SqlConnection(conString);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("USP_CreateCustomer", con);
                SqlParameter USP_Param;
                SqlDataReader createCustomerReader;

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", name);
                cmd.Parameters.AddWithValue("@CustomerAddress", address);
                cmd.Parameters.AddWithValue("@CustomerAge", age);
                cmd.Parameters.AddWithValue("@CustomerMobile", mobile);
                cmd.Parameters.AddWithValue("@CustomerGender", gender);

                USP_Param = new SqlParameter();
                USP_Param.ParameterName = "@id";
                USP_Param.SqlDbType = System.Data.SqlDbType.Int;
                USP_Param.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(USP_Param);

                con.Open();
                createCustomerReader = cmd.ExecuteReader();
                return USP_Param.Value.ToString();
            }
        }

        public void UpdateCustomer(int id, String name = "", String address = "", String age = "", String mobile = "", String gender = "")
        {
            con = new SqlConnection(conString);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("USP_UpdateCustomer", con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", name);
                cmd.Parameters.AddWithValue("@CustomerAddress", address);
                cmd.Parameters.AddWithValue("@CustomerAge", age);
                cmd.Parameters.AddWithValue("@CustomerMobile", mobile);
                cmd.Parameters.AddWithValue("@CustomerGender", gender);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteReader();
            }
        }

        public DataTable GetCustomers()
        {
            DataTable dataTable;
            con = new SqlConnection(conString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter("USP__Get_CustomerAccount_Details", con);
            dataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //dataAdapter.SelectCommand.Parameters.AddWithValue("@id", 2);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable SearchCustomers(String accountType="", String customerName="", String customerAddress="")
        {
            DataTable dataTable;
            con = new SqlConnection(conString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter("USP_Search_Customer", con);

            dataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@account_type", accountType);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", customerName);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@address", customerAddress);

            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public String CreateAccount(int accountTypeID, float accountBalance, int customerID)
        {
            con = new SqlConnection(conString);
            using (con)
            {
                SqlParameter USP_Param;
                SqlDataReader uspReader;
                SqlCommand cmd = new SqlCommand("USP_CreateCustomer", con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountTypeId", accountTypeID);
                cmd.Parameters.AddWithValue("@AccountBalance", accountBalance);
                cmd.Parameters.AddWithValue("@CustomerId", customerID);
                
                USP_Param = new SqlParameter();
                USP_Param.ParameterName = "@id";
                USP_Param.SqlDbType = System.Data.SqlDbType.Int;
                USP_Param.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(USP_Param);

                con.Open();
                uspReader = cmd.ExecuteReader();
                return USP_Param.Value.ToString();
            }
        }

        public void InactivateAccount(float transactionAmount, int accountNo, int id)
        {
            con = new SqlConnection(conString);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("USP_InactivateAccount", con);
                
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);
                con.Open();
                cmd.ExecuteReader();

            }
        }

        public String DepositeAmount(float transactionAmount, int accountNo)
        {
            con = new SqlConnection(conString);
            using (con)
            {
                SqlParameter USP_Param;
                SqlDataReader uspReader;
                SqlCommand cmd = new SqlCommand("USP_DepositeAmount", con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TransactionAmount", transactionAmount);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);

                USP_Param = new SqlParameter();
                USP_Param.ParameterName = "@id";
                USP_Param.SqlDbType = System.Data.SqlDbType.Int;
                USP_Param.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(USP_Param);

                con.Open();
                uspReader = cmd.ExecuteReader();
                return USP_Param.Value.ToString();
            }
        }

        public String WithdrawAmount(float transactionAmount, int accountNo)
        {
            con = new SqlConnection(conString);
            using (con)
            {
                SqlParameter USP_Param;
                SqlDataReader uspReader;
                SqlCommand cmd = new SqlCommand("USP_WithdrawAmount", con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TransactionAmount", transactionAmount);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);

                USP_Param = new SqlParameter();
                USP_Param.ParameterName = "@id";
                USP_Param.SqlDbType = System.Data.SqlDbType.Int;
                USP_Param.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(USP_Param);

                con.Open();
                uspReader = cmd.ExecuteReader();
                return USP_Param.Value.ToString();
            }
        }




    }
}
