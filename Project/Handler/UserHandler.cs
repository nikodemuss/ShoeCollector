using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UserHandler
    {
        public static MsUser findUserByID(int id)
        {
            List<MsUser> data = UserRepository.getUserData();
            return data.Where(x => x.UserId == id).SingleOrDefault();
        }

        public static MsUser findUserByEmail(string email)
        {
            List<MsUser> data = UserRepository.getUserData();
            return data.Where(x => x.Email == email).SingleOrDefault();
        }

        public static void updateUserToAdmin(int id)
        {
            List<MsUser> data = UserRepository.getUserData();
            MsUser updateUser = data.Where(y => y.UserId == id).SingleOrDefault();
            updateUser.UserRole = "U002";
            DBSingleton.getDB().SaveChanges();
        }

        public static UserRole findUserRole(string roleId)
        {
            return DBSingleton.getDB().UserRole.Where(x => x.UserRoleId == roleId).SingleOrDefault();
        }

        public static void updatePassword(int id, string pass)
        {
            List<MsUser> data = UserRepository.getUserData();
            MsUser updateUser = data.Where(y => y.UserId == id).SingleOrDefault();
            updateUser.UserPassword = pass;
            DBSingleton.getDB().SaveChanges();
        }

    }
}