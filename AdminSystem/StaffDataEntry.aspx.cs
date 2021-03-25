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
        //create an instance of customers
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
        clsStaff AStaff = new clsStaff();
        //create string variables
        //string Id = txtId.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string DOB = txtDOB.Text;
        string Roles = txtRoles.Text;
        string Error = "";
        Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
        if (Error == "")
        {
            //AStaff.Id = Id;
            AStaff.Name = Name;
            AStaff.Roles = Roles;
            AStaff.DOB = Convert.ToDateTime(DOB);
            AStaff.Email = Email;
            AStaff.PhoneNumber = Convert.ToInt32(PhoneNumber);
            clsStaffCollection StaffList = new clsStaffCollection();

            if (Id == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }

            else
            {
                StaffList.ThisStaff.Find(Id);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }                 
        else
        {
                    lblError.Text = Error;
                }
            }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 Id;
        Boolean Found = false;
        Id = Convert.ToInt32(txtId.Text);
        Found = AStaff.Find(Id);
        if (Found == true)
        {
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
   





