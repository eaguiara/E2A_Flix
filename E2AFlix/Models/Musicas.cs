using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;


namespace E2AFlix.Models
{
    [Table("Musicas")]
    public class Musicas
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Artista")]
        [Display(Name = "Artista")]
        public string Artista { get; set; }

        [Column("Nota")]
        [Display(Name = "Nota")]
        public int Nota { get; set; }

        [Column("FotoMusica")]
        [Display(Name = "FotoMusica")]
        public ImageFileMachine FotoMusica { get; set; }
    }
}
