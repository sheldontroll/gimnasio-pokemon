using Microsoft.AspNetCore.Mvc;

namespace gimnasio_pokemon.Controllers
{
    public class CentroPController : Controller
    {
        public IActionResult Nuevo() {
            
            return View();
        }
    }
}