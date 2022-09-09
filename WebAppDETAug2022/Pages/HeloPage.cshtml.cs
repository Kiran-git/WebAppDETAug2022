using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class HeloPageModel : PageModel
    {
        public Helo1 ob { get; set; }
       // public Helo2 ob2 { get; set; }
       public string Message { get; set; }
        public void OnGet()
        {
            ob = new Helo1();
            //ob = new Helo2();
            Message = ob.SayHelo("Kiran Nibgur");
        }
    }
}
