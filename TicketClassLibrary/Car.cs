namespace TicketClassLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Returnerer prisen for køretøjet.
        /// </summary>
        /// <returns>Prisen for køretøjet.</returns>
        public override double Price()
        {
            double price = 240;
            return price;
        }

        /// <summary>
        /// Beregner prisen med Brobizz-rabat.
        /// </summary>
        /// <returns>Prisen efter Brobizz-rabatten er fratrukket.</returns>
        public override double PriceWithBrobizz()
        {
            double price = 240;
            double priceWithBrobizz = price - (price * 0.05);
            return priceWithBrobizz;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public override string VehicleType()
        {
            string car = "Car";
            return car;
        }
    }
}
