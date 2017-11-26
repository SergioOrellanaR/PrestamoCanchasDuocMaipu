using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Supervivientes.Business;
namespace SupervivientesNet.Presentation
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lblMensaje.Text = "";
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            int index = ddlEstadistica.SelectedIndex;
            Supervivientes.Business.Stats stats = new Supervivientes.Business.Stats();
            switch (index)
            {
                case 0:
                    lblMensaje.Text = "La infrastructura más usada es: " + stats.MostUsedFacility();
                    break;
                case 1:
                    lblMensaje.Text = "El Día con más solicitudes es: " + stats.MostUsedDay();
                    break;
                case 2:
                    lblMensaje.Text = "El bloque con más peticiones es: " + stats.MostUsedBlock();
                    break;

            }
        }
    }
}