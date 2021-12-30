<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaManualPuestosV0._1.ManualPuestos.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:ScriptManager ID="ScriptManagerLogin" runat="server"></asp:ScriptManager>
                <h3>Login de Usuario:</h3>
    
    <table>
            <tr>
                <td class="style10">Usuario:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextUser" runat="server"></asp:TextBox>
                </td>
                <td class="style4" rowspan="3">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnUnload="UpdatePanel1_Unload">
                        <ContentTemplate>
                            <dx:ASPxButton ID="ASPxButtonlogin" runat="server" Text="Ingresar" EnableTheming="True" Theme="SoftOrange" OnClick="ASPxButtonlogin_Click">
                            </dx:ASPxButton>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="style13">Password:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
           
           
        </table>
            
       
</asp:Content>
