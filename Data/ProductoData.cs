using Entity;
using Microsoft.Extensions.Configuration;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductoData
    {

        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        #region Conexion
        private readonly Conexion oCon;

        public ProductoData()
        {
            oCon = new Conexion(1);
        }
        #endregion

        //Obtener Todos los productos
        public List<ProductoEntity> LIS_ProductoData()
        {

            List<ProductoEntity> lstProductos = new List<ProductoEntity>();

            try
            {

                using (IDataReader dr = oCon.ejecutarDataReaderWithOutArg("USP_GET_Producto"))
                {

                    while (dr.Read())
                    {
                        ProductoEntity entity = new ProductoEntity();

                        entity.nIdProducto = Int32.Parse(Convert.ToString(dr["nIdProducto"]));

                        entity.sNombreProducto = Convert.ToString(dr["sNombreProducto"]);
                        entity.sDescripcion = Convert.ToString(dr["sDescripcion"]);
                        entity.nCalificacion = Decimal.Parse(Convert.ToString(dr["nCalificacion"]));
                        entity.nPrecio = Decimal.Parse(Convert.ToString(dr["nPrecio"]));
                        entity.nStock = Int32.Parse(Convert.ToString(dr["nStock"]));
                        entity.sRutaImagen = Convert.ToString(dr["sRutaImagen"]);

                        lstProductos.Add(entity);

                    }

                    return lstProductos;

                }
                               
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }

        }
    }
}
