using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subjects
{
    public class Subject // Class Subject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Subject(string name, string address, string phone, string email)
        {
            Name = name;
            Address = address;
            PhoneNumber = phone;
            Email = email;
        }
    }
}
