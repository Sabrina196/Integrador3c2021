using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MiPrimerProyecto.Models
{
    public class Nota  : EntityBase 
    {
        public string NotaExamen1 { get; set; }
        public string NotaRecuperatorio1 { get; set; }
        public string NotaExamen2 { get; set;}
        public string NotaRecuperatorio2 { get; set; }
        public int CantidadTrabajosPracticos { get; set; }
        public int CantidadTrabajosEntregados { get; set; }
     
        public int AlumnoID { get; set; }
        
        [ForeignKey("AlumnoID")]
        public Alumno Alumno { get; set; }
     
        public int CursoID { get; set; }
        
        [ForeignKey("CursoID")]
        public Curso Curso { get; set; }

    }
}