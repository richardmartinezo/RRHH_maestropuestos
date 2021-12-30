using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaManualPuestosV0._1;
using SistemaManualPuestosV0._1.ManualPuestos;
using DevExpress.XtraPrinting;
using System.IO;


namespace SistemaManualPuestosV0._1.Report
{
    public partial class ReportePagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           // using MS as memorStream
            using(MemoryStream ms = new MemoryStream() ){
                XtraReportMaestro xtraReportMaestro = new XtraReportMaestro();
                PdfExportOptions xtraprinting = new PdfExportOptions();
                Page.Response.Buffer = false;
                Page.Response.ClearHeaders();
                Page.Response.ClearContent();
                xtraReportMaestro.Parameters["id"].Value = Session["id_maestro"];
                xtraReportMaestro.CreateDocument();
                xtraReportMaestro.Name = "";
                xtraprinting.ShowPrintDialogOnOpen = false;
                xtraReportMaestro.ExportToPdf(ms, xtraprinting);
                ms.Seek(0, SeekOrigin.Begin);
                Byte[] report = ms.ToArray();
                Page.Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "filename=" + Session["puestonombre"]);
                Page.Response.Clear();
                Page.Response.OutputStream.Write(report,0,report.Length);
                Page.Response.End();
                Page.Response.Flush();
                Page.Response.Close();
                xtraReportMaestro.Dispose();
                report = null;
                Session["id_maestro"] = 0;

            
            }
        }
    }
}