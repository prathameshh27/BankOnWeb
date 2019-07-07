using Bank.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank.UI
{
    public partial class LoginPage : System.Web.UI.Page
    {
        BAL_Bank obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new BAL_Bank();
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            String username, password;
            bool isPresent;

            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;
            isPresent=obj.SignIn(username, password);
            if (isPresent)
            {
                Server.Execute("~/CreateCustomerForm.aspx");
            }

            else
                UsernameTextBox.Text = "false";
        }
    }
}