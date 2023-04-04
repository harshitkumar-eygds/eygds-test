using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspnetwebapp_emptymvcwebapi3103.Models
{
    public class UserMasterRepository : IDisposable
    {
        security_dbEntities context = new security_dbEntities();
        public UserMaster ValidateUser(string username, string password) 
        {
            return context.UserMasters.FirstOrDefault(user => 
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) 
            && user.UserPassword == password);
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }
}