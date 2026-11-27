using System.ComponentModel.DataAnnotations;
namespace Omnitrix.API.Models
{    public class Alien
    { public int Id { get; set; }
        [Required]
      public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Especie { get; set; } = string.Empty;
        [Required]
        public string Planeta { get; set; } = string.Empty;
        [Required]
        public string Poder { get; set; } = string.Empty;
        [Range(0, 100)]
        public int Velocidad { get; set; }
        [Range(0, 100)]
        public int Fuerza { get; set; }
        public bool Disponible { get; set; } = true;
    }
}
