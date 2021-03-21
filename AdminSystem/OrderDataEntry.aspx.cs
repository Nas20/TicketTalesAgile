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
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtCustomerAddress.Text = AnOrder.Address;
            txtDispatchDate.Text = AnOrder.DateDispatch.ToString();
            txtItemName.Text = AnOrder.ItemName;
            txtItemQuantity.Text = AnOrder.ItemQuantity.ToString();
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string cID = txtCustomerId.Text;
        string cAddress = txtCustomerAddress.Text;
        string itemName= txtItemName.Text;
        string dateDispatch = txtDispatchDate.Text;
        string itemQuantity = txtItemQuantity.Text;
        string Error = "";

        Error = AnOrder.Valid(cID, cAddress, dateDispatch, itemName, itemQuantity);
        if (Error == "")
        {
            AnOrder.CustomerId = Convert.ToInt32(cID);
            AnOrder.Address = cAddress;
            AnOrder.ItemName = itemName;
            AnOrder.ItemQuantity = Convert.ToInt32(itemQuantity);
            AnOrder.DateDispatch = Convert.ToDateTime(dateDispatch);
            AnOrder.Made = chkActive.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrderList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }

    
}