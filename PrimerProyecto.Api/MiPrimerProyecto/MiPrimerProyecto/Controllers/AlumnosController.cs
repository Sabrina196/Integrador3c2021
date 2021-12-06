using Microsoft.AspNetCore.Mvc;
using MiPrimerProyecto.Data;
using MiPrimerProyecto.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimerProyecto.Controllers
{       
    public class AlumnosController: Controller 
    {
        //***Contexto y Constructor***
        private ApplicationDbContext _context;
        public AlumnosController(ApplicationDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    //***Formulario de crear Nuevo Alumno***
    public IActionResult crearA()
    {
        return View();
    }

    //***Método para guardar registros de Tabla Alumnos***
    [HttpPost]
    public IActionResult guardarA(string nombre, string apellido)
        {
            Alumno nuevoalumno = new Alumno();
            nuevoalumno.Nombre = nombre;
            nuevoalumno.Apellido = apellido;
 

            _context.Alumnos.Add(nuevoalumno);
            //Método que lo guarda en la BD
            _context.SaveChanges();
        
            return RedirectToAction ("listaAlumnos");
        }

        //***Vista de las lista de Alumnos***
        public IActionResult listaAlumnos()
        {
            return View(_context.Alumnos.ToList());
        }

        //***Formulario para Modificar un Registro de Alumnos***
        public IActionResult modificarA(int id)
        {
            Alumno AlumnoModificar = _context.Alumnos.Find(id);
            if (AlumnoModificar == null)
            {
                return RedirectToAction("Index");
            }                
            return View(AlumnoModificar); 
        }
         //***Método Actualizar que toma los parametros del <Form>"Modificar" para
        // guardarlos en el registro que se modificó ***
        public IActionResult actualizarA(int id, string nom, string ape)
        {
            Alumno AlumnoModificar = Buscar(id);
            if (AlumnoModificar != null)
            {
                AlumnoModificar.Nombre = nom;
                AlumnoModificar.Apellido = ape;
                _context.Alumnos.Update(AlumnoModificar);
                _context.SaveChanges();
            }
            return RedirectToAction("listaAlumnos");
        }

        //***Método que elimina un Registro de tabla Cursos***
        public IActionResult EliminarA(int id)
        {
            Alumno AlumnoEliminar = Buscar(id);
            if (AlumnoEliminar == null)
            {
                return StatusCode(404);
            }

            _context.Alumnos.Remove(AlumnoEliminar);
            _context.SaveChanges();

            return RedirectToAction("listaAlumnos");
        }

        //***Método que buscar por ID cada registro que se quiere Modificar o Eliminar***
        //El Método puede reemplazarse por Expresión => var (la clase, como ej:Alumno) = _context.Cursos.Find(id))
        private Alumno Buscar(int id)
        {

            Alumno find = _context.Alumnos.Find(id);

            return find;
        }

       
    }
    
    
}