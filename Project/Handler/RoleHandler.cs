using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class RoleHandler
    {
        public static UserRole findUserRole(string roleId)
        {
            return DBSingleton.getDB().UserRole.Where(x => x.UserRoleId == roleId).SingleOrDefault();
        }
    }
}