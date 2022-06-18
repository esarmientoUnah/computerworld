using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la descripcion")]
        [MinLength (3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(0, 100000,ErrorMessage = "Ingrese un precio entre 0 y 100000")]
        public int Precio { get; set; }


        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public  bool Activo { get; set; }

    }
}
