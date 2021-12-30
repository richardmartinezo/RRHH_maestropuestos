using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaManualPuestosV0._1.Classes;
using System.Reflection;

namespace SistemaManualPuestosV0._1.ManualPuestos
{
    public partial class Login : System.Web.UI.Page
    {
        private BdConnection bdconnection;
        private String[] usuariopass;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = "";
            Session["password"] = "";
            Session["nivelaccesoacciones"] = "";
            Session["nivelaccesomaestros"] = "";
            Session["puestonombre"] = "";
            Session["id_maestro_detalle"] = "";
            Session["id_detalle"] = "";
            

        }

        protected void ASPxButtonlogin_Click(object sender, EventArgs e)
        {
            bdconnection = new BdConnection();
           
            usuariopass = bdconnection.consultaUsuarioPassword(TextUser.Text,TextPass.Text);
            if(usuariopass[0].Equals("")){
                Response.Redirect("../default.aspx");
            }
            if(usuariopass[1].Equals("")){
                Response.Redirect("../default.aspx");
            }
            if(usuariopass[2].Equals("")){
                Response.Redirect("../default.aspx");
            }
            if (usuariopass[3].Equals(""))
            {
                Response.Redirect("../default.aspx");
            }

            Session["usuario"] = usuariopass[0].ToString();
            Session["nivelaccesomaestros"] = usuariopass[3].ToString();
            Response.Redirect("/ManualPuestos/MenuPrincipal.aspx");
            
        }
        /*Registro del Update Panel para Boton, y poder usar bton con javascript*/
        protected void UpdatePanel1_Unload(object sender, EventArgs e)
        {
            RegisterUpdatePanel((UpdatePanel)sender); 
        }

        private void RegisterUpdatePanel(UpdatePanel updatePanel)
        {
            var sType = typeof(ScriptManager);
            var mInfo = sType.GetMethod("System.Web.UI.IScriptManagerInternal.RegisterUpdatePanel", BindingFlags.NonPublic | BindingFlags.Instance);
            if (mInfo != null)
                mInfo.Invoke(ScriptManager.GetCurrent(Page), new object[] { updatePanel });  
        }

    }
}