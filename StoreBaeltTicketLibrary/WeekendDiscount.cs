
namespace StoreBaeltTicketLibrary
{
    public class WeekendDiscount
    {
        public double FinalPrice(DateTime date, bool hasBrobizz)
        {
            double price = 240;
            double resPrice;

            // Tjek om det er lørdag eller søndag
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                // 20% rabat
                resPrice = price - (price * 0.20);
            }
            else
            {
                // Ingen rabat
                resPrice = price;
            }

            // Tjek om der er Brobizz og træk 5% rabat fra efter weekendrabatten
            if (hasBrobizz)
            {
                resPrice -= (resPrice * 0.05);
            }

            return resPrice;
        }

    }
}
