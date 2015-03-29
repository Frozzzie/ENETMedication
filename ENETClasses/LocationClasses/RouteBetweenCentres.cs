using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.LocationClasses
{
    public class RouteBetweenCentres : ILocation
    {
        /// <summary>
        /// Where the package it's journey.
        /// </summary>
        public DistributionCentre Outset { get; set; }
        /// <summary>
        /// Where the package is expected to arrive at.
        /// </summary>
        public DistributionCentre Destination { get; private set; }
        /// <summary>
        /// When the package was sent and began it's journey enroute to it's destination.
        /// </summary>
        public DateTime SendDate { get; set; }

        public RouteBetweenCentres(DistributionCentre beginning, DistributionCentre end)
        {
            Outset = beginning;
            Destination = end;
        }

        /// <summary>
        /// Information output to reports that query this object.
        /// </summary>
        public string ReportOutput { get; set; }
    }
}
