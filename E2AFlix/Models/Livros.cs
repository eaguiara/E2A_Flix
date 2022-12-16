using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;

namespace E2AFlix.Models
{
    [Table("Livros")]
    public class Livros
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [Column("Nota")]
        [Display(Name = "Nota")]
        public int Nota { get; set; }

        [Column("FotoLivro")]
        [Display(Name = "FotoLivro")]
        public ImageFileMachine FotoLivro { get; set; }
    }
}
