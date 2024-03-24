using System;
using System.Linq;
using EarEchoEmporium.AppData;

namespace EarEchoEmporium
{
    public enum ErrorCode
    { 
        Error,Success
    }
    public class UserRepository
    {
        public ErrorCode Register(string firstName, string lastName, string email, string password, string conNum, string address)
        {
            try
            {
                using (var db = new dbsys32ProjEntities())
                {
                    var newCust = new Customers();
                    newCust.firstName = firstName;
                    newCust.lastName = lastName;
                    newCust.email = email;
                    newCust.password = password;
                    newCust.contactNum = conNum;
                    newCust.address = address;

                    db.Customers.Add(newCust);
                    db.SaveChanges();

                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine("Error: " + ex.ToString());
                return ErrorCode.Error;
            }
        }

        public bool AuthenticateUser(string email, string hashedPassword)
        {
            try
            {
                using (var db = new dbsys32ProjEntities())
                {
                    var user = db.Customers.FirstOrDefault(c => c.email == email && c.password == hashedPassword);
                    return user != null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return false;
            }
        }
    }
}
