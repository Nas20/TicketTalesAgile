using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing4;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.Id = txtOrderId.Text;
        //AnOrder.CustomerId = txtCustomerId.Text;
        //AnOrder.Address = txtCustomerAddress.Text;
        //AnOrder.ItemName = txtItemName.Text;
        //AnOrder.ItemQuantity = txtItemQuantity.Text;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}