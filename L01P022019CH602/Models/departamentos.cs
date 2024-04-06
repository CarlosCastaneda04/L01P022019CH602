using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022019CH602.Models
{
    public class departamentos
    {
        [Key]
        [DisplayName("ID de Departamento")]
        public int id { get; set; }
        [DisplayName("Departamento")]
        [Required(ErrorMessage = "El departamento NO es Opcional!")]
        public string? departamento { get; set; }
    }
}
