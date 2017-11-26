using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    public class Collection
    {
        #region Methods
        public string[,] GetSchedule(int idFacilty) //Valor entre 1 y 4, devuelve el horario en forma de arreglo.
        {
            string[,] output = new string[15, 6];
            foreach (Data.petition element in Connection.AutomateDB.petition)
            {
                int block = element.block - 1;
                int day = element.dayoftheweek - 1;
                if (element.infrastructure == idFacilty)
                {
                    output[block, day] = element.account;
                }
            }
            return output;
        }
        #endregion
    }
}
