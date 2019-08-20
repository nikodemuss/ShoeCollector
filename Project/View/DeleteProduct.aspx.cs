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
    public partial class DeleteProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Response.Redirect("/View/Login.aspx");
            }
            loadData();
        }
        public void loadData()
        {
            shoeDGV.DataSource = ShoeRepository.getShoeData();
            shoeDGV.DataBind();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            int deleteID = Int32.Parse(delShoeID.Text);
            ShoeTable delShoe = ShoeHandler.findShoeByID(deleteID);
            ShoeRepository.deleteShoe(delShoe);
            loadData();

        }
    }
}