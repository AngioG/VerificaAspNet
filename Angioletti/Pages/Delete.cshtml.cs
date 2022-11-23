using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

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

            audio = _context.Audio.FirstOrDefault(a => a.Id == id);

            if (audio == null) return NotFound();

            _context.Audio.Remove(audio);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
