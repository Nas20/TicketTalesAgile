using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }
    void DisplayStocks()
    {
        //create an instance of the collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to the list of orders in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the data field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StockId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockId"] = StockId;
            //redirect to the data entry page
            Response.Redirect("StockDataEntry.aspx");


        }

        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in a session object
            Session["StockId"] = StockId;
            //redirect to the delete page
            Response.Redirect("DeleteStock.aspx");

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
        clsStockCollection AllStock = new clsStockCollection();
            AllStock.ReportByItemName(txtEnterName.Text);
            //set the data source to the list of customers in the collection
            lstStockList.DataSource = AllStock.StockList;
            //set the name of the primary key
            lstStockList.DataValueField = "Id";
            //set the data field to display
            lstStockList.DataTextField = "Name";
            //bind the data to the list
            lstStockList.DataBind();


        }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsStockCollection AllStock = new clsStockCollection();
        AllStock.ReportByItemName("");
        //clear any existing filter to tidy up the interface
        txtEnterName.Text = "";
        lstStockList.DataSource = AllStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "Id";
        //set the data field to display
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();

    }
}
      