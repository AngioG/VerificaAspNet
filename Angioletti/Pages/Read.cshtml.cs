using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class ReadModel : PageModel
    {
        private readonly AppDbContext _context;

        public ReadModel(AppDbContext context)
        {
            _context = context;
            eleAudio = context.Audio.ToList();
        }

        public List<Audio> eleAudio { get; set; }
    }
}
