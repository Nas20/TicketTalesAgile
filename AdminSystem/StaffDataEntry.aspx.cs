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
    Int32 Id;

    protected void Page_Load(object sender, EventArgs e)
    {
        //getting staff id
        Id = Convert.ToInt32(Session["Id"]);
        if (IsPostBack == false)
        {
            //if this is a new record
            if (Id != -1)
            {
                //displays the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of staff
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        Staff.ThisStaff.Find(Id);
        //display the data
        txtDOB.Text = Staff.ThisStaff.DOB.ToString();
        txtEmail.Text = Staff.ThisStaff.Email;
        txtName.Text = Staff.ThisStaff.Name;
        txtPhoneNumber.Text = Staff.ThisStaff.PhoneNumber.ToString();
        txtRoles.Text = Staff.ThisStaff.Roles;
        txtId.Text = Staff.ThisStaff.Id.ToString();
        //chkGender.Text = AStaff.ThisStaff.Active.ToString();
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of staff
        clsStaff AStaff = new clsStaff();
        //create string variables
        string PhoneNumber = txtPhoneNumber.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string DOB = txtDOB.Text;
        string Roles = txtRoles.Text;
        string Error = "";
        Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
        if (Error == "")
        {      
            //Capture name
            AStaff.Name = Name;
            //Capture roles
            AStaff.Roles = Roles;
            //Capture date of birth
            AStaff.DOB = Convert.ToDateTime(DOB);
            //Capture email
            AStaff.Email = Email;
            //Capture phone number
            AStaff.PhoneNumber = Convert.ToInt32(PhoneNumber);
            //create a new instance of Staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record  Id for Staff = -1 then add the data
            if (Id == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise its an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(Id);
                //set the ThisCustomer property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }

            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }                 
        else
        {
            //display error message
            lblError.Text = Error;
                }
            }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff Class
        clsStaff AStaff = new clsStaff();
        //variable to store primary key
        Int32 Id;
        //variable to store result of the find operation
        Boolean Found = false;
        //get primary key enetred by the user
        Id = Convert.ToInt32(txtId.Text);
        //find the record 
        Found = AStaff.Find(Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDOB.Text = AStaff.DOB.ToString();
            txtEmail.Text = AStaff.Email;
            txtName.Text = AStaff.Name;
            txtPhoneNumber.Text = AStaff.PhoneNumber.ToString();
            txtRoles.Text = AStaff.Roles;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {


    }

   
}
   





