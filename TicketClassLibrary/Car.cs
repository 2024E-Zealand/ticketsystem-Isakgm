namespace TicketClassLibrary
{
    public class Car
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
            double price = 240;
            return price;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public string VehicleType()
        {
            string car ="Car";
            return car;
        }
    }
}
