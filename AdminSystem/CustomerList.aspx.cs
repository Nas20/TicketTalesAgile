using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "Id";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");


        }

        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerId;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in a session object
            Session["CustomerId"] = CustomerId;
            //redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");

        }
        else //if no record is selected
        {
            //display an error
            lblError.Text = "Please select a record to delete";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName(txtEnterName.Text);
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "Id";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtEnterName.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "Id";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();

    }
}
