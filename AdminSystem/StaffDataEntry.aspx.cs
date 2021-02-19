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
        AStaff.Id = Convert.ToInt32(txtStaffId.Text);
        AStaff.PhoneNumber = Convert.ToInt32(txtStaffPhoneNumber.Text);
        AStaff.Name = txtStaffName.Text;
        AStaff.Email = txtStaffEmail.Text;
        AStaff.DOB = Convert.ToDateTime(txtStaffDateOfBirth.Text);
        AStaff.Roles =  txtStaffRoles.Text;
        Session["AStaff"] = AStaff;        
        Response.Redirect("StaffViewer.aspx");

    }
}