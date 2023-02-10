using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm2
{
    internal class User
    {
        public User() {}
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public bool OptIn { get; set; }

    }
}
