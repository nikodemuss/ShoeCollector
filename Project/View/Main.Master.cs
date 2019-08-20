using Project.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Hello.Text = "Hello, Guest - Usertype: Guest";
            }
            else
            {
                string type = Session["Role"].ToString();
                string name = Session["UserName"].ToString();
                string userRole = UserController.getUserRole(type);
                Hello.Text = "Hello, " + name + " - Usertype: " + userRole;
            }

        }
        protected void DateTimer_Tick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }
    }
}