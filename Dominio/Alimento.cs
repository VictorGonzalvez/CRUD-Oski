using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alimento : Articulo
    {
        //hereda nombre, descripcion, id, precio de compra, Activo
        public double Peso { get; set; }
        public float PrecioKg { get; set; }
        public float PrecioBolsa { get; set; }
        


    }
}
