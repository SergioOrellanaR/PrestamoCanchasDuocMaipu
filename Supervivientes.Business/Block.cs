using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    class Block
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Block()
        {
            Id = 0;
            Name = "";
        }

        public Block(int i, string nam)
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
                Data.block bl = Connection.AutomateDB.block.First(blo => blo.idblock == Id);
                Id = bl.idblock;
                Name = bl.name;
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
