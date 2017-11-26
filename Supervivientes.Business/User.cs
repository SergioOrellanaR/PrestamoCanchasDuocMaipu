using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    public class User
    {
        #region Properties
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion

        #region Constructor
        public User()
        {
            Username = "";
            Password = "";
        }

        public User(string user, string pass)
        {
            Username = user;
            Password = pass;
        }
        #endregion

        #region Methods
        public bool Read()
        {
            try
            {
                Data.account cuenta = Connection.AutomateDB.account.First(user => user.username == Username);
                Username = cuenta.username;
                Password = cuenta.password;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Authenticate() //Autentica la sesión, es referenciado por Services
        {
            try
            {
                Data.account cuenta = Connection.AutomateDB.account.First(user => user.username == Username && user.password == Password);
                Username = cuenta.username;
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
