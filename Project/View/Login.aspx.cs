using Project.Controller;
using Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserEmail"];
            if (cookie != null)
            {
                Txt_Email.Text = cookie["Email"];
            }

            if (Session["Role"] == null)
            {
                Btn_HomeRedirect.Visible = true;
                Btn_LoginRedirect.Visible = true;
                Btn_ProductRedirect.Visible = true;
                Btn_RegisterRedirect.Visible = true;
            }

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            //Response.Cookies["UserEmail"].Expires = DateTime.Now.AddDays(-1);
            string email = Txt_Email.Text;
            string password = Txt_Password.Text;
            System.Diagnostics.Debug.WriteLine("Email Login = " + email);
            Boolean login = UserController.login(email, password);

            if (login)
            {
                Label_Error.Text = "Success";
                string userRole = UserHandler.findUserByEmail(Txt_Email.Text).UserRole.ToString();
                setCookie(userRole);
                setSession(userRole);
                Response.Redirect("/View/Home.aspx");
            }
            else
            {
                Label_Error.Text = "Please Check the Email and Password";
            }
        }

        private void setCookie(string userRole)
        {
            if (Check_RememberMe.Checked == true && userRole == UserHandler.findUserRole("U001").UserRoleId.ToString())
            {
                HttpCookie cookie = new HttpCookie("UserEmail");
                cookie["Email"] = Txt_Email.Text;
                cookie.Expires = DateTime.Now.AddMinutes(60);
                Response.Cookies.Add(cookie);
            }
        }

        private void setSession(string userRole)
        {
            Session.Timeout = 60;
            Session["UserID"] = UserHandler.findUserByEmail(Txt_Email.Text).UserId.ToString();
            Session["Email"] = Txt_Email.Text;
            Session["Role"] = userRole;
            Session["UserName"] = UserHandler.findUserByEmail(Txt_Email.Text).UserName.ToString();
        }

        protected void Btn_LoginRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void Btn_RegisterRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Register.aspx");
        }

        protected void Btn_ProductRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/ViewProduct.aspx");
        }

        protected void Btn_HomeRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Home.aspx");
        }
    }
}