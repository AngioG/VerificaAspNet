using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Audio audio { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.Audio.Add(audio);
            _context.SaveChanges();


            return RedirectToPage("Index");
        }
    }
}
