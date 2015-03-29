using ENETClasses.EntityInteraction;
using ENETClasses.EntityInteraction.Reports;
using ENETClasses.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.LocationClasses
{
    public class DistributionCentre : ILocation, IReportable
    {
        public List<PackageItem> Packages { get; set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }

        public DistributionCentre(string name, string address, string phonenumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phonenumber;
        }


        public T GenerateReport<T>() where T : EntityInteraction.Reports.IReport
        {
            return default(T);
        }
    }
}
