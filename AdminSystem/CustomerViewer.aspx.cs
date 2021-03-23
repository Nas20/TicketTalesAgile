using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clscustomer 
        clsCustomer ACustomer = new clsCustomer();
        //store the data in the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //allows fields to be edited
        Response.Write(ACustomer.Id);
        Response.Write(ACustomer.Name);
        Response.Write(ACustomer.Email);
        Response.Write(ACustomer.Pass);
        Response.Write(ACustomer.BillingAddress);
        Response.Write(ACustomer.DateOfBirth);

    }
}