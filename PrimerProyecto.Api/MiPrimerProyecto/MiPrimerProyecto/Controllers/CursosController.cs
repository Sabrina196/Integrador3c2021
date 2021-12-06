using Microsoft.AspNetCore.Mvc;
using MiPrimerProyecto.Data;
using MiPrimerProyecto.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimerProyecto.Controllers
{       
    public class CursosController: Controller 
    {
        //***Contexto y Constructor***
        private ApplicationDbContext _context;
        public CursosController(ApplicationDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    //***Formulario de crear Nuevo Curso***
    public IActionResult crearC()
    {
        return View();
    }

    //***Método para guardar registros de Tabla Curso***
    [HttpPost]
    public IActionResult guardarC(string comision, string materia, string dias, string horario, string colegio, int añoLectivo)
        {
            Curso nuevocurso = new Curso();
            nuevocurso.Comision = comision;
            nuevocurso.Materia = materia;
            nuevocurso.Dias = dias;
            nuevocurso.Horario = horario;
            nuevocurso.Colegio = colegio;
            nuevocurso.AñoLectivo = añoLectivo;

            _context.Cursos.Add(nuevocurso);
            //Método que lo guarda en la BD
            _context.SaveChanges();
        
            return RedirectToAction ("listaCursos");
        }


        //***Vista de las lista de Cursos***
        public IActionResult listaCursos()
        {
            return View(_context.Cursos.ToList());
        }


        //***Formulario para Modificar un Registro***
        public IActionResult modificar(int id)
        {
            Curso modificar = Buscar(id);
            if (modificar == null)
            {
                return RedirectToAction("Index");
            }
            return View(modificar); 
        }

        //***Método Actualizar que toma los parametros del <Form>"Modificar" para
        // guardarlos en el registro que se modificó ***
        public IActionResult actualizar(int id, string comi, string mat, string di, string hs, string cole, int aL)
        {
            Curso modificar  = Buscar(id);
            if (modificar != null)
            {
                modificar.Comision = comi;
                modificar.Materia = mat;
                modificar.Dias = di;
                modificar.Horario = hs;
                modificar.Colegio = cole;
                modificar.AñoLectivo = aL;
                _context.Cursos.Update(modificar);
                _context.SaveChanges();
            }
            return RedirectToAction("listaCursos");
        }

        //***Método que elimina un Registro de tabla Cursos***
        public IActionResult Eliminar(int id)
        {
            Curso eliminar = Buscar(id);
            if (eliminar == null)
            {
                return StatusCode(404);
            }

            _context.Cursos.Remove(eliminar);
            _context.SaveChanges();

            return RedirectToAction("listaCursos");
        }

        //***Método que buscar por ID cada registro que se quiere Modificar o Eliminar***
        //El Método puede reemplazarse por Expresión => var (la clase, como ej:Curso) = _context.Cursos.Find(id))
        private Curso Buscar(int id)
        {

            Curso find = _context.Cursos.Find(id);

            return find;
        }
    }
    
    
}
