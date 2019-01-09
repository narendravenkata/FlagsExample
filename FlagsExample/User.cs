using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsExample
{
    public class User
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string  Zip { get; set; }
        public Role Roles { get; set; }
        public string PhoneNumber { get; set; }
    }
}
