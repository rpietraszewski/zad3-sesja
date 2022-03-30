using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using zad3.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace zad3.Pages
{
    public class ZapisaneModel : PageModel
    {
        public Check Check { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                Check =
                JsonConvert.DeserializeObject<Check>(Data);
        }
    }
}
