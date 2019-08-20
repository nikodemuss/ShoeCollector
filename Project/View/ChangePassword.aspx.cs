using Project.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class ChangePasssword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("/View/Login.aspx");
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(Session["UserID"].ToString());

            if  (UserController.checkPassword(userID, oldPassword.Text))
            {
                if (UserController.updatePassword(userID, newPassword.Text, confirmPassword.Text, oldPassword.Text))
                {
                    errorLabel.Text = "Success!";
                }
                else
                {
                    errorLabel.Text = "Please Check The new password and confirm password";
                }
            }
            else
            {
                errorLabel.Text = "Please Check The old Password";
            }
        }
    }
}