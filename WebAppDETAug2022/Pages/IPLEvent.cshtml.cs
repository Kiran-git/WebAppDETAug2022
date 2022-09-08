using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Modelss;

namespace WebAppDETAug2022.Pages.Shared
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        public object ID { get; private set; }
        public void OnGet()
        {
            Tickets = new List<Ticket>
            {
               new Ticket{ID=1,Category="PlatinumPlus",Price=5000,MaxLimit=200000},
            new Ticket{ID=2,Category="Platinum",Price=4000,MaxLimit=300000},
            new Ticket{ID=3,Category="Gold",Price=3000,MaxLimit=500000}


            };
        }
    }
}
