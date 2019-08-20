using Project.Factory;
using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace Project.Controller
{
    public class UserController
    {

        public static bool login(string email, string password)
        {
            MsUser user = UserHandler.findUserByEmail(email);
            System.Diagnostics.Debug.WriteLine("Login run" + email + " " + password + " UP " + user.UserPassword);
            if (user != null && user.UserPassword == password)
            {
                System.Diagnostics.Debug.WriteLine("Login True");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool register(string userName, string email, string password, string confirmPass, string gender, string phone, DateTime birthDate, string address, string profilePicture)
        {
            if (userName != "" && checkEmail(email) && checkPassword(password, confirmPass) && checkPhone(phone) && checkAge(birthDate) && checkAddress(address))
            {
                MsUser newUser = UserFactory.createUser(userName, email, password, gender, birthDate, phone, address, profilePicture, "U001");
                UserRepository.insertUser(newUser);
                return true;
            }
            return false;
        }

        public static bool updatePassword(int id, string password, string confirmPass, string oldPass)
        {
            MsUser user = UserHandler.findUserByID(id);
            if (user.UserPassword == password && confirmPass != password && oldPass != user.UserPassword && password == "" && checkPassword(password, confirmPass))
            {
                return false;
            }
            UserHandler.updatePassword(id, password);
            return true;
        }

        public static bool checkAge(DateTime birthDate)
        {
            int now = DateTime.Now.Year;
            System.Diagnostics.Debug.WriteLine("Check Age run = " + (now - birthDate.Year));
            return (now - birthDate.Year) > 16;
        }

        public static bool checkEmail(string email)
        {
            if (email != "" && UserHandler.findUserByEmail(email) == null)
            {
                System.Diagnostics.Debug.WriteLine("Email OK");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Email Error");
                return false;
            }
        }

        public static string getUserRole(string id)
        {
            return UserHandler.findUserRole(id).UserRoleName.ToString();
        }

        private static bool checkPassword(string password, string confirmPassword)
        {
            if (password != "" && password.Equals(confirmPassword) && password.Length > 4 && isAlphaNumeric(password))
            {
                System.Diagnostics.Debug.WriteLine("Pass OK");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Pass Error");
                return false;
            }
        }

        private static Boolean isAlphaNumeric(string stringCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(stringCheck);
        }

        private static bool checkPhone(string phone)
        {
            if (phone.All(char.IsDigit) && phone.Length > 9 && phone.Length < 13)
            {
                System.Diagnostics.Debug.WriteLine("Phone Ok");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Phone Error");
                return false;
            }
        }

        private static bool checkAddress(string address)
        {
            if (address != "" && address.Split(' ').Last().Equals("Street"))
            {
                System.Diagnostics.Debug.WriteLine("Address OK");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Address Error");
                return false;
            }
        }
        public static bool updatePrivillage(int id)
        {
            if (UserHandler.findUserByID(id) != null)
            {
                UserHandler.updateUserToAdmin(id);
                return true;
            }
            return false;
        }

        public static bool deleteUser(int id)
        {
            MsUser delUser = UserHandler.findUserByID(id);
            if (delUser != null)
            {
                UserRepository.deleteUser(delUser);
                return true;
            }
            return false;
        }

        public static bool checkPassword(int id, string password)
        {
            MsUser user = UserHandler.findUserByID(id);
            if (user.UserPassword == password)
            {
                return true;
            }
            return false;
        }
    }
}