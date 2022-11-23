using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Angioletti.Pages
{
    public class AlbumModel : PageModel
    {
        private readonly AppDbContext _context;

        public AlbumModel(AppDbContext context)
        {
            _context = context;
            eleAudio = context.Audio.ToList();

            foreach(var a in eleAudio)
            {
                if (!eleAlbum.Contains(a.Album))
                    eleAlbum.Add(a.Album);
            }
        }

        [BindProperty]
        public string cercato { get; set; } = "Tutti";

        public List<string> eleAlbum { get; set; } = new List<string>();

        public List<Audio> eleAudio { get; set; }
    }
}
