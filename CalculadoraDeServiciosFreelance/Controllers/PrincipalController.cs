using Microsoft.AspNetCore.Mvc;

namespace CalculadoraDeServiciosFreelanceWeb.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult BienvenidosArtificiales()
        {
            return View();
        }
    }
}
