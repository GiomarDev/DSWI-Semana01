using S01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S01.Controllers
{
    public class LibroController : Controller
    {
        static List<Libro> misLibros = new List<Libro>();
        static int n;


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult registrarLibro() 
        {
            n++;
            ViewBag.n = n;
            return View();

        }

        [HttpPost]
        public ActionResult registrarLibro(Libro obj)
        {

            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            misLibros.Add(obj);
            return RedirectToAction("listadoLibros");

        }

        public ActionResult listadoLibros()
        {

            ViewData["Lista"] = misLibros.ToList();
            return View();

        }

        public ActionResult detalleLibro(int? id)
        {

            Libro objL = misLibros.Where(e => e.codigo == id).FirstOrDefault();
            return View(objL);

        }

        public ActionResult modificaLibro(int? id)
        {

            Libro objL = misLibros.Where(e => e.codigo == id).FirstOrDefault();
            return View(objL);

        }

        [HttpPost]
        public ActionResult modificaLibro(Libro objL)
        {

            if (!ModelState.IsValid)
            {
                return View(objL);
            }
            var unLibro = misLibros.Where(e => e.codigo == objL.codigo).FirstOrDefault();
            unLibro.titulo = objL.titulo;
            unLibro.autor = objL.autor;
            unLibro.paginas = objL.paginas;
            unLibro.area = objL.area;

            return RedirectToAction("listadoLibros");

        }

        public ActionResult eliminaLibro(int? id)
        {

            Libro objL = misLibros.Where(e => e.codigo == id).FirstOrDefault();
            misLibros.Remove(objL);
            return View(objL);

        }

        [HttpPost]
        public ActionResult eliminaLibro(Libro lib)
        {
           
           Libro obj  = misLibros.Where(e => e.codigo == lib.codigo).FirstOrDefault();
            misLibros.Remove(lib);
          
            return RedirectToAction("listadoLibros");

        }

    }
}