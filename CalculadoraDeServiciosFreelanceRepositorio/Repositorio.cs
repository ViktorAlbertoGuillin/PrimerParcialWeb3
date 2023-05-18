using CalculadoraDeServiciosFreelanceRepositorio.Entidades;
using CalculadoraDeServiciosFreelanceRepositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeServiciosFreelanceRepositorio
{
    public class Repositorio : IRepositorio
    {
        private int ObtenerUltimoId()
        {
            if (SeudoBaseDeDatos.GetResultados().Count() == 0)
            {
                return 0;
            }
            else
            {
                int ultimo = SeudoBaseDeDatos.GetResultados().LastOrDefault().Id;
                return ultimo;
            }
        }

        public void Guardar(DatosRegistro datos)
        {
            int? idUltimo = ObtenerUltimoId();
            idUltimo++;
            datos.Id = (int)idUltimo;
            SeudoBaseDeDatos.GetResultados().Add(datos);
        }

        public List<DatosRegistro> Listar()
        {
            return SeudoBaseDeDatos.GetResultados();
        }
    }
}
