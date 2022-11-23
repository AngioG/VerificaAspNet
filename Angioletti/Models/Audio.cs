using System.ComponentModel.DataAnnotations;

namespace Angioletti.Models
{
    public class Audio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titolo { get; set; }

        [Required]
        public string Album { get; set; }

        [Required]
        public string Artista { get; set; }

        [Required, maxLastYear]
        public int Publicazione { get; set; }

        [Required, RegularExpression("^(Classica)|(Dance)|(Pop)|(Rap)|(Raggae)|(Rock)$")]
        public string Genere { get; set; }

        [Required]
        public int Durata { get; set; }
    }
}
