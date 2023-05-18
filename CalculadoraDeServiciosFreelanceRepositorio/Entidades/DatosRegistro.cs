using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeServiciosFreelanceRepositorio.Entidades
{
    public class DatosRegistro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El ingreso del nombre es obligatorio")]
        public string NombrePersona { get; set; }

        [Required(ErrorMessage = "El ingreso del valor de la hora es obligatorio")]
        [Range(1001, 9999, ErrorMessage = "dicho valor debe ser un valor entero entre 1001 y 9999")]
        public int ValorHora { get; set; }

        [Required(ErrorMessage = "El ingreso de las horas trabajadas es obligatorio")]
        [Range(1, 160, ErrorMessage = "la cantidad de horas trabajadas deben ser un valor entero entre 1 y 160")]
        public int HorasTrabajadas { get; set; }    
        public float Resultado { get; set; }
    }
}
