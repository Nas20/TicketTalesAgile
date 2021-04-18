using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    //var to store primary key value of the record to be deleted
    Int32 StockId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of addresses to be deleted from the session object

        StockId = Convert.ToInt32(Session["StockId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsStockCollection AllStock = new clsStockCollection();
        //find the record to delete
        AllStock.ThisStock.Find(StockId);
        //delete the record
        AllStock.Delete();
        //redirect to the main page
        Response.Redirect("StockList.aspx");

    }
}