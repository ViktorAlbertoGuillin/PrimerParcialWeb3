using CalculadoraDeServiciosFreelanceRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeServiciosFreelanceRepositorio
{
    public class SeudoBaseDeDatos
    {
        public static List<DatosRegistro> resultados = new List<DatosRegistro>(0);   



        public static List<DatosRegistro> GetResultados()
        {
            return resultados;
        }
    }
}
