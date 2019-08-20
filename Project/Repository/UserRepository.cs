using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class UserRepository
    {
        public static void insertUser(MsUser newUser)
        {
            DBSingleton.getDB().MsUser.Add(newUser); //lamda exprestion
            DBSingleton.getDB().SaveChanges();
        }
        //CRUD 

        //Read
        public static List<MsUser> getUserData()
        {
            return DBSingleton.getDB().MsUser.ToList();
        }



        //Update
        public static void updateUser(int id, string updateName, string email, string updatePassword, string gender, DateTime birthDate, string phoneNumber, string address, string profile, string userRole)
        {
            MsUser updateUser = DBSingleton.getDB().MsUser.Where(y => y.UserId == id).SingleOrDefault();
            updateUser.UserName = updateName;
            updateUser.Email = email;
            updateUser.UserPassword = updatePassword;
            updateUser.Gender = gender;
            updateUser.BirthDate = birthDate;
            updateUser.PhoneNumber = phoneNumber;
            updateUser.Address = address;
            updateUser.Profile = profile;
            updateUser.UserRole = userRole;
            DBSingleton.getDB().SaveChanges();
        }

        //Delete
        public static void deleteUser(MsUser delUser)
        {
            DBSingleton.getDB().MsUser.Remove(delUser);
            DBSingleton.getDB().SaveChanges();
        }
    }
}