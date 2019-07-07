using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bank.BAL;

namespace Bank.UI
{
    public partial class CreateCustomerForm : System.Web.UI.Page
    {
        private static BAL_Bank obj;

        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new BAL_Bank();
        }

        protected void Reset()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            AgeTextBox.Text = "";
            MobileTextBox.Text = "";
            GenderDropDownList.SelectedIndex = 0;
            ResultLabel.Text = "";
        }

        protected void CreateSwitchButton_Click(object sender, EventArgs e)
        {
            Reset();
            TableTitleLabel.Text = "Customer Enrollment Form";
            IdLabel.Visible = false;
            IdTextBox.Visible = false;

            CreateCustomerButton.Visible = true;
            UpdateCustomerButton.Visible = false;
        }

        protected void UpdateSwitchButton_Click(object sender, EventArgs e)
        {
            Reset();
            TableTitleLabel.Text = "Customer Information Updation Form";
            IdLabel.Visible = true;
            IdTextBox.Visible = true;
             
            CreateCustomerButton.Visible = false;
            UpdateCustomerButton.Visible = true;
        }

        protected void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            String name, address, mobile, localResult, age, gender;
 
            name = NameTextBox.Text.ToString().Trim();
            address = AddressTextBox.Text.ToString().Trim();
            age = AgeTextBox.Text.ToString().Trim();
            mobile = MobileTextBox.Text.ToString().Trim();
            gender = GenderDropDownList.Text.ToString().Trim();

            if (gender != "-1")
            {
                try
                {

                    localResult = obj.CreateCustomer(name, address, age, mobile, gender);

                    ResultLabel.Text = "Customer created with Id: " + localResult;
                    ResetButton.Visible = true;
                }
                catch (Exception)
                {

                    ResultLabel.Text = "Something went wrong";
                }
            }

            else
            {
                ResultLabel.Text = "Please select gender &nbsp;";
            }
        }

        protected void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            String name, address, mobile, age, gender;
            int id;

            id = Convert.ToInt32(IdTextBox.Text.ToString().Trim());
            name = NameTextBox.Text.ToString().Trim();
            address = AddressTextBox.Text.ToString().Trim();
            age = AgeTextBox.Text.ToString().Trim();
            mobile = MobileTextBox.Text.ToString().Trim();
            gender = GenderDropDownList.Text.ToString().Trim();

            if (gender != "-1")
            {
                try
                {
                    obj.UpdateCustomer(id, name, address, age, mobile, gender);

                    ResultLabel.Text = "Customer information Updated &nbsp;";
                    ResetButton.Visible = true;
                }
                catch (Exception)
                {

                    ResultLabel.Text = "Something went wrong";
                }
            }

            else
            {
                ResultLabel.Text = "Please select gender &nbsp;";
            }
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
            ResetButton.Visible = false;
        }
   
    }
}