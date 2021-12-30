Imports DevExpress.Web
Imports System.Net.Mail
Imports System.Data.SqlClient

Public Class filtros
    Inherits System.Web.UI.UserControl
    Public Delegate Sub MessageHandler(Aerop As String, fechainicio As Date, fechafin As Date, cia As String, usuario_dgac As String, tipo_formulario As String)
    Public Event Actualizagrilla As MessageHandler

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ASPxAdministracion.Enabled = Session("administrador")
    
        If Session("fechacambio") = 1 Then
            ASPxDateEdit_fechafin.Value = DateTime.Parse(Format(Now(), "dd/MM/yyyy") & " 23:59:59")
            ' DateTime.Parse(Format(Session("fechafin"), "dd/MM/yyyy") & " 23:59:59")
            Session("fechacambio") += 1
        Else

        End If

    End Sub


    Protected Sub SqlDataSource_aerodrome_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource_aerodrome.Selecting

    End Sub

    Protected Sub ASPxComboBox_cias_ItemRequestedByValue(source As Object, e As DevExpress.Web.ListEditItemRequestedByValueEventArgs) Handles ASPxComboBox_cias.ItemRequestedByValue

    End Sub

    Protected Sub ASPxComboBox_cias_ItemsRequestedByFilterCondition(source As Object, e As DevExpress.Web.ListEditItemsRequestedByFilterConditionEventArgs) Handles ASPxComboBox_cias.ItemsRequestedByFilterCondition
        Session("param_cia_filtro") = "%" & e.Filter & "%"
        Dim combo2 As ASPxComboBox = TryCast(source, ASPxComboBox)
        combo2.DataBind()

    End Sub

    Protected Sub SqlDataSource_cias_filtro_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource_cias_filtro.Selecting
        e.Command.Parameters("@param_cia_filtro").Value = Session("param_cia_filtro")
    End Sub

    Protected Sub ASPxButton9_Click(sender As Object, e As EventArgs) Handles ASPxButton9.Click
        

        If Session("administrador") = True Then
            If Me.ASPxComboBox_tipo_formulario.Value Is Nothing Then
                RaiseEvent Actualizagrilla(Trim(Me.ASPxComboBox_aerop.Value), ASPxDateEdit_fechainicio.Value, ASPxDateEdit_fechafin.Value, Trim(Me.ASPxComboBox_cias.Value), "", "")
            Else
                RaiseEvent Actualizagrilla(Trim(Me.ASPxComboBox_aerop.Value), ASPxDateEdit_fechainicio.Value, ASPxDateEdit_fechafin.Value, Trim(Me.ASPxComboBox_cias.Value), "", Trim(Me.ASPxComboBox_tipo_formulario.Value))
            End If

        Else
            If Me.ASPxComboBox_tipo_formulario.Value Is Nothing Then
                RaiseEvent Actualizagrilla(Trim(Me.ASPxComboBox_aerop.Value), ASPxDateEdit_fechainicio.Value, ASPxDateEdit_fechafin.Value, Trim(Me.ASPxComboBox_cias.Value), Session("usuario_dgac"), "")

            Else
                RaiseEvent Actualizagrilla(Trim(Me.ASPxComboBox_aerop.Value), ASPxDateEdit_fechainicio.Value, ASPxDateEdit_fechafin.Value, Trim(Me.ASPxComboBox_cias.Value), Session("usuario_dgac"), Trim(Me.ASPxComboBox_tipo_formulario.Value))

            End If
           
        End If


    End Sub

    Protected Sub ASPxAdministracion_Click(sender As Object, e As EventArgs) Handles ASPxAdministracion.Click
        Response.Redirect("AdministracionUsuarios/usuarios.aspx")
    End Sub

   


    Protected Sub ASPxReportes_Click(sender As Object, e As EventArgs) Handles ASPxReportes.Click
        Response.Redirect("Reportes/Reportes.aspx")
    End Sub

    Protected Sub ASPxReportes_aerop_Click(sender As Object, e As EventArgs) Handles ASPxReportes_aerop.Click
        Response.Redirect("Reportes/ReportesAeropuerto.aspx")
    End Sub
End Class