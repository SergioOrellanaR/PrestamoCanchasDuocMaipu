using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    class Day
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Day()
        {
            Id = 0;
            Name = "";
        }

        public Day(int i, string nam)
        {
            Id = i;
            Name = nam;
        }
        #endregion

        #region Methods
        public bool Read()
        {
            try
            {
                Data.dayoftheweek dofw = Connection.AutomateDB.dayoftheweek.First(dow => dow.idday == Id);
                Id = dofw.idday;
                Name = dofw.name;
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
