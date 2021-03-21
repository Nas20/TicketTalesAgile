using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    //var to store primary key value of the record to be deleted
    Int32 CustomerId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of addresses to be deleted from the session object

        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to delete
        Customers.ThisCustomer.Find(CustomerId);
        //delete the record
        Customers.Delete();
        //redirect to the main page
        Response.Redirect("CustomerList.aspx");

    }
}