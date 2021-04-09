using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStaff : System.Web.UI.Page
{
    //Var stores the primary key value of the record to be delete
    Int32 Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of addresses to be deleted from the session object
        Id = Convert.ToInt32(Session["Id"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff
        clsStaffCollection Staff = new clsStaffCollection();
        //Find a record to delete
        Staff.ThisStaff.Find(Id);
        //Delete the record from staff
        Staff.Delete();
        //Redirect to the main page
        Response.Redirect("StaffList.aspx");
    }
}