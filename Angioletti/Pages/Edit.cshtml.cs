using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Audio audio { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return RedirectToPage("Read");

            audio = _context.Audio.FirstOrDefault(a => a.Id == id);

            if (audio == null) return NotFound();

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null) return RedirectToPage("Read");

            if (!ModelState.IsValid) return Page();

            _context.Attach(audio).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (_context.Audio.FirstOrDefault(a => a.Id == id) == null)
                    return Page();

                throw;
            }

            return RedirectToPage("Index");
        }
    }
}
