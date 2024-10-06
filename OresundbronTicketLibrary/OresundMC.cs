using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundbronTicketLibrary
{
    public class OresundMC : MC
    {
        /// <summary>
        /// Returnerer prisen for køretøjet.
        /// </summary>
        /// <returns>Prisen for køretøjet.</returns>


        public override double Price()
        {
            double price = 210;
            return price;
        }

        /// <summary>
        /// Beregner prisen med Brobizz-rabat.
        /// </summary>
        /// <returns>Prisen efter Brobizz-rabatten er fratrukket.</returns>
        public override double PriceWithBrobizz()
        {
            double priceWithBrobizz = 73;
            return priceWithBrobizz;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>


        public override string VehicleType()
        {
            string mc = "Oresund MC";
            return mc;
        }
    }
}
