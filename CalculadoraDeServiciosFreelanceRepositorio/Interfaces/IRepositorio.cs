using CalculadoraDeServiciosFreelanceRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeServiciosFreelanceRepositorio.Interfaces
{
    public interface IRepositorio
    {
        void Guardar(DatosRegistro datos);
        List<DatosRegistro> Listar();

    }
}
