using System.ComponentModel.DataAnnotations;

namespace L01P022021TH650.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int dui {  get; set; }
        public int estado {  get; set; }
    }
}
