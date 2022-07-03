using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoEntity
    {
        public int nIdProducto { get; set; }
        public string sNombreProducto { get; set; }
        public string sDescripcion { get; set; }
        public decimal nCalificacion { get; set; }
        public decimal nPrecio { get; set; }
        public int nStock { get; set; }
        public string sRutaImagen { get; set; }


    }
}
