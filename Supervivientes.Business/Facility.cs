using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    class Infrastructure
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Infrastructure()
        {
            Id = 0;
            Name = "";
        }

        public Infrastructure(int i, string nom)
        {
            Id = i;
            Name = nom;
        }
        #endregion

        #region Methods
        public bool Read()
        {
            try
            {
                Data.infrastructure inf = Connection.AutomateDB.infrastructure.First(i => i.idinfrastructure == Id);
                Id = inf.idinfrastructure;
                Name = inf.name;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
