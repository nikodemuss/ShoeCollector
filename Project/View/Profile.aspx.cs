using Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("/View/Login.aspx");
            }
            loadData();
        }

        public void loadData()
        {
            int userID = Int32.Parse(Session["UserID"].ToString());
            List<MsUser> user = new List<MsUser>();
            user.Add(UserHandler.findUserByID(userID));
            profileDGV.DataSource = user;
            profileDGV.DataBind();
        }

        protected void changePassBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/ChangePassword.aspx");
        }
    }
}