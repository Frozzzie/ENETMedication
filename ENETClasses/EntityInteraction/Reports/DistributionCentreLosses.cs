using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction.Reports
{
    class DistributionCentreLosses : IReport
    {
        public double LossRatio { get; set; }

        public int Lost { get; set; }
        public int Discarded { get; set; }
        public int Distributed { get; set; }
    }
}
