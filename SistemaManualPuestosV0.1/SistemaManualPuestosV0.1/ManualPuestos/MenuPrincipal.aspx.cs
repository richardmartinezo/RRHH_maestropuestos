using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaManualPuestosV0._1.ManualPuestos
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxButtonMaestroPuestos_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ManualPuestos/MaestroPuestos.aspx");
        }

        protected void ASPxButtonUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ManualPuestos/Usuarios.aspx");
        }

        protected void ASPxButtonAccionesPersonal_Click(object sender, EventArgs e)
        {

        }
    }
}