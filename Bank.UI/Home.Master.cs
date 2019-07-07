using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank.UI
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("~/WebFormContent2.aspx");      //1
            //Server.Transfer("~/WebFormContent2.aspx");        //2
            //Server.Execute("~/WebFormContent2.aspx");         //3
        }

        protected void ManageCustomersButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateCustomerForm.aspx");
        }

        protected void SearchCustomersButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SearchCustomer.aspx");
        }

        protected void ViewCustomersButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShowCustomers.aspx");
        }
    }
}