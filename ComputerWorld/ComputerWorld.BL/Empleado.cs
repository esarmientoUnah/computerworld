using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del empleado")]
        //[MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el slario del empleado")]
        //[MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public int Salario { get; set; }

        [Required(ErrorMessage = "Ingrese el codigo del empleado")]
        //[MinLength(8, ErrorMessage = "El codigo debe ser de 8 digitos")]
        //[MaxLength(8, ErrorMessage = "El codigo debe ser de 8 digitos")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Ingrese el cargo del empleado")]
        //[MinLength(3, ErrorMessage = "Ingrese el cargo del empleado")]
        public string Cargo { get; set; }
        public bool Activo { get; set; }
    }
}
