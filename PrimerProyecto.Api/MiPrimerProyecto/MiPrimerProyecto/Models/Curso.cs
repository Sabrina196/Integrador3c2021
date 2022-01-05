using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace MiPrimerProyecto.Models 
{
    public class Curso : EntityBase
    { 
        [Required]
        public string Comision { get; set;}
        [Required]
        public string Materia { get; set;}
        [Required]
        public string Dias { get; set;}
        [Required]
        public string Horario { get; set;}
        [Required]
        public string Colegio { get; set;}
        [Required]
        public int AñoLectivo { get; set;}

    }
}
