using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string Name = txtCustomerName.Text;
        string DOB = txtCustomerDateOfBirth.Text;
        string Email = txtCustomerEmail.Text;
        string Password = txtCustomerPassword.Text;
        string BillingAddress = txtCustomerAddress.Text;
        string Error = "";

        Error = ACustomer.Valid(Name, DOB, Email, BillingAddress, Password);

        if( Error == "")
        {
            ACustomer.Name = Name;
            ACustomer.DateOfBirth = Convert.ToDateTime(DOB);
            ACustomer.Pass = Password;
            ACustomer.BillingAddress = BillingAddress;
            ACustomer.Email = Email;
            ACustomer.Active = chkActive.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 Id;
        Boolean Found = false;
        Id = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(Id);
        if (Found == true)
        {
            txtCustomerName.Text = ACustomer.Name;
            txtCustomerPassword.Text = ACustomer.Pass;
            txtCustomerEmail.Text = ACustomer.Email;
            txtCustomerAddress.Text = ACustomer.BillingAddress;
            txtCustomerDateOfBirth.Text = ACustomer.DateOfBirth.ToString();




        }
    }
}

