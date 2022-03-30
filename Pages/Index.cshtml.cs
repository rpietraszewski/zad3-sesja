using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using zad3.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace zad3.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Person Person { get; set; }
        [BindProperty]
        public Check Check { get; set; }
        public IList<Person> People { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //People.Add(Person);
        }
        public IActionResult OnPost()
        {
            (ViewData["Message"], ViewData["MessageClass"]) = Check.getOutput();
            if (!ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data",
                JsonConvert.SerializeObject(Check));

            }

            return Page();
        }

    }
}