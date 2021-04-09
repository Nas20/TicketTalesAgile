using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }

    }

        void DisplayStaff()
        {
            //create an instance of the staff collection class
            clsStaffCollection Staff = new clsStaffCollection();
            //set the data source to the list of staff in the collection
            lstStaffList.DataSource = Staff.StaffList;
            //set the name of the primary key
            lstStaffList.DataValueField = "Id";
            //set the data field to display
            lstStaffList.DataTextField = "Name";
            //bind the data to the list
            lstStaffList.DataBind();
        }


    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");
    }


    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 Id;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Id = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["Id"] = Id;
            //redirect to the data entry page for staff
            Response.Redirect("AStaff.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblErrors.Text = "Please select a record to delete from the list";

        }
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 Id;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Id = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in a session object
            Session["Id"] = Id;
            //redirect to the delete page
            Response.Redirect("AStaff.aspx");
        }
        //if no record is selected
        else
        {
            //display an error
            lblErrors.Text = "Please select a record to delete from the list";

        }
    }


    //event handler for the apply button
    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection class
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Id";
        //set the data field to display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }


    //event handler for the clear button
    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection class
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffId("");
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Id";
        //set the data field to display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}