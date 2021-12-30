Imports System.IO

Public Class ReporteQueja
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Using ms As New MemoryStream()
            Dim reportequeja As New XtraReportQueja
            'Dim r As New reportedtae
            Page.Response.Buffer = False
            Page.Response.ClearHeaders()
            Page.Response.ClearContent()
            reportequeja.Parameters("id").Value = Session("oid_parametro_ticket")
            'r.Parameters("Oid_fin").Value = Session("oid_final")
            reportequeja.CreateDocument()
            reportequeja.Name = "reportequeja.pdf"
            Dim opts As New DevExpress.XtraPrinting.PdfExportOptions()
            opts.ShowPrintDialogOnOpen = False
            reportequeja.ExportToPdf(ms, opts)
            'r.ExportToRtf("c:\reportes\aldo.doc")
            'r.ExportToPdf("c:\dllcompartida\aldo.pdf")
            ms.Seek(0, SeekOrigin.Begin)
            Dim report() As Byte = ms.ToArray()
            Page.Response.ContentType = "application/pdf"
            Response.AddHeader("content-disposition", "filename=reportequeja.pdf")
            Page.Response.Clear()
            ' Page.Response.
            Page.Response.OutputStream.Write(report, 0, report.Length)
            Page.Response.End()
            Page.Response.Flush()
            Page.Response.Close()
            reportequeja.Dispose()
            report = Nothing
            Session("oid_parametro_dtae") = 0
        End Using
    End Sub

End Class