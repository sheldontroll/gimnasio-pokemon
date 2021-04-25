using System.Collections.Generic;
using gimnasio_pokemon.Models;
using Microsoft.AspNetCore.Mvc;

namespace gimnasio_pokemon.Controllers
{
    public class CentroPController : Controller
    {
        public IActionResult Nuevo() {
            
            return View();
        }

        

        [HttpPost]

        public IActionResult Nuevo(Centro c ) {
            
            if(ModelState.IsValid){
                return RedirectToAction("Lista");

            }
            return View(c);
        }

        public IActionResult Lista(){
            var centros = new List<Centro>();
            return View(centros);
        }

    }
}