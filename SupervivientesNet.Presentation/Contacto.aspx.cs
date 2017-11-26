using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Supervivientes.Business;
namespace SupervivientesNet.Presentation
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e) //Ingresa la información a la Database para ser consultado posteriormente por el Admin
        {
            if (Page.IsValid)
            {
                Supervivientes.Business.Contact co = new Supervivientes.Business.Contact()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Campus = ddlCampus.SelectedValue,
                    Comment = txtComment.Text
                };

                if (co.Create())
                {
                    Response.Redirect("ExitoSolicitud.aspx");
                }
                else
                {
                    Label1.Text = "Error al ingresar solicitud";
                }

            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args) //Valida que la longitud del nombre sea menor a 31
        {
            args.IsValid = args.Value.Length < 31;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args) //Valida que la longitud del mail sea menor a 31
        {
            args.IsValid = args.Value.Length < 31;
        }

        protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args) //Valida que la longitud del comentario sea menor a 301
        {
            args.IsValid = args.Value.Length < 301;
        }
    }
}