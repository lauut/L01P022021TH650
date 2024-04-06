using System.ComponentModel.DataAnnotations;

namespace L01P022021TH650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }
        public String departamento { get; set; }

    }
}
