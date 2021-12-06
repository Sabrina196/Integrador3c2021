using Microsoft.AspNetCore.Mvc;
using MiPrimerProyecto.Data;
using MiPrimerProyecto.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimerProyecto.Controllers
{       
    public class NotasController: Controller 
    {
        //***Contexto y Constructor***
        private ApplicationDbContext _context;
        public NotasController(ApplicationDbContext context)
        {
           _context = context;
        }
        //***Vista Principal de Notas
        public IActionResult IndexN(int id)
        {
            Nota nota1 = new Nota();
            nota1.NotaExamen1 = "0";
            nota1.NotaRecuperatorio1 = "-";
            nota1.NotaExamen2 = "0";

            nota1.CursoID = id;

            _context.Notas.Add(nota1);

            return View(_context.Notas.ToList());
           
        }


        

        
    }
}    