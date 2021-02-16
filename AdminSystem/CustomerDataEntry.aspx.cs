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
        ACustomer.Id = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.Name = txtCustomerName.Text;
        ACustomer.Email = txtCustomerEmail.Text;
        ACustomer.BillingAddress = txtCustomerAddress.Text;
        ACustomer.Pass = txtCustomerPassword.Text;
        ACustomer.DateOfBirth = Convert.ToDateTime(txtCustomerDateOfBirth.Text);
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");

    }
}

