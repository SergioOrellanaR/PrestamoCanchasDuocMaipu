using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Supervivientes.Services
{

    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el name de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        CompositeType Authenticate(string user, string pass);

        // TODO: agregue aquí sus operaciones de service
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de service.
    [DataContract]
    public class CompositeType
    {
        bool _authenticated = true;
        string _name = "";

        [DataMember]
        public bool Authenticated
        {
            get { return _authenticated; }
            set { _authenticated = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
