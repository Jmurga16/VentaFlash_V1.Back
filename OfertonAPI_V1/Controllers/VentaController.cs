using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfertonAPI_V1.Controllers
{

    [ApiController]
    public class VentaController : Controller
    {
        private readonly ProductoBusiness objProducto = new ProductoBusiness();
        private readonly OrdenBusiness objOrden = new OrdenBusiness();


        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        #region Producto

        [Route("api/Product")]
        [HttpGet]
        public IActionResult GetProducto()
        {

            try
            {
                var vRes = objProducto.LIS_ProductoBusiness();

                return Ok(vRes);
            }
            catch (Exception e)
            {

                logger.Error(e);
                throw;

            }

        }

        #endregion

        #region Orden

        [Route("api/Order")]
        [HttpPost]
        public IActionResult InsertOrden(OrdenEntity entity)
        {

            try
            {

                string sResultado = Convert.ToString(objOrden.BusinessOrden(entity));

                return Ok(sResultado);

            }
            catch (Exception e)
            {

                logger.Error(e);
                throw;

            }

        }

        #endregion


    }
}
