using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdTipo { get; set; }
        public int IdMarca { get; set; }
        public float PrecioCompra { get; set; }
        public int Activo { get; set; }


    }
}
