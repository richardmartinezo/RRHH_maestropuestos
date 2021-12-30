Imports Microsoft.Reporting.WebForms

Public Class Reportes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ASPxPresentarReporteBoton_Click(sender As Object, e As EventArgs) Handles ASPxPresentarReporteBoton.Click
        ReportViewer1.ProcessingMode = ProcessingMode.Remote
        ReportViewer1.Reset()
        Dim serverReport As ServerReport
        serverReport = ReportViewer1.ServerReport

        ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://win-sqlserv-01/ReportServer/")
        ReportViewer1.ServerReport.ReportPath = "/reportedayli/Reporte_atencion_usuario" ''modificar

        


        If ASPxFechaFin.Value Is Nothing Then
            ASPxFechaFin.Value = DateTime.Parse(Format(Now(), "dd/MM/yyyy") & " 23:59:59")
        End If



        Dim ffin As New ReportParameter()
        ffin.Name = "fecha_fin"
        ffin.Values.Add((Format(ASPxFechaFin.Value, "MM/dd/yyyy") & " 23:59:59"))
        Dim parameters3() As ReportParameter = {ffin}
        serverReport.SetParameters(parameters3)

        Dim fini As New ReportParameter()
        fini.Name = "fecha_ini"
        If ASPxFechaInicio.Value Is Nothing Then
            ASPxFechaInicio.Value = DateTime.Parse("01/01/2016") & " 23:59:59"
            fini.Values.Add(ASPxFechaInicio.Value)
        Else
            fini.Values.Add((Format(ASPxFechaInicio.Value, "MM/dd/yyyy") & " 00:00:00"))
        End If
        Dim parameters4() As ReportParameter = {fini}
        serverReport.SetParameters(parameters4)

        If ASPxAeropuerto.Value Is Nothing Then
            ASPxAeropuerto.Value = "%%"
        End If

        If ASPxCompania.Value Is Nothing Then
            ASPxCompania.Value = "%%"

        End If


        Dim aerodromobase As New ReportParameter()
        aerodromobase.Name = "cod_aeropuerto"
        aerodromobase.Values.Add(ASPxAeropuerto.Value)
        Dim parameters5() As ReportParameter = {aerodromobase}
        serverReport.SetParameters(parameters5)

        Dim compania As New ReportParameter()
        compania.Name = "cod_compania"
        compania.Values.Add(ASPxCompania.Value)
        Dim parameters6() As ReportParameter = {compania}
        serverReport.SetParameters(parameters6)



        Try
            ReportViewer1.ServerReport.Refresh()
        Catch ex As Exception

        End Try


    End Sub

    Protected Sub ASPxPresentarReporteBoton0_Click(sender As Object, e As EventArgs) Handles ASPxPresentarReporteBoton0.Click
        Response.Redirect("../movaero.aspx")
    End Sub
End Class