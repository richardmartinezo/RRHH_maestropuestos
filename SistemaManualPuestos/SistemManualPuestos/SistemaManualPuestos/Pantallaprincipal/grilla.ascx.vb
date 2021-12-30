Imports DevExpress.Web
Imports System.Net.Mail
Imports System.Data.SqlClient


Public Class grilla
    Inherits System.Web.UI.UserControl
    Public usuario_notificacion_email As String
    Public Sub ActualizagrillaMethod(Aerop As String, fechainicio As Date, fechafin As Date, cia As String, usuario_dgac As String, tipo_formulario As String)


        'If IsNothing(Aerop) Then
        '    Session("Aerop") = "%%"
        'ElseIf IsNothing(cia) Then
        '    Session("cia") = "%%"
        'ElseIf IsNothing(fechainicio) Then
        '    Session("fechainicio") = DateTime.Parse("01/01/2016")
        'ElseIf IsNothing(fechafin) Then
        '    Session("fechafin") = DateTime.Parse(Format(Now(), "dd/MM/yyyy") & " 23:59:59")
        'ElseIf IsNothing(fechafin) Then
        '    Session("fechafin") = DateTime.Parse(Format(Now(), "dd/MM/yyyy") & " 23:59:59")
        'Else
        Session("fechacambio") = 1
        Session("Aerop") = Aerop
        Session("cia") = cia
        Session("fechainicio") = fechainicio
        Session("fechafin") = fechafin

        Session("usuario_dgac") = usuario_dgac
        Session("cod_formulario") = tipo_formulario


        'End If

        Me.ASPxGridView3.DataBind()


    End Sub



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' ActualizagrillaMethod("%%", DateTime.Parse("01/01/2016") & " 23:59:59", DateTime.Parse(Format(Now(), "dd/MM/yyyy") & " 23:59:59"), "%%", Session("usuario_dgac"))
        If Not Page.IsPostBack Then
            ' Me.Form.Attributes.Add("autocomplete", "off")
            ASPxPopupControl1.ContentUrl = "~/Reportes/ReportesXtraReports/ReporteQueja.aspx"
            Me.ASPxPopupControl1.Height = 600
            Me.ASPxPopupControl1.Width = 900
            Session("ticket_consultado") = False
        End If
    End Sub

    Protected Sub SqlDataSource_cabecera_dta_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs)


        e.Command.Parameters("@f1").Value = DateTime.Parse(Format(Session("fechainicio"), "dd/MM/yyyy") & " 00:00:00")
        e.Command.Parameters("@f2").Value = DateTime.Parse(Format(Session("fechafin"), "dd/MM/yyyy") & " 23:59:59")
        e.Command.Parameters("@PARAM_TYPE").Value = Session("operacion")
        Dim string_sql As String
        string_sql = " and company  = '" & Trim(Session("cia")) & "'"
        e.Command.CommandText = e.Command.CommandText & string_sql
        string_sql = " and aerodrome = '" & Session("Aerop") & "'"
        e.Command.CommandText = e.Command.CommandText & string_sql

    End Sub

    Protected Sub SqlDataSource_cias_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource_cias.Selecting
        If IsNothing(Session("p1")) Or Session("p1") = "%%" Or Session("p1") = "%NO ASSIGN%" Then
            e.Cancel = True
            Exit Sub
        End If

        e.Command.Parameters("@p1").Value = "%" & Session("p1") & "%"
        Session("p1") = "%%"
    End Sub

    Protected Sub ASPxGridView3_CellEditorInitialize(sender As Object, e As DevExpress.Web.ASPxGridViewEditorEventArgs) Handles ASPxGridView3.CellEditorInitialize
        If e.Column.FieldName = "cod_compania" Then
            Dim combo As ASPxComboBox = TryCast(e.Editor, ASPxComboBox)

            AddHandler combo.ItemsRequestedByFilterCondition, AddressOf combo_id_company_filter
            AddHandler combo.ItemRequestedByValue, AddressOf combo_id_company_item
            AddHandler combo.SelectedIndexChanged, AddressOf combo_id_company_databind

        End If
        If e.Column.FieldName = "cod_aeropuerto" Then
            Dim combo2 As ASPxComboBox = TryCast(e.Editor, ASPxComboBox)

            AddHandler combo2.ItemsRequestedByFilterCondition, AddressOf combo_id_aerop_filter
            AddHandler combo2.ItemRequestedByValue, AddressOf combo_id_aerop_item
            AddHandler combo2.SelectedIndexChanged, AddressOf combo_id_aerop_databind

        End If
    End Sub
    Private Sub combo_id_aerop_filter(ByVal source As Object, ByVal e As DevExpress.Web.ListEditItemsRequestedByFilterConditionEventArgs)
        Session("aerodrome") = "%" & e.Filter & "%"
        Dim combo As ASPxComboBox = TryCast(source, ASPxComboBox)
        combo.DataBind()
        combo.SelectedIndex = 1
    End Sub
    Private Sub combo_id_aerop_item(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
        Dim combo2 As ASPxComboBox = TryCast(source, ASPxComboBox)

    End Sub
    Protected Sub combo_id_aerop_databind(sender As Object, e As EventArgs)

    End Sub

    Private Sub combo_id_company_filter(ByVal source As Object, ByVal e As DevExpress.Web.ListEditItemsRequestedByFilterConditionEventArgs)
        Session("p1") = "%" & e.Filter & "%"
        Dim combo As ASPxComboBox = TryCast(source, ASPxComboBox)
        combo.DataBind()
        combo.SelectedIndex = 1
    End Sub
    Private Sub combo_id_company_item(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
        Dim combo2 As ASPxComboBox = TryCast(source, ASPxComboBox)

    End Sub
    Protected Sub combo_id_company_databind(sender As Object, e As EventArgs)

    End Sub

    Protected Sub SqlDataSource_atencion_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource_atencion.Selecting
        e.Command.Parameters("@f1").Value = DateTime.Parse(Format(Session("fechainicio"), "dd/MM/yyyy") & " 00:00:00")
        e.Command.Parameters("@f2").Value = DateTime.Parse(Format(Session("fechafin"), "dd/MM/yyyy") & " 23:59:59")
        e.Command.Parameters("@compa").Value = "%" & Session("cia") & "%"
        e.Command.Parameters("@aerop").Value = "%" & Session("Aerop") & "%"
        e.Command.Parameters("@usuario_dgac").Value = "%" & Session("usuario_dgac") & "%"
        e.Command.Parameters("@cod_formulario").Value = "%" & Session("cod_formulario") & "%"

        'e.Command.Parameters("@usuario_dgac").Value = "'usuario N/A'"



    End Sub
    Protected Sub mail(mailaddress As String, saludo_usuario As String, mensaje As String)
        On Error Resume Next

        Dim mail As New MailMessage()
        mail.From = New MailAddress("no_reply@aviacioncivil.gob.ec") 'comprobantes.electronicos@aviacioncivil.gob.ec CEDGAC seadacweb@aviacioncivil.gob.ec dgac2122
        mail.To.Add(mailaddress)

        ' mensaje = saludo_usuario & vbNewLine & vbNewLine & "Fecha: " & ASPXCalendarEdit.Value.ToString() & vbNewLine & "Nombres: " & TextNombres.Text & vbNewLine & "Cédula: " & Textcedula.Value & vbNewLine & "Correo: " & Textemail.Value & vbNewLine & "Aeropuerto: " & ASPxComboBox_aerop.Text & vbNewLine & "Compañía: " & ASPxComboBox_companias.Text & vbNewLine & "Num Vuelo: " & TextNumVuelo.Value & vbNewLine & "Asunto: " & mensaje
        mensaje = mensaje & " y fue asignado el: " & Now()

        mail.Body = mensaje
        Dim smtp As New SmtpClient("172.20.16.16")
        mail.Subject = "Asignación de ticket de fecha: " & Now()

        smtp.Send(mail)


    End Sub

    Protected Sub ASPxGridView3_DetailRowExpandedChanged(sender As Object, e As ASPxGridViewDetailRowEventArgs) Handles ASPxGridView3.DetailRowExpandedChanged

        Session("id_registro_main") = sender.GetDataRow(e.VisibleIndex)("id")
        Session("usuario_dgac") = sender.GetDataRow(e.VisibleIndex)("usuario_dgac")
        Session("fecha_detalle") = Date.Now()
        'Session("detalle_atencion") = "El usuario modificó" & sender.GetDataRow(e.VisibleIndex)("")


        Dim i = 0
        For i = 0 To Me.ASPxGridView3.VisibleRowCount
            If i <> e.VisibleIndex Then
                ASPxGridView3.DetailRows.CollapseRow(i)
            End If
        Next

        insertar(ASPxGridView3.GetDataRow(e.VisibleIndex)("id"))



    End Sub

    Protected Sub SqlDataSource_Aeropuertos_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource_Aeropuertos.Selecting
        If IsNothing(Session("aerodrome")) Or Session("aerodrome") = "%%" Or Session("aerodrome") = "%NO ASSIGN%" Then
            e.Cancel = True
            Exit Sub
        End If

        e.Command.Parameters("@aerop").Value = "%" & Session("aerodrome") & "%"
        Session("aerodrome") = "%%"
    End Sub

    Protected Sub SqlDataSourceatencion_usuario_detalle_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs)
        e.Command.Parameters("@id_atencion_usuario").Value = Session("id_registro_main")
    End Sub

    Protected Sub ASPxGridView4_RowInserting(sender As Object, e As Data.ASPxDataInsertingEventArgs)
       


    End Sub

    Protected Sub ASPxUploadControl1_FileUploadComplete(sender As Object, e As FileUploadCompleteEventArgs)
        Dim i = 1
        Dim cn As String = "Data Source=win-sqlserv-01;Initial Catalog=iFISpruebas;User ID=adminsql;Password=sistema*-!;"

        Dim sql As String = "insert into adjuntos_sistema_atencion (Contenido, Filename,ContentLength,ContentType, id_detalle_atencion) values (@contenido, @Filename, @ContentLength, @ContentType)"


        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Try
                cmd.Parameters.Add("@contenido", SqlDbType.Binary).Value = e.UploadedFile.FileContent
                cmd.Parameters.Add("@Filename", SqlDbType.VarChar).Value = e.UploadedFile.FileName
                cmd.Parameters.Add("@ContentLength", SqlDbType.Int).Value = e.UploadedFile.ContentLength
                cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = e.UploadedFile.ContentType
                cmd.Parameters.Add("@id_detalle_atencion", SqlDbType.VarChar).Value = Session("id_detalle_atencion")

                'cmd.Parameters.Add("@registry", SqlDbType.VarChar).Value = Session("registry")


                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try
        End Using
    End Sub

    Protected Sub SqlDataSource_atencion_Inserted(sender As Object, e As SqlDataSourceStatusEventArgs) Handles SqlDataSource_atencion.Inserted
       

    End Sub

    

    Protected Sub SqlDataSource_atencion_Updated(sender As Object, e As SqlDataSourceStatusEventArgs) Handles SqlDataSource_atencion.Updated
        User_Com_Query()


    End Sub

    Protected Sub ASPxGridView3_StartRowEditing(sender As Object, e As Data.ASPxStartRowEditingEventArgs) Handles ASPxGridView3.StartRowEditing


        Session("id_registro_main") = ASPxGridView3.GetRowValuesByKeyValue(e.EditingKeyValue, "id")

        If Session("administrador") = True Then
            ' Session("usuario_administrador") = ASPxGridView3.GetRowValuesByKeyValue(e.EditingKeyValue, "usuario_dgac")
        Else
            Session("usuario_dgac") = ASPxGridView3.GetRowValuesByKeyValue(e.EditingKeyValue, "usuario_dgac")
        End If

        Session("fecha_detalle") = Date.Now()
        insertar(e.EditingKeyValue)
                                       




    End Sub

    Protected Sub ASPxGridView3_RowUpdated(sender As Object, e As Data.ASPxDataUpdatedEventArgs) Handles ASPxGridView3.RowUpdated

    End Sub

    Protected Sub ASPxGridView3_RowUpdating(sender As Object, e As Data.ASPxDataUpdatingEventArgs) Handles ASPxGridView3.RowUpdating
        Dim cadena As String = ""
        Dim i As Integer = 0
        Dim correo_consultado As String = ""
        cadena = "Los valores en esta fecha de modificación son:  " + Constants.vbNewLine
        While (i < e.NewValues.Count)

            If (i = 0) Then
                '  cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 2) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 3) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 4) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 5) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 8) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 14) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 15) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
                'ElseIf (i = 16) Then
                '    cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 17) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            ElseIf (i = 13) Then
                cadena = cadena + Convert.ToString(e.NewValues.Keys(i)) + ": " + Convert.ToString(e.NewValues.Item(i)) + ";" + Constants.vbNewLine
            End If



            i = i + 1

        End While
        Session("detalle_atencion") = cadena
        'usuario diferente
        If e.NewValues.Item(14) <> e.OldValues.Item(14) Then

            correo_consultado = correo_consultar(e.NewValues.Item(14).ToString())
            If correo_consultado = "" Then
            Else
                mail(correo_consultado, "Estimado/a:", "Su usuario ha recibido un ticket de id: " & e.Keys.Values(0))
            End If



        End If


    End Sub
    Protected Function correo_consultar(usuario As String) As String
        Dim sql As String
        Dim resultado As String
        resultado = ""
        Dim tabla_dgac As DataTable


        Dim cn As String = "Data Source=win-sqlserv-01;Initial Catalog=iFISpruebas;User ID=adminsql;Password=sistema*-!;"
        sql = "select login_email from login_atencion where login_username ='" & usuario & "'"

        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            conn.Open()
            Dim tabla_user As New SqlDataAdapter(sql, conn)
            Dim dataSet As New DataSet("datasetablas")
            tabla_user.Fill(dataSet)
            tabla_dgac = dataSet.Tables(0)
        End Using
        If IsDBNull(tabla_dgac.Rows(0)("login_email")) Then

            resultado = ""
        Else
            resultado = tabla_dgac.Rows(0)("login_email").ToString()
        End If


        Return resultado
    End Function

    Protected Function User_Com_Query() As String
        Dim con As New SqlClient.SqlConnection
        Dim strCon As String = "Data Source=win-sqlserv-01;Initial Catalog=iFISpruebas;User ID=adminsql;Password=sistema*-!;"
        Dim numr As Integer
        con.ConnectionString = strCon
        con.Open()
        Dim datablasdgac As New SqlDataAdapter("SELECT Compania FROM [Permisos_Op_DGAC].[dbo].[login_permisos_ops_companias]  where [id_login_usuario] = '" & Session("id_login_usuario") & "'", con)
        Dim dataset As New DataSet("datasetablas")
        datablasdgac.Fill(dataset)
        Dim tablasdgac As DataTable
        tablasdgac = dataset.Tables(0)
        Dim insertar As String = "INSERT INTO atencion_usuario_detalle(id_atencion_usuario, estado_atencion, fecha_inicio, detalle_cambio_extendido, usuario_asignado) " &
       "VALUES (@id_atencion_usuario, @estado_atencion, @fecha_inicio, @detalle_cambio_extendido, @usuario_asignado)"
        Dim insertar_query As New SqlCommand(insertar, con)

        insertar_query.Parameters.AddWithValue("@id_atencion_usuario", Session("id_registro_main"))
        insertar_query.Parameters.AddWithValue("@fecha_inicio", Session("fecha_detalle"))
        If Session("administrador") = True Then
            insertar_query.Parameters.AddWithValue("@usuario_asignado", Session("usuario_administrador"))
        Else
            insertar_query.Parameters.AddWithValue("@usuario_asignado", Session("usuario_dgac"))
        End If

        insertar_query.Parameters.AddWithValue("@estado_atencion", "")
        insertar_query.Parameters.AddWithValue("@detalle_cambio_extendido", Session("detalle_atencion"))




        numr = Convert.ToInt32(insertar_query.ExecuteScalar())
        con.Close()


        Return numr
    End Function
    Protected Sub insertar(idform As Integer)

        Dim numr As Integer
        Dim numreg As Integer
        Dim sql As String = "insert into adjuntos_atencion_usuario (isfolder,namefield,parentid,id_atencion_usuario) values (1, 'DAC', 0 ," & idform & ");SELECT SCOPE_IDENTITY()"
        'adjunto aqui la validacion
        Dim sql2 As String = "select count(*) from adjuntos_atencion_usuario where id_atencion_usuario =" & idform
        Dim cn As String = "Data Source=win-sqlserv-01;Initial Catalog=iFISpruebas;User ID=adminsql;Password=sistema*-!;"

        'consulto aqui la validacion
        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql2, conn)
            conn.Open()
            numreg = Convert.ToInt32(cmd.ExecuteScalar())

        End Using

        If numreg = 0 Then
            Using conn As New SqlConnection(cn)
                Dim cmd As New SqlCommand(sql, conn)
                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd.ExecuteScalar())

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            End Using

            sql = "insert into adjuntos_atencion_usuario (isfolder,namefield,parentid,id_atencion_usuario) values (1, 'RespaldoAtencion',  " & numr & " , " & idform & ")"
            Using conn As New SqlConnection(cn)
                Dim cmd As New SqlCommand(sql, conn)
                conn.Open()
                cmd.ExecuteScalar()

            End Using



        Else

        End If

    End Sub

    Protected Sub SqlDataSource_adjuntos_Inserting(sender As Object, e As SqlDataSourceCommandEventArgs)
        e.Command.Parameters("@id_atencion_usuario").Value = Session("id_registro_main")
    End Sub

    Protected Sub SqlDataSource_adjuntos_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs)
        e.Command.Parameters("@id_atencion_usuario").Value = Session("id_registro_main")

    End Sub

    Protected Sub SqlDataSourceatencion_usuario_detalle_Inserting(sender As Object, e As SqlDataSourceCommandEventArgs)

    End Sub

    Protected Sub SqlDataSourceAdjuntos_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs)
        e.Command.Parameters("@id_atencion_usuario").Value = Session("id_registro_main")
    End Sub

    Protected Sub SqlDataSourceAdjuntos_Inserting(sender As Object, e As SqlDataSourceCommandEventArgs)
        e.Command.Parameters("@id_atencion_usuario").Value = Session("id_registro_main")
    End Sub

    Protected Sub ASPxGridView3_CustomColumnDisplayText(sender As Object, e As ASPxGridViewColumnDisplayTextEventArgs) Handles ASPxGridView3.CustomColumnDisplayText
     
    End Sub

    Protected Sub ASPxGridView3_CustomButtonCallback(sender As Object, e As ASPxGridViewCustomButtonCallbackEventArgs) Handles ASPxGridView3.CustomButtonCallback
        If e.ButtonID = "Print" Then
            Session("code") = "print"
            Session("oid_parametro_ticket") = Me.ASPxGridView3.GetDataRow(e.VisibleIndex)("id")
        End If
    End Sub

    Protected Sub cbTest_Callback(source As Object, e As CallbackEventArgs) Handles cbTest.Callback
        If Session("code") = "print" Then
            cbTest.JSProperties("cpText") = "print"
        End If
        Session("code") = "ninguno"
    End Sub

    Protected Sub ASPxFileManager1_FileDownloading(source As Object, e As FileManagerFileDownloadingEventArgs)
        'e.File.Name()
        e.OutputStream = source

    End Sub
End Class