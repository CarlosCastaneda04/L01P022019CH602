using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022019CH602.Models
{
    public class alumnos
    {
        [Key]
        [DisplayName("Id de Alumno")]
        public int id { get; set; }
        [DisplayName("Codigo")]
        public string? codigo { get; set; }
        [DisplayName("Nombre")]
        public string? nombre { get; set; }
        [DisplayName("Apellidos")]
        public string? apellidos { get; set; }
        [DisplayName("DUI")]
        [Required(ErrorMessage ="El numero de dui NO es opcional!")]
        public int dui  { get; set; }
        [DisplayName("Estado")]
        [Required(ErrorMessage ="Solo se aceptan datos numericos")]
        public int estado { get; set; }

    }
}
