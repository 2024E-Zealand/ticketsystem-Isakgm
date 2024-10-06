using TicketClassLibrary;

namespace OresundbronTicketLibrary
{
    public class OresundCar : Car 
    {
        /// <summary>
        /// Returnerer prisen for køretøjet.
        /// </summary>
        /// <returns>Prisen for køretøjet.</returns>
        public override double Price()
        {
            double price = 410;
            return price;
        }

        /// <summary>
        /// Beregner prisen med Brobizz-rabat.
        /// </summary>
        /// <returns>Prisen efter Brobizz-rabatten er fratrukket.</returns>
        public override double PriceWithBrobizz()
        {

            double priceWithBrobizz = 161;
            return priceWithBrobizz;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public override string VehicleType()
        {
            string car = "Oresund Car";
            return car;
        }
    }
}
