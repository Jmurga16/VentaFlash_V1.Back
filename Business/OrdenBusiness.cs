using Data;
using Entity;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrdenBusiness
    {
        private readonly OrdenData ordenData = new OrdenData();
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public object BusinessOrden(OrdenEntity entity)
        {
            try
            {

                return ordenData.DataOrden(entity);

            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;

            }
        }
    }
}
