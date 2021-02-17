using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Response.Write(AStaff.Id);
        Response.Write(AStaff.Name);
        Response.Write(AStaff.DOB);
        Response.Write(AStaff.PhoneNumber);
        Response.Write(AStaff.Roles);
        Response.Write(AStaff.Email);
    }
}