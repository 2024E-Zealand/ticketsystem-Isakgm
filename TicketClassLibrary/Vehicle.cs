using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Får eller sætter nummerpladen på køretøjet.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Får eller sætter datoen for transaktionen.
        /// </summary>
        public DateTime Date { get; set; }

        public abstract double Price();


        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public abstract string VehicleType();
        

    }
}
