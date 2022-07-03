﻿using Business;
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

        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        #region Producto

        [Route("api/ProductoService")]
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

        [Route("api/OrdenService")]
        [HttpPost]
        public IActionResult InsertOrden() 
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


    }
}