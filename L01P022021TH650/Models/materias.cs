using System.ComponentModel.DataAnnotations;

namespace L01P022021TH650.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }
        public String materia { get; set; }

        [Display(Name = "Unidades valorativas")]
        public int unidades_valorativas { get; set; }
        public String estado { get; set; }

    }
}
