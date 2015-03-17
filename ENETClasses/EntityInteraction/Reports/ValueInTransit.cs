using ENETClasses.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction.Reports
{
    class ValueInTransit : IReport 
    {
        public int StockInTransit { get; set; }
        public AustralianDollar DollarsInTransit { get; set; }

    }
}
