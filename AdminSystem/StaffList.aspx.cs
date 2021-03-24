using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }

    }


        void DisplayStaff()
        {
            clsStaffCollection Staff = new clsStaffCollection();
            lstStaffList.DataSource = Staff.StaffList;
            lstStaffList.DataValueField = "Id";
            lstStaffList.DataTextField = "Name";
            lstStaffList.DataBind();
        }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Id"] = -1;
        Response.Redirect("AStaff.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Id;
        if (lstStaffList.SelectedIndex != -1)
        {
            Id = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["Id"] = Id;
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            //lblError.Text = "Please select a record to delete from the list";

        }
    }

    
}