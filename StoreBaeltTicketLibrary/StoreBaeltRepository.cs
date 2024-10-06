using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltRepository : IStoreBaeltRepository
    {
        // Statisk liste der indeholder alle Storebæltbilletter.
        private static List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Tilføjer en ny billet til listen (køber en billet).
        /// </summary>
        /// <param name="ticket">Den nye billet der skal tilføjes.</param>
        public void AddTicket(Vehicle ticket)
        {
            _tickets.Add(ticket);
            Console.WriteLine($"Ny billet tilføjet for nummerplade: {ticket.LicensePlate}.");
        }

        /// <summary>
        /// Henter alle billetter.
        /// </summary>
        /// <returns>En liste over alle billetter.</returns>
        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }

        /// <summary>
        /// Henter alle billetter for en specifik nummerplade.
        /// </summary>
        /// <param name="licensePlate">Nummerpladen som billetterne skal findes for.</param>
        /// <returns>En liste over billetter for den specifikke nummerplade.</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            var ticketsForLicensePlate = _tickets.Where(t => t.LicensePlate == licensePlate).ToList();
            return ticketsForLicensePlate;
        }
    }
}
