using Ksenya_Modul7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ksenya_Modul7.Pages
{
    public class PeopleModel : PageModel
    {
       private readonly DataBaseContext _context;

        public List<Person> People { get; set;} = new List<Person>();

        [BindProperty]
        public Person NewPerson { get; set; }
        public PeopleModel(DataBaseContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            People = _context.People.ToList();
        }
        public IActionResult OnPost()
        {
            _context.People.Add(NewPerson);
            _context.SaveChanges();
            return RedirectToPage();

        }
    }
}
