using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class SearchModel : PageModel
    {
        private readonly AppDbContext _context;

        public SearchModel(AppDbContext context)
        {
            _context = context;
            eleAudio = context.Audio.ToList();
        }

        [BindProperty]
        public string cercato { get; set; }

        public List<Audio> eleAudio { get; set; }
    }
}
