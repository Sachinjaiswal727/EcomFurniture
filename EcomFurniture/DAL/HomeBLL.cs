using EcomFurniture.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomFurniture.Models
{
    public class HomeBLL
    {
        FurEcomContext db = new FurEcomContext();
        public bool Checkusertype(string email,string password)
        {
            try
            {
                User user = db.Users.Where(user => user.UEmail == email && user.UPassword == password).FirstOrDefault();
                if (user == null)
                {
                    //user is not authorised
                    return false;
                }
                else
                {

                    if (user.URole == "admin")
                    {
                        //User is admin 
                        return true;
                    }
                    else
                    {
                        //User is not admin
                        return false;

                    }
                }
            }
            catch
            {
                throw;
            }
        }

    }
}

