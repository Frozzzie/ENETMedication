using ENETClasses.LocationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.Employee
{
    public abstract class Employee
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Fullname { get { return FirstName + " " + LastName; } }
        public string EmailAddress { get; private set; }

        public DistributionCentre CentreOfWork { get; private set; }

        public Employee(string firstname, string lastname, string username)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
        }

        public bool login(string p)
        {
            return true; // AAA security
        }
    }
}
