using Project.Controller;
using Project.Factory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                Response.Redirect("/View/Login.aspx");
            }
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            int age = Calendar_BirthDate.TodaysDate.Year - Calendar_BirthDate.SelectedDate.Year;
            string name = Txt_Name.Text;
            string email = Txt_Email.Text;
            string password = Txt_Password.Text;
            //DateTime birthDate = Calendar_BirthDate.SelectedDate;
            DateTime birthDate = DateTime.Parse("1999-02-02");
            string phoneNumber = Txt_Phone.Text;
            string profilePicture = Path.GetFileName(File_ProfilePicture.PostedFile.FileName);
            string address = Txt_Address.Text;


            if (checkImage(File_ProfilePicture) && Gender.SelectedItem.Selected)
            {
                string gender = Gender.SelectedItem.Text;
                File_ProfilePicture.PostedFile.SaveAs(Server.MapPath("~/UploadsProfile/") + profilePicture);
                if (UserController.register(name, email,password,Txt_ConfirmPassword.Text,gender,phoneNumber,birthDate,address,profilePicture))
                {
                    Label_Error.Text = "Success";
                }
                else
                {
                    Label_Error.Text = "Please Check the Data!";
                }
            }
            else
            {
                Label_Error.Text = "Please Check the Image! or Gender";
            }

        }

        private bool checkImage(FileUpload profileImage)
        {
            if (profileImage.HasFile && (Path.GetExtension(profileImage.PostedFile.FileName).ToLower() == ".jpg" || Path.GetExtension(profileImage.PostedFile.FileName).ToLower() == ".png"))
                return true;
            else
            {
                Label_Error.Text = "Please check the image";
                return false;
            }
        }

    }
}