using System;
using ENETClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENETClasses.LocationClasses;
using System.Collections.Generic;
using ENETClasses.Package;
using ENETClasses.EntityInteraction.Reports;
using ENETClasses.Employee;

namespace ENETTests
{
    [TestClass]
    public class InformationSwapTests
    {

        private class EnetSys
        {
            public Employee _employee;
            public ILocation _location;
            public PackageItem _package;

            public EnetSys()
            {
                _employee = new Doctor("Bruce", "\"the pain\" Wayne", "whereisshe_thebombs");
                _location = new DistributionCentre("Up", "Down", "1");
                _package = new PackageItem(5000, "Sweet and Sour Pork", 13.95);
            }
        }
        EnetSys _EnetSys;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            //sets up base program
            _EnetSys = new EnetSys();
        }


        [TestMethod]
        public void User_OnSetup_Exists()
        {
            //checks that a user exists
            Assert.IsNotNull(_EnetSys._employee);   
        }


        [TestMethod]
        public void Location_OnSetup_Exists()
        {
            //checks that a location exists
            Assert.IsNotNull(_EnetSys._location);
        }


        [TestMethod]
        public void Package_OnSetup_Exists()
        {
            //checks that a package exists
            Assert.IsNotNull(_EnetSys._package);
        }


        [TestMethod]
        public void User_OnLogin_SuccessfulLogin()
        {
            //checks that a user can login
            Assert.IsTrue(_EnetSys._employee.login("pass"));
        }


        [TestMethod]
        public void User_OnLogin_HasAttributes()
        {
            //checks that a user has stats
            Assert.IsNotNull(_EnetSys._employee.Fullname);
            Assert.IsNotNull(_EnetSys._employee.EmailAddress);
            Assert.IsNotNull(_EnetSys._employee.CentreOfWork);
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

        [TestMethod]
        public void Location_BetweenDistributionCentres_CorrectlyPrints()
        {
            var loc1 = new DistributionCentre("Centre A", "Up the road", "1");
            var loc2 = new DistributionCentre("Centre B", "Down the road", "2");

            var route = new RouteBetweenCentres(loc1, loc2);

            Assert.AreEqual(route.ReportOutput, "Enroute from Centre A to Centre B"); // For example
        }


        [TestMethod]
        public void Employee_FullName_CorrectlyOutputsToReport()
        {
            var emp1 = new Doctor("John", "Doe", "JDnTurk");
            Assert.AreEqual(emp1.Fullname, "John Doe");
        }

        [TestMethod]
        public void Reportable_GenerateReport_ReturnsReportType()
        {
            var centre = new DistributionCentre("Blank", "", "Nothing here");
            var t = centre.GenerateReport<DistributionCentreStock>();
        }
        
    }
}
