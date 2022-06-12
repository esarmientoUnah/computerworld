﻿using System;
using System.Collections.Generic;
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
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public  bool Activo { get; set; }

    }
}
