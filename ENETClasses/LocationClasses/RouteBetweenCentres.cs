using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.LocationClasses
{
    class RouteBetweenCentres : ILocation
    {
        /// <summary>
        /// Where the package it's journey.
        /// </summary>
        public DistributionCentre Origin { get; set; }
        /// <summary>
        /// Where the package is expected to arrive at.
        /// </summary>
        public DistributionCentre Destination { get; private set; }
        /// <summary>
        /// When the package was sent and began it's journey enroute to it's destination.
        /// </summary>
        public DateTime SendDate { get; set; }
    }
}
