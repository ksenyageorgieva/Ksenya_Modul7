using Ksenya_Modul7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicCatalog.Models;

namespace Ksenya_Modul7.Pages
{
    public class SongsModel : PageModel
    {
        private readonly MyDbContext _context;
        public List<Song> Songs { get; set; } = new List<Song>();
        [BindProperty]
        public Song NewSong { get; set; }
        public SongsModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            OnGetWithContext(_context);
        }

        public void OnGetWithContext(MyDbContext _context)
        {
            Songs = _context.Songs.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Songs.Add(NewSong);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
