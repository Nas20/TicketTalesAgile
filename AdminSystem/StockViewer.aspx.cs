using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsstock
        clsStock AStock = new clsStock();
        //store the data in the session object
        AStock = (clsStock)Session["AStock"];
        //allow field to be edited
        Response.Write(AStock.StockId);
        Response.Write(AStock.ItemName);
        Response.Write(AStock.Quantity);
        Response.Write(AStock.StockPrice);
        Response.Write(AStock.StockAvailable);
        Response.Write(AStock.DatePurchased);
    }
}