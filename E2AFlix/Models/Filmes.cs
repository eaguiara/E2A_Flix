using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;

namespace E2AFlix.Models
{
    [Table("Filmes")]
    public class Filmes
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

        [Column("Titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Column("JaAssistiu")]
        [Display(Name = "JaAssistiu")]
        public bool JaAssistiu { get; set; }

        [Column("FotoFilme")]
        [Display(Name = "FotoFilme")]
        public ImageFileMachine FotoFilme { get; set; }

        [Column("Produtora")]
        [Display(Name = "Produtora")]
        public string Produtora { get; set; }

        [Column("Diretora")]
        [Display(Name = "Diretora")]
        public string Diretora { get; set; }
    }
}
