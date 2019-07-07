using Bank.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank.UI
{
    public partial class SearchCustomer : System.Web.UI.Page
    {
        BAL_Bank obj;
        DataTable datatable;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            String accType, name, address;
            
            obj = new BAL_Bank();

            accType = AccountTypeTextBox.Text.ToString().Trim();
            name = NameTextBox.Text.ToString().Trim();
            address = AddressTextBox.Text.ToString().Trim();

            try
            {
                datatable = obj.SearchCustomers(accType, name, address);

                CustomerGridView.DataSource = datatable;
                CustomerGridView.DataBind();
            }
            catch (Exception)
            {

                ErrorLabel.Text = "Somthing went wrong";
            }
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            AccountTypeTextBox.Text = "";
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
        }
    }
}