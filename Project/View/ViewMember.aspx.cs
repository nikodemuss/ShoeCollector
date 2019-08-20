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
    public partial class ViewMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null && Session["Role"].ToString() == UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Response.Redirect("/View/Login.aspx");
            }
            loadData();
        }

        public void loadData()
        {
            userDGV.DataSource = UserRepository.getUserData();
            userDGV.DataBind();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            int deleteID = Int32.Parse(delUserID.Text);
            if (UserController.deleteUser(deleteID))
            {
                deleteUserErrorLabel.Text = "Success!";
            }
            else
            {
                deleteUserErrorLabel.Text = "Please Check the Data!";
            }
            loadData();
        }

        protected void setAdminID_Click(object sender, EventArgs e)
        {
            int userIDToAdmin = Int32.Parse(setAdminUserID.Text);
            UserController.updatePrivillage(userIDToAdmin);
            loadData();
        }
    }
}