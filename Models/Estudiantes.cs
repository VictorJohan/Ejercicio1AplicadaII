using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio1AplicadaII.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir el nombre.")]
        public string Nombres { get; set; }

        [Range(minimum:1, maximum:10, ErrorMessage = "Seleccione un pensum")]
        public int Semestre { get; set; }

        public string NacionalidadId { get; set; }

        [ForeignKey("NacionalidadId")]
        public virtual Nacionalidades Nacionallida { get; set; }
    
    }
}


