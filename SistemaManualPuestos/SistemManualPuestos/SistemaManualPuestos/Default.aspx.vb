Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Net
Imports System.Threading
Imports System.Reflection
Imports System.Net.Mail
Imports System.IO
Public Class _Default
    Inherits Page
    Private Shared TripleDES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Private Const key As String = "dacrtser533ww123"


#Region " Region de Codigo para el encriptacion encrypt y desencrypt"
    Public Shared Function MD5Hash(ByVal value As String) As Byte()

        Dim byteArray() As Byte = ASCIIEncoding.ASCII.GetBytes(value)
        Return MD5.ComputeHash(byteArray)

    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String) As String

        Try

            ' Definição da chave e da cifra (que neste caso é Electronic
            ' Codebook, ou seja, encriptação individual para cada bloco)
            TripleDES.Key = _Default.MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB

            ' Converte a string para bytes e encripta
            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String(TripleDES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception

            Return String.Empty

        End Try
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String) As String

        Try

            ' Definição da chave e da cifra
            TripleDES.Key = MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB

            ' Converte a string encriptada para bytes e decripta
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(TripleDES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception

            Return String.Empty

        End Try

    End Function

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


    End Sub

    Protected Sub ASPxButtonlogin_Click(sender As Object, e As EventArgs) Handles ASPxButtonlogin.Click

        Dim con As New SqlClient.SqlConnection
        Dim strCon As String = "Data Source=win-sqlserv-01;Initial Catalog=ifispruebas;User ID=adminsql;Password=sistema*-!;"
        con.ConnectionString = strCon
        con.Open()

        Dim datablasdgac As New SqlDataAdapter("select * from login_atencion where login_username= '" & Me.Textuser.Text & "'", con)
        Session("usuario_dgac") = Me.Textuser.Text
        Session("usuario_administrador") = Me.Textuser.Text
        Dim dataset As New DataSet("datasetablas")
        datablasdgac.Fill(dataset)
        Dim tablasdgac As DataTable
        tablasdgac = dataset.Tables(0)

        If tablasdgac.Rows.Count = 0 Then
            ScriptManager.RegisterClientScriptBlock(Me, Me.Page.GetType(), "dxsi_HidePopup", "ASPxPopupControl2.Show();", True)
        Else
            Session("administrador") = tablasdgac.Rows(0)("administrador")
           
            If Session("administrador").Equals(DBNull.Value) Then
                Session("administrador") = False
            End If

            Session("autorizacionPASSWORD") = True
            If tablasdgac.Rows(0)("login_nivelacceso") = "A" Then
                Session("nivel_acceso") = True


            Else
                Session("nivel_acceso") = False
            End If

            If Textpass.Text = Decrypt(tablasdgac.Rows(0)("login_password")) Then
                Session("autorizacion") = True
                Session("mail") = tablasdgac.Rows(0)("login_email")
                If IsDBNull(Session("mail")) Then
                    Session("mail") = "nothing"
                End If
                Response.Redirect("movaero.aspx")
            Else
                ScriptManager.RegisterClientScriptBlock(Me, Me.Page.GetType(), "dxsi_HidePopup", "ASPxPopupControl2.Show();", True)
            End If
        End If


    End Sub

    Protected Sub UpdatePanel1_Unload(sender As Object, e As EventArgs) Handles UpdatePanel1.Unload
        RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
    End Sub

    Protected Sub RegisterUpdatePanel(ByVal panel As UpdatePanel)
        Dim sType = GetType(ScriptManager)
        Dim mInfo = sType.GetMethod("System.Web.UI.IScriptManagerInternal.RegisterUpdatePanel", BindingFlags.NonPublic Or BindingFlags.Instance)
        If mInfo IsNot Nothing Then
            mInfo.Invoke(ScriptManager.GetCurrent(Page), New Object() {panel})
        End If
    End Sub

    Protected Sub UpdatePanel2_Unload(sender As Object, e As EventArgs) Handles UpdatePanel2.Unload
        RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
    End Sub

    Protected Sub ASPxButton7_Click(sender As Object, e As EventArgs) Handles ASPxButton7.Click

    End Sub
End Class