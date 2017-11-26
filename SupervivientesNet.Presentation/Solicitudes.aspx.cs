using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Supervivientes.Business;
namespace SupervivientesNet.Presentation
{
    public partial class Solicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSend_Click(object sender, EventArgs e) //Ingresa una petición, solo si esta se encuentra disponible.
        {
            Petition petition = Indexation();

            if (!petition.IsThereAPetition())
            {
                petition.Create();
                /*switch(petition.Facilty)
                {
                    case 1:
                        Response.Redirect("Horario Futbolito.aspx");
                        break;
                    case 2:
                        Response.Redirect("Horario Gimnasio.aspx");
                        break;
                    case 3:
                        Response.Redirect("Horario Multicancha.aspx");
                        break;
                    case 4:
                        Response.Redirect("Horario Otros.aspx");
                        break;
                }*/
                lblMessage.Text = "Solicitud ingresada con éxito";
            }
            else
            {
                lblMessage.Text = "Verifique que exista disponibilidad horaria";
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e) //Elimina una petición solo si es el mismo que la ingresó
        {
            bool success;
            Petition petition = Indexation();
            success = petition.Delete();
            if (success == false)
                lblMessage.Text = "No se pudo eliminar, verifique que la solicitud le pertenezca y exista";
            else
                lblMessage.Text = "Solicitud eliminada";

        }

        /*Indexation() devuelve una petición sin incosistencia de selected Index con tabla de Database (Selected Index es Array
        Que parte de 0, mientras que en la Database parte de 1).*/
        protected Petition Indexation()
        {
            int day = ddlDay.SelectedIndex + 1;
            int block = ddlBlock.SelectedIndex + 1;
            int facility = ddlFacility.SelectedIndex + 1;
            Petition petition = new Petition()
            {
                Day = day,
                Block = block,
                Facilty = facility,
                Username = Page.User.Identity.Name
            };
            return petition;
        }
    }
}