using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivientes.Business
{
    public class Contact
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Campus { get; set; }
        public string Comment { get; set; }
        #endregion

        #region Constructor
        public Contact(int id, string name, string email, string campus, string comment)
        {
            Id = id;
            Name = name;
            Email = email;
            Campus = campus;
            Comment = comment;
        }
        public Contact()
        {
            Id = 0;
            Name = "";
            Email = "";
            Campus = "";
            Comment = "";
        }
        #endregion

        #region Methods
        public bool Create()
        {
            try
            {
                Data.contact co = new Data.contact();
                co.idContact = LastId() + 1;
                co.name = Name;
                co.email = Email;
                co.campus = Campus;
                co.comment = Comment;
                Connection.AutomateDB.contact.Add(co);
                Connection.AutomateDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int LastId() //Obtiene el último Id en la DataBase
        {
            try
            {
                return Connection.AutomateDB.contact.Max(re => re.idContact);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion
    }
}
