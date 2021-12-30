Public Class movaero
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler filtros1.Actualizagrilla, AddressOf grilla1.ActualizagrillaMethod
        If Session("autorizacion") <> True Then
            Response.Redirect("Default.aspx")
        End If
        Session("fecha_actual_flag") = 0


    End Sub

   
End Class