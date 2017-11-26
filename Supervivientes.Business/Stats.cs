using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    public class Stats
    {
        #region Methods
        public string MostUsedFacility() //Devuelve infraestructura mas utilizada
        {
            int i = 1;
            int max = 0;
            int id = 0;
            int limit = Connection.AutomateDB.petition.Max(idc => idc.infrastructure);
            while (i <= limit)
            {
                int mostSolicitedId = Connection.AutomateDB.petition.Count(idc => idc.infrastructure == i);
                if (mostSolicitedId > max)
                {
                    max = mostSolicitedId;
                    id = i;
                }
                i++;
            }
            return Connection.AutomateDB.infrastructure.First(nom => nom.idinfrastructure == id).name;
        }

        public string MostUsedDay() //Devuelve el día mas usado
        {
            int i = 1;
            int max = 0;
            int id = 0;
            int limit = Connection.AutomateDB.petition.Max(idc => idc.dayoftheweek);
            while (i <= limit)
            {
                int mostSolicitedId = Connection.AutomateDB.petition.Count(idc => idc.dayoftheweek == i);
                if (mostSolicitedId > max)
                {
                    max = mostSolicitedId;
                    id = i;
                }
                i++;
            }
            return Connection.AutomateDB.dayoftheweek.First(nom => nom.idday == id).name;
        }

        public string MostUsedBlock() //Devuelve el bloque más usado.
        {
            int i = 1;
            int max = 0;
            int id = 0;
            int limit = Connection.AutomateDB.petition.Max(idc => idc.block);
            while (i <= limit)
            {
                int mostSolicitedId = Connection.AutomateDB.petition.Count(idc => idc.block == i);
                if (mostSolicitedId > max)
                {
                    max = mostSolicitedId;
                    id = i;
                }
                i++;
            }
            return Connection.AutomateDB.block.First(nom => nom.idblock == id).name;
        }
        #endregion
    }
}
