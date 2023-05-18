using CalculadoraDeServiciosFreelanceRepositorio.Entidades;
using CalculadoraDeServiciosFreelanceRepositorio.Interfaces;
using CalculadoraDeServiciosFreelanceServicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeServiciosFreelanceServicio
{
    public class Servicio : IServicio
    {
        readonly IRepositorio _repositorio;
        public Servicio(IRepositorio repositorio)    
        {
            _repositorio = repositorio;
        }
        public float Calcular(DatosRegistro datos)
        {
            return datos.HorasTrabajadas * datos.ValorHora;
        }

        public void guardarRegistro(DatosRegistro datos)
        {
            _repositorio.Guardar(datos);
        }

        public List<DatosRegistro> Listar()
        {
            return _repositorio.Listar();
        }
        
    }
}
