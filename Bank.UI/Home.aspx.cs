using Bank.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank.UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowCustomersButton_Click(object sender, EventArgs e)
        {
            BAL_Bank objBAL = new BAL_Bank();
            CustomersGridView.DataSource = objBAL.GetCustomers();
            CustomersGridView.DataBind();
        }
    }
}