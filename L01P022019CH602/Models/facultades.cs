using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022019CH602.Models
{
    public class facultades
    {
        [Key]
        [DisplayName("Id de facultad")]
        public int id { get; set; }
        [DisplayName("Facultad")]
        public string? facultad { get; set; }
    }
}
