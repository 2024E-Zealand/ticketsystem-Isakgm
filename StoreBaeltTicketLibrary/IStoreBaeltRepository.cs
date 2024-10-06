using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public interface IStoreBaeltRepository
    {
        void AddTicket(Vehicle ticket);
        List<Vehicle> GetAllTickets();
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}