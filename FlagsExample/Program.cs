using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user1=new User();
            user1.Name = "Narendra";
            user1.City = "Dallas";
            user1.PhoneNumber = "9729771566";
            user1.State = "Texas";
            user1.Zip = "75248";
            user1.Roles = Role.Customer | Role.TestProgrammer | Role.BusinessAnalyst;

            //check if the user has specific role 
            if ((user1.Roles & Role.Customer)!=0)
            {
                //here we are checking if user is a customer role
                Console.WriteLine("User {0} has the role {1}",user1.Name,Role.Customer.ToString());

            }

            Console.Read();
        }
    }
}
