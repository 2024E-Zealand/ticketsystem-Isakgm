using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Returnerer prisen for køretøjet.
        /// </summary>
        /// <returns>Prisen for køretøjet.</returns>
        

        public override double Price()
        {
            double price = 125;
            return price;
        }

        /// <summary>
        /// Beregner prisen med Brobizz-rabat.
        /// </summary>
        /// <returns>Prisen efter Brobizz-rabatten er fratrukket.</returns>
        public override double PriceWithBrobizz()
        {
            double price = 125;
            double priceWithBrobizz = price - (price * 0.05);
            return priceWithBrobizz;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>


        public override string VehicleType()
        {
            string mc = "MC";
            return mc;
        }
    }
}
