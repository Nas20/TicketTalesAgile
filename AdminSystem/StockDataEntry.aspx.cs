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

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        //AStock.Id = txtStockId.Text;
        AStock.ItemName = txtItemName.Text;
        //AStock.Quantity = txtQuantity.Text;
        AStock.Price = txtPrice.Text;
        Session["AStock"] = AStock;
        Response.Write(AStock.ItemName);
        Response.Redirect("StockViewer.aspx");
        //Response.Write(AStock.ItemName);
        //Response.Write(AStock.Price);
        //Response.Redirect("Stockviewer.aspx");
    }
}