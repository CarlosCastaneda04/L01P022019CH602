using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022019CH602.Models
{
    public class materias
    {
        [Key]
        [DisplayName("Id de Materia")]
        public int id { get; set; }
        [DisplayName("Materia")]
        public string? materia { get; set; }
        [DisplayName("Unidades Valorativas")]
        public int unidades_valorativas { get; set; }
        [DisplayName("Estado")]
        [StringLength(1, ErrorMessage ="La cantidad maxima de caracteres valida es {1}")]
        public char estado { get; set; }
    }
}
