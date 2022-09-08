using WebAppDETAug2022.Modelss;
namespace WebAppDETAug2022.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextID = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
            new Ticket{ID=1,Category="PlatinumPlus",Price=5000,MaxLimit=200000},
            new Ticket{ID=2,Category="Platinum",Price=4000,MaxLimit=300000},
            new Ticket{ID=3,Category="Gold",Price=3000,MaxLimit=500000}
           

            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.ID == id);

        public static void Add(Ticket ticket)
        {
            ticket.ID = nextID++;
            Tickets.Add(ticket);
        }

    }
}
