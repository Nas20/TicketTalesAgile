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
    //variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order that needs to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(OrderId != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the address book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for this record
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtCustomerAddress.Text = OrderBook.ThisOrder.Address;
        txtDispatchDate.Text = OrderBook.ThisOrder.DateDispatch.ToString();
        txtItemName.Text = OrderBook.ThisOrder.ItemName;
        txtItemQuantity.Text = OrderBook.ThisOrder.ItemQuantity.ToString();
        chkActive.Checked = OrderBook.ThisOrder.Made;
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
            //capture OrderId
            AnOrder.OrderId = OrderId;
            //capture CustomerId
            AnOrder.CustomerId = Convert.ToInt32(cID);
            //Capture the address
            AnOrder.Address = cAddress;
            //capture the item name
            AnOrder.ItemName = itemName;
            //capture the item quantity
            AnOrder.ItemQuantity = Convert.ToInt32(itemQuantity);
            //capture the date for dispatch
            AnOrder.DateDispatch = Convert.ToDateTime(dateDispatch);
            //capture the order made
            AnOrder.Made = chkActive.Checked;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            
            //if this is a new record then add the data
            if(OrderId != -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwsie it has to be an update
            else
            {
                //fidn the property
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    
}