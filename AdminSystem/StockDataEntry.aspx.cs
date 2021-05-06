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
    Int32 StockId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be processed
        StockId = Convert.ToInt32(Session["StockId"]);
        if (IsPostBack == false)
        {
            //if this is a new record
            if (StockId != -1)
            {
                //displays the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of customers
        clsStockCollection AStock = new clsStockCollection();
        //find the record to update
        AStock.ThisStock.Find(StockId);
        //display the data
        txtStockId.Text = AStock.ThisStock.StockId.ToString();
        txtItemName.Text = AStock.ThisStock.ItemName;
        txtQuantity.Text = AStock.ThisStock.Quantity.ToString();
        txtPrice.Text = AStock.ThisStock.StockPrice.ToString();
        txtDatePurchased.Text = AStock.ThisStock.DatePurchased.ToString();
        chkStockAvailable.Text = AStock.ThisStock.Active.ToString();
    }
    /*
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the stock id
        string StockId = txtStockId.Text;
        //capture the item name
        string ItemName = txtItemName.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the date pruchased
        string DatePurchased = txtDatePurchased.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AStock.Valid(StockId, ItemName, Quantity, Price, DatePurchased);
        if (Error == "") ;
        {
            //capture the item name
            AStock.ItemName = ItemName;  //DONT MISS THIS BIT OUT!!!!
            //capture the quantity
            AStock.Quantity = Convert.ToInt32(Quantity);
            //capture the stock price
            AStock.StockPrice = Convert.ToDecimal(txtPrice);
            //capture active
            AStock.Active = chkActive.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record then add the data
            if (StockId = 1)
            {
                //set the ThisOrder property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwsie it has to be an update
            else
            {
                //fidn the property
                StockList.ThisStock.Find(StockId);
                //set the ThisOrder property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    */

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 StockId;
        Boolean Found = false;
        StockId = Convert.ToInt32(txtStockId.Text);
        Found = AStock.Find(StockId);
        if (Found == true)
        {
            txtItemName.Text = AStock.ItemName;
            txtQuantity.Text = AStock.ToString();
            txtPrice.Text = AStock.StockPrice.ToString();
            txtDatePurchased.Text = AStock.DatePurchased.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {

    }
}