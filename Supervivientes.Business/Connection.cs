using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supervivientes.Data;

namespace Supervivientes.Business
{
    internal class Connection
    {
        #region Campos
        private static Automate_Entities _automateDB; //Conexión con la DataBase
        #endregion

        #region Properties
        public static Automate_Entities AutomateDB
        {
            get
            {
                if (_automateDB == null)
                    _automateDB = new Automate_Entities();
                return _automateDB;
            }
            set
            {
                _automateDB = value;
            }
        }
        #endregion


    }
}
