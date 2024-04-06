using System.ComponentModel.DataAnnotations;

namespace L01P022021TH650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        public String? facultad {  get; set; }

    }
}
