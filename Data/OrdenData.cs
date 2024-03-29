﻿using Entity;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrdenData
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        #region Conexion a la BBDD
        private readonly Conexion oCon;
        public OrdenData()
        {
            oCon = new Conexion(1);
        }
        #endregion

        //Comprar el Producto en Venta
        public object DataOrden(OrdenEntity entity)
        {
            string msj = string.Empty;

            try
            {
                //Ejecutar el Store Procedure de la Orden
                string sResultado = Convert.ToString(oCon.EjecutarEscalar("USP_MNT_Orden", 
                    entity.nIdProducto, entity.sNombre, entity.sCorreo, entity.sDireccion));

                msj = sResultado;
            }
            catch (Exception ex)
            {
                msj = ex.Message;
            }
            return msj;
        }
                  
    }
}
