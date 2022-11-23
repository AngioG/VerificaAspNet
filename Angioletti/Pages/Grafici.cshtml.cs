using Microsoft.EntityFrameworkCore;
using System.Web;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class GraficiModel : PageModel
    {
        private readonly AppDbContext _context;

        public GraficiModel(AppDbContext context)
        {
            _context = context;
            eleAudio = context.Audio.ToList();
        }

        [BindProperty]
        public int cercato { get; set; } = 0;

        public List<Audio> eleAudio { get; set; }
    }
}
