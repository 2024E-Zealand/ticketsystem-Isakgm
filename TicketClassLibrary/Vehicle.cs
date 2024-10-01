using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        private string _licensePlate;
        /// <summary>
        /// Får eller sætter nummerpladen på køretøjet. Nummerpladen må ikke være længere end 7 tegn.
        /// </summary>
        /// <exception cref="ArgumentException">Kastes, hvis nummerpladen er længere end 7 tegn.</exception>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn.");
                }
                _licensePlate = value;
            }
        }

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
