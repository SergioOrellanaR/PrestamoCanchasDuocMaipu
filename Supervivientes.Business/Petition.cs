using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    public class Petition
    {
        #region Properties
        public int Id { get; set; }
        public int Day { get; set; }
        public int Block { get; set; }
        public string Username { get; set; }
        public int Facilty { get; set; }
        #endregion

        #region Constructor
        public Petition()
        {
            Id = 0;
            Day = 0;
            Block = 0;
            Username = "";
            Facilty = 0;
        }

        public Petition(int i, int day, int block, string user, int inf)
        {
            Id = i;
            Day = day;
            Block = block;
            Username = user;
            Facilty = inf;
        }
        #endregion

        #region Methods
        public bool Create()
        {
            try
            {
                Data.petition res = new Data.petition();
                res.idpetition = LastId() + 1;
                res.dayoftheweek = Day;
                res.block = Block;
                res.account = Username;
                res.infrastructure = Facilty;
                Connection.AutomateDB.petition.Add(res);
                Connection.AutomateDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Data.petition res = Connection.AutomateDB.petition.First(re => re.idpetition == Id);
                Id = res.idpetition;
                Day = res.dayoftheweek;
                Block = res.block;
                Username = res.account;
                Facilty = res.infrastructure;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Data.petition res = Connection.AutomateDB.petition.First(re => re.idpetition == Id);
                res.dayoftheweek = Day;
                res.block = Block;
                res.account = Username;
                res.infrastructure = Facilty;
                Connection.AutomateDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Data.petition res = Connection.AutomateDB.petition.First(re => re.dayoftheweek == Day && re.block == Block && re.infrastructure == Facilty && re.account == Username);
                Connection.AutomateDB.petition.Remove(res);
                Connection.AutomateDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int LastId() //Obtiene el ultimo ID
        {
            try
            {
                return Connection.AutomateDB.petition.Max(re => re.idpetition);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool IsThereAPetition() //Devuelve true si ya existe una petición donde se quiere ingresar, false si no.
        {
            try
            {
                Data.petition res = Connection.AutomateDB.petition.First(re => re.dayoftheweek == Day && re.block == Block && re.infrastructure == Facilty);
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
