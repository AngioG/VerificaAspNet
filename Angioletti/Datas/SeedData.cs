using Microsoft.EntityFrameworkCore;
using Angioletti.Models;

namespace Angioletti.Datas
{
    public static class SeedData
    {
        public static void Initilize(AppDbContext context)
        {
            if (context.Audio.Any()) return;

            context.Audio.AddRange(
                new Audio
                {
                    Titolo = "What's my age again",
                    Artista = "blink-182",
                    Album = "What's my age again",
                    Publicazione = 1999,
                    Genere = "Rock",
                    Durata = 194
                },
                new Audio
                {
                    Titolo = "Woderwall",
                    Artista = "Oasis",
                    Album = "Oasis",
                    Publicazione = 1994,
                    Genere = "Rock",
                    Durata = 294
                },
                new Audio
                {
                    Titolo = "Don't cry my heart out",
                    Artista = "Oasis",
                    Album = "Oasis",
                    Publicazione = 1994,
                    Genere = "Rock",
                    Durata = 302
                },
                new Audio
                {
                    Titolo = "Godzilla",
                    Artista = "Eminem",
                    Album = "Music to be murdered by",
                    Publicazione = 2019,
                    Genere = "Rap",
                    Durata = 157
                },

                new Audio
                {
                    Titolo = "Bones",
                    Artista = "Imagine Dragons",
                    Album = "Bones",
                    Publicazione = 2022,
                    Genere = "Pop",
                    Durata = 138
                }
                );

            context.SaveChanges();
        }
    }
}
