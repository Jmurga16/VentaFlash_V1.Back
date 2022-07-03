using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductoBusiness
    {
        private readonly ProductoData productoData = new ProductoData();

        public List<ProductoEntity> LIS_ProductoBusiness()
        {
            return productoData.LIS_ProductoData();
        }
    }
}
