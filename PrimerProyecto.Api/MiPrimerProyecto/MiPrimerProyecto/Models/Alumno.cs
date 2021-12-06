using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MiPrimerProyecto.Models;


namespace MiPrimerProyecto.Models {
    public class Alumno : EntityBase
    {
        [Required(ErrorMessage ="Debe llenar el Campo Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Debe llenar el Campo Apellido")]
        public string Apellido { get; set; }
        
    }   
}
