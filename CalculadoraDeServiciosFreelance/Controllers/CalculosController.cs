using CalculadoraDeServiciosFreelanceRepositorio.Entidades;
using CalculadoraDeServiciosFreelanceServicio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraDeServiciosFreelanceWeb.Controllers
{
    public class CalculosController : Controller
    {
        readonly IServicio _servicio;
        public CalculosController(IServicio servicio)
        {
            _servicio = servicio;
        }

        public IActionResult Inicio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(DatosRegistro datos)
        {
            DatosRegistro registro = new DatosRegistro();
            registro.NombrePersona = datos.NombrePersona;
            registro.ValorHora = datos.ValorHora;
            registro.HorasTrabajadas = datos.HorasTrabajadas;
            registro.Resultado = _servicio.Calcular(datos);
            _servicio.guardarRegistro(registro);
            return View(registro);
        }

        public IActionResult Listar()
        {
            List<DatosRegistro> lista = _servicio.Listar();
            return View(lista);
        }
    }
}
