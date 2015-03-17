using ENETClasses.LocationClasses;
using ENETClasses.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.Package
{
    public class PackageItem
    {
        private static int CurrentPackageNumber;
        private static int GetNextPackageNumber { get { return CurrentPackageNumber++;  } }

        public int Count { get; set; }
        public int BarcodeNumber { get; private set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Value of package item per item in $AUD.
        /// </summary>
        public AustralianDollar ValuePerItem { get; private set; }

        /// <summary>
        /// Total value of the package bundle.
        /// </summary>
        public AustralianDollar TotalValue { get { return ValuePerItem * Count; } }

        /// <summary>
        /// Where the package is currently residing.
        /// </summary>
        public ILocation Location { get; set; }

        public PackageItem(int count, string description, AustralianDollar value)
        {
            Count = count;
            Description = description;
            ValuePerItem = value;
        }
    }
}
