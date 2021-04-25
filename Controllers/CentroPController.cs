using System.Collections.Generic;
using System.Linq;
using gimnasio_pokemon.Data;
using gimnasio_pokemon.Models;
using Microsoft.AspNetCore.Mvc;

namespace gimnasio_pokemon.Controllers
{
    public class CentroPController : Controller
    {
        private CentrosContext _context;
        public CentroPController(CentrosContext context)
        {
            _context = context ;
        }
        public IActionResult Nuevo() {
            
            return View();
        }

        

        [HttpPost]

        public IActionResult Nuevo(Centro c ) {
            
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();

                return RedirectToAction("Lista");

            }
            return View(c);
        }

        public IActionResult Lista(){
            var centro = _context.Centros.OrderBy(p => p.nombreCiudad).ToList();
            return View(centro);
        }

    }
}