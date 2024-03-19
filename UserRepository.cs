using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarEchoEmporium.AppData;

namespace EarEchoEmporium
{
    public enum ErrorCode
    {
        Error,
        Success
    }
    public class UserRepository
    {
        public ErrorCode Register(String firstName, String lastName, String userName, String password, String conNum)
        {
            try
            {
                using (var db = new dbsys32ProjEntities())
                {
                    var newCust = new Customers();
                    newCust.firstName = firstName;
                    newCust.lastName = lastName;
                    newCust.email = userName;
                    newCust.password = password;
                    newCust.contactNum = conNum;

                    db.Customers.Add(newCust);
                    db.SaveChanges();

                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return ErrorCode.Error;
            }
        }
    }
}
