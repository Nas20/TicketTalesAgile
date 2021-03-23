using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with the page level scope
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if( IsPostBack == false)
        {
            //if this is a new record
            if(CustomerId != -1)
            {
                //displays the current data for the record
                DisplayCustomers();
            }
        }
            
        
    }
    
    void DisplayCustomers()
    {
        //create an instance of customers
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerId);
        //display the data
        txtCustomerID.Text = Customer.ThisCustomer.Id.ToString();
        txtCustomerName.Text = Customer.ThisCustomer.Name;
        txtCustomerDateOfBirth.Text = Customer.ThisCustomer.DateOfBirth.ToString();
        txtCustomerPassword.Text = Customer.ThisCustomer.Pass;
        txtCustomerEmail.Text = Customer.ThisCustomer.Email;
        txtCustomerAddress.Text = Customer.ThisCustomer.BillingAddress;
        chkActive.Text = Customer.ThisCustomer.Active.ToString();
        
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //create a new instance of customer class
        clsCustomer ACustomer = new clsCustomer();
        //create string variables
        string Name = txtCustomerName.Text;
        string DOB = txtCustomerDateOfBirth.Text;
        string Email = txtCustomerEmail.Text;
        string Password = txtCustomerPassword.Text;
        string BillingAddress = txtCustomerAddress.Text;
        string Error = "";

        Error = ACustomer.Valid(Name, DOB, Email, BillingAddress, Password);

        if( Error == "")
        {
            //capture customer id
            ACustomer.Id = CustomerId;
            //capture customer name
            ACustomer.Name = Name;
            //capture customer date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DOB);
            //capture the customer password
            ACustomer.Pass = Password;
            //capture customer billing address
            ACustomer.BillingAddress = BillingAddress;
            //capture customer email
            ACustomer.Email = Email;
            //capture customer active
            ACustomer.Active = chkActive.Checked;
            //create a new instance of customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record ie. customerId = -1 then add the data
            if(CustomerId == -1)
            {
                //set the ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;
                //add the new record
            CustomerList.Add();

            }
            //otherwise its an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }

        else
        {
            //display error message
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store primary key
        Int32 Id;
        //variable to store result of the find operation
        Boolean Found = false;
        //get the primary key enetred by the user
        Id = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerName.Text = ACustomer.Name;
            txtCustomerPassword.Text = ACustomer.Pass;
            txtCustomerEmail.Text = ACustomer.Email;
            txtCustomerAddress.Text = ACustomer.BillingAddress;
            txtCustomerDateOfBirth.Text = ACustomer.DateOfBirth.ToString();




        }
    }
}

