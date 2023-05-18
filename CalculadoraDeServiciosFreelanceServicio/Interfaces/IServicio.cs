using CalculadoraDeServiciosFreelanceRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeServiciosFreelanceServicio.Interfaces
{
    public interface IServicio
    {
        float Calcular(DatosRegistro datos);
        void guardarRegistro(DatosRegistro datos);
        List<DatosRegistro> Listar();
    }
}
