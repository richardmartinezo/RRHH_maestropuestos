Imports System.Security.Cryptography
Imports DevExpress.XtraSpreadsheet.Internal
Imports DevExpress.Web

Public Class usuarios
    Inherits System.Web.UI.Page

    Private Shared TripleDES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Private Const key As String = "dacrtser533ww123"

    Public Shared Function MD5Hash(ByVal value As String) As Byte()

        Dim byteArray() As Byte = ASCIIEncoding.ASCII.GetBytes(value)
        Return MD5.ComputeHash(byteArray)

    End Function
    Public Shared Function Encrypt(ByVal stringToEncrypt As String) As String

        Try
            TripleDES.Key = MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String(TripleDES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Return String.Empty
        End Try

    End Function
    Public Shared Function Decrypt(ByVal encryptedString As String) As String

        Try
            TripleDES.Key = MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(TripleDES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Return String.Empty
        End Try

    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub ASPxBotonVolver_Click(sender As Object, e As EventArgs) Handles ASPxBotonVolver.Click
        Response.Redirect("~/Default.aspx")
    End Sub

    Protected Sub ASPxGridView1_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles ASPxGridView1.RowUpdating
        'Dim dl As ASPxTextBox = DirectCast(ASPxGridView1.FindEditRowCellTemplateControl(TryCast(ASPxGridView1.Columns("login_password"), GridViewDataTextColumn), "ASPxTextBox1"), ASPxTextBox)
        'Dim upclave As ASPxCheckBox = DirectCast(ASPxGridView1.FindEditRowCellTemplateControl(TryCast(ASPxGridView1.Columns("password"), GridViewDataTextColumn), "ASPxCheckBox_update"), ASPxCheckBox)
        ' If upclave.Value Then
        e.NewValues("login_password") = Encrypt(e.NewValues("login_password"))


        'End If
    End Sub

    Protected Sub ASPxGridView1_RowInserting(sender As Object, e As Data.ASPxDataInsertingEventArgs) Handles ASPxGridView1.RowInserting
        'Dim dl As ASPxTextBox = DirectCast(ASPxGridView1.FindEditRowCellTemplateControl(TryCast(ASPxGridView1.Columns("login_password"), GridViewDataTextColumn), "ASPxTextBox1"), ASPxTextBox)
        e.NewValues("login_password") = Encrypt(e.NewValues("login_password"))
    End Sub
End Class