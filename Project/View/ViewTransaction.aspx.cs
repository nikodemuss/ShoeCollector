using Project.Controller;
using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class ViewTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null || Session["Role"] == null)
            {
                Response.Redirect("/View/Login.aspx");
            }
            loadData();
        }

        private void loadData()
        {

            if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U001").UserRoleId.ToString())
            {
                int userID = Int32.Parse(Session["UserID"].ToString());
                productTransaction.DataSource = TransactionHandler.getTransactionForSpecificUser(userID);
                productTransaction.DataBind();

            }
            else if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                productTransaction.DataSource = TransactionHandler.getTransaction();
                productTransaction.DataBind();
            }
            //else
            //{
            //    productTransaction.DataSource = TransactionHandler.getTransaction();
            //    productTransaction.DataBind();
            //}
            
        }

        protected void generateTransactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/TransactionReport.aspx");
        }

        protected void changeToApprovedBtn_Click(object sender, EventArgs e)
        {
            //productTransaction.
        }

        protected void approvedBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(approveId.Text);
            TransactionController.updateToApproved(id);
        }
    }
}