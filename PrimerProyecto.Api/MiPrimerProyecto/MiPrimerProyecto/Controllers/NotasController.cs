using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiPrimerProyecto.Data;
using MiPrimerProyecto.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiPrimerProyecto.Controllers
{    public class NotasController : Controller
    {
        //***Contexto y Constructor***
        private ApplicationDbContext _context;
        public NotasController(ApplicationDbContext context)
        {
           _context = context;
        }

        /*** Vista que devuelve la Lista de Notas para modificar***/
        public IActionResult indexN()
        {
          
            return View(_context.Notas.ToList());
        }

        /***Formulario para crear la tabla de Notas que une el curso con el Alumno***/
        public IActionResult CrearN(int id)
        {
            ViewBag.CursoList = _context.Cursos.ToList();

            /*Id del Alumno que tomo de la URL*/
            ViewBag.AlumnoId = id;

            return View();
        }

        /***Metodo que crea un nuevo Registro de Nota con los ID de Curso y Nota***/
        public async Task<IActionResult> GuardarNAsync(int alumnoid, int cursoID)
        {
            Nota nuevo =  new Nota() 
            {
                AlumnoID = alumnoid,
                CursoID = cursoID,
                NotaExamen1 = "-",
                NotaRecuperatorio1="-",
                NotaExamen2 = "-",
                NotaRecuperatorio2 = "-",
                CantidadTrabajosPracticos = 0,
                CantidadTrabajosEntregados = 0,


            };

            _context.Notas.Add(nuevo);
            //Método que lo guarda en BD
            _context.SaveChanges();

            return RedirectToAction("indexN");
        }

         //***Formulario para Modificar un Registro***
        public IActionResult modificarN(int id)
        {
            Nota modificar = Buscar(id);
            if (modificar == null)
            {
                return RedirectToAction("IndexN");
            }
            return View(modificar); 
        }

        //***Método Actualizar que toma los parametros del <Form>"Modificar" para
        // guardarlos en el registro que se modificó ***
        public IActionResult actualizar(int id, string nota1, string recu1, string nota2, string recu2, int ctp, int tpe)
        {
            Nota modificar  = Buscar(id);
            if (modificar != null)
            {
                modificar.NotaExamen1 = nota1;
                modificar.NotaRecuperatorio1= recu1;
                modificar.NotaExamen2 = nota2;
                modificar.NotaRecuperatorio2= recu2;
                modificar.CantidadTrabajosPracticos = ctp;
                modificar.CantidadTrabajosEntregados = tpe;
                _context.Notas.Update(modificar);
                _context.SaveChanges();
            }
            return RedirectToAction("IndexN");
        }

        //***Método que elimina un Registro de tabla Cursos***
        public IActionResult Eliminar(int id)
        {
            Nota eliminar = Buscar(id);
            if (eliminar == null)
            {
                return StatusCode(404);
            }

            _context.Notas.Remove(eliminar);
            _context.SaveChanges();

            return RedirectToAction("indexN");
        }

        //***Método que buscar por ID cada registro que se quiere Modificar o Eliminar***
        private Nota Buscar(int id)
        {

            Nota find = _context.Notas.Find(id);

            return find;
        }
    }
    
}