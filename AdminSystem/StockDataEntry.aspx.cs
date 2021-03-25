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

        string StockId = txtStockId.Text;
        string ItemName = txtItemName.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string DatePurchased = txtDatePurchased.Text;
        string Error = "";
        Error = AStock.Valid(StockId, ItemName, Quantity, Price, DatePurchased);
        if (Error == "");
        {
            //AStock.Id = txtStockId.Text;
            AStock.ItemName = txtItemName.Text;
            //AStock.Quantity = txtQuantity.Text;
            AStock.Price = Convert.ToDecimal(txtPrice.Text);
            Session["AStock"] = AStock;
            Response.Write(AStock.ItemName);
            Response.Redirect("StockViewer.aspx");
            //Response.Write(AStock.ItemName);
            //Response.Write(AStock.Price);
            //Response.Redirect("Stockviewer.aspx");
        }
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 StockId;
        Boolean Found = false;
        StockId = Convert.ToInt32(txtStockId.Text);
        Found = AStock.Find(StockId);
        if(Found == true)
        {
            txtItemName.Text = AStock.ItemName;
            txtQuantity.Text = AStock.ToString();
            txtPrice.Text = AStock.Price.ToString();
            txtDatePurchased.Text = AStock.DatePurchased.ToString();
        }
    }
}