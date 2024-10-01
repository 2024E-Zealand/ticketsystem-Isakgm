using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC
    {
        /// <summary>
        /// Får eller sætter nummerpladen på køretøjet.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Får eller sætter datoen for transaktionen.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer prisen for køretøjet.
        /// </summary>
        /// <returns>Prisen for køretøjet.</returns>
        public double Price()
        {
            double price = 125;
            return price;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public string VehicleType()
        {
            string mc = "MC";
            return mc;
        }
    }
}
