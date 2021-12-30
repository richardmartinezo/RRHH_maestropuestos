using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;

namespace SistemaManualPuestosV0._1.ManualPuestos
{
    public partial class MaestroPuestos : System.Web.UI.Page
    {
        Hashtable tablatemporal = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            ASPxLabelUsuarioSesion.Text = Session["usuario"] + " se ha conectado";
            ASPxLabelIDDetalle.Text = "";

            if (!Page.IsPostBack)
            {
                this.Form.Attributes.Add("autocomplete", "off");
                ASPxPopupControl1.ContentUrl = "~/Report/ReportePagina.aspx";
                this.ASPxPopupControl1.Height = 600;
                this.ASPxPopupControl1.Width = 900;


            }
        }

        protected void ASPxGridViewPuestos_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID == "Print")
            {

                Session["code"] = "Print";
                ASPxGridView grid = (ASPxGridView)sender;
                Session["id_maestro"] = this.ASPxGridViewPuestos.GetRowValues(e.VisibleIndex, grid.KeyFieldName);
                Session["puestonombre"] = this.ASPxGridViewPuestos.GetRowValues(e.VisibleIndex, "denominacion");

            }


        }

        
        protected void ASPxGridViewPuestos_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {

            
            Session["id_maestro_detalle"] = ASPxGridViewPuestos.GetRowValues(e.VisibleIndex, "id");

        }

        protected void ASPxGridViewPuestos_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
            Session["id_maestro_detalle"] = ASPxGridViewPuestos.GetRowValuesByKeyValue("id"); 

        }

        protected void SqlDataSourceDetalleMaestro_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
                e.Command.Parameters["@id_maestro_puesto"].Value = Session["id_maestro_detalle"];
           
        }

        protected void SqlDataSourceDetalleMaestro_Updating(object sender, SqlDataSourceCommandEventArgs e)
        {
            e.Command.Parameters["@id_detalle"].Value = Session["id_detalle"];
        }

        protected void ASPxGridViewDetalleMaestros_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
           // Session["id_detalle"] = e.EditingKeyValue;
        }

        protected void ASPxGridViewDetalleMaestros_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {

            //EditDetail
            ASPxGridView detalle = (ASPxGridView)sender;
           // Session["id_maestro_detalle"] = detalle.GetRowValues(e.VisibleIndex, "id_maestro_puesto");//this.ASPxGridViewPuestos.GetRowValues(e.VisibleIndex, grid.KeyFieldName);
               
            
            if (e.ButtonID == "EditDetail")
            {
                Session["id_maestro_detalle"] = detalle.GetRowValues(e.VisibleIndex, "id_maestro_puesto");//this.ASPxGridViewPuestos.GetRowValues(e.VisibleIndex, grid.KeyFieldName);
                Session["id_detalle"]  = detalle.GetRowValues(e.VisibleIndex, "id"); 
              
                detalle.StartEdit(e.VisibleIndex);
              
            }
            //else if(e.ButtonID=="New") 
            //{
                
            //    detalle.AddNewRow();
            
            //}


        }
        protected void cbTest_Callback(object source, CallbackEventArgs e)
        {
            if (Session["code"] == "Print")
            {
                cbTest.JSProperties["cpText"] = "Print";

            }

            Session["code"] = "ninguno";

        }

        protected void ASPxGridViewDetalleMaestros_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {

        }

        protected void SqlDataSourceDetalleMaestro_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {
            e.Command.Parameters["@id_maestro_puesto"].Value = Session["id_maestro_detalle"];
        }

    }
}