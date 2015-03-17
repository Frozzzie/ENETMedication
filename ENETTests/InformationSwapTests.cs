using System;
using ENETClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENETClasses.LocationClasses;
using System.Collections.Generic;
using ENETClasses.Package;
using ENETClasses.EntityInteraction.Reports;

namespace ENETTests
{
    [TestClass]
    public class InformationSwapTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void DistributionCentre_PackageValueOfPackages()
        {
            PackageItem p = new PackageItem(100, "Pills", 100);
            var p1 = new PackageItem(1, "Something cool", 1000);
            var p2 = new PackageItem(25, "Something fairly normal", 1);
            DistributionCentre d = new DistributionCentre("Blank", "Nowhere", "1");
            d.Packages = new List<PackageItem>() { p, p1, p2 };
            DistributionCentreStock report = new DistributionCentreStock(d);
            Assert.AreEqual(report.TotalStockValue, 10125);
        }

        
    }
}
