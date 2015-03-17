using ENETClasses.EntityInteraction.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction
{
    interface IReportable
    {
        // An object designated as IReportable can generate a report. So, a distribution centre can generate a Stock Report, or a Loss Report.
        // The distribution network can generate a global Stock Report and a Value-In-Transit report.
        // Doctors can generate an Activity Report.

        // So on and so forth. Due the fact they all function similarly, it seemed prudent to have a single interface for them all.
        // I'm happy to change this if it turns out that it's a little too abstracted and weird though.
        
        T GenerateReport<T>() where T : IReport;
    }
}
