﻿using System;
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
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.Address = txtCustomerAddress.Text;
        AnOrder.ItemName = txtItemName.Text;
        AnOrder.ItemQuantity = Convert.ToInt32(txtItemQuantity.Text);
        AnOrder.DateDispatch = Convert.ToDateTime(txtDispatchDate.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
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
}