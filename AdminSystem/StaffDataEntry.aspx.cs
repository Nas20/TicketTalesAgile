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

    protected void btnok_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        string Id = txtId.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string DOB = txtDOB.Text;
        string Roles =  txtRoles.Text;
        string Error = "";
        Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
        if (Error == "")
        {      
            AStaff.Name =Name;
            AStaff.Roles = Roles;
            AStaff.DOB = Convert.ToDateTime(DOB);
            AStaff.Email = Email;
            AStaff.PhoneNumber = Convert.ToInt32(PhoneNumber);
            Session["AStaff"] = AStaff;
            Response.Redirect("StaffViewer.aspx");
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
}