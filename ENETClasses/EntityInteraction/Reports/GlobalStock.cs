using ENETClasses.LocationClasses;
using ENETClasses.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction.Reports
{
    class GlobalStock : IReport
    {
        public AustralianDollar TotalStockValue { get; set; }
        public int TotalStockCount { get; set; }

        private List<DistributionCentre> _centres;
    }
}
