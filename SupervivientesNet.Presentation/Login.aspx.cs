using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Supervivientes.Business;
namespace SupervivientesNet.Presentation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LgnLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            ServiceReference.UsersClient service = new ServiceReference.UsersClient();
            if (service.Authenticate(LgnLogin.UserName, LgnLogin.Password).Authenticated)
            {

                FormsAuthentication.RedirectFromLoginPage(service.Authenticate(LgnLogin.UserName, LgnLogin.Password).Name, true);
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}