using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class UserFactory
    {
        public static MsUser createUser(string userName, string email, string userPassword, string gender, DateTime birthDate, string phone, string address, string profile, string userRole)
        {
            return new MsUser()
            {
                UserName = userName,
                Email = email,
                UserPassword = userPassword,
                Gender = gender,
                BirthDate = birthDate,
                PhoneNumber = phone,
                Address = address,
                Profile = profile,
                UserRole = userRole

            };
        }
    }
}