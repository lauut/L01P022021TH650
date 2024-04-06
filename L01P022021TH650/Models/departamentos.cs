using System.ComponentModel.DataAnnotations;

namespace L01P022021TH650.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        public string? departamento { get; set; }

    }
}
