using ENETClasses.LocationClasses;
using ENETClasses.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction.Reports
{
    public class DistributionCentreStock : IReport
    {
        public AustralianDollar TotalStockValue { get; set; }
        public int TotalStockCount { get; set; }

        public DistributionCentreStock(DistributionCentre centre)
        {

        }
    }
}
