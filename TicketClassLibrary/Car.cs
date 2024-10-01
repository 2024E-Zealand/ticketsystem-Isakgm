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
