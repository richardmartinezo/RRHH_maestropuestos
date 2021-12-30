<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="SistemaManualPuestosV0._1.ManualPuestos.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxLabel ID="ASPxLabelUsuarioSession" runat="server" Text=""></dx:ASPxLabel>
    <table style="width:80%;">
        <tr>
            <td>
                <dx:ASPxButton ID="ASPxButtonMaestroPuestos" runat="server" Text="MaestroPuestos" OnClick="ASPxButtonMaestroPuestos_Click"></dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="ASPxButtonMaestrosCombos" runat="server" Text="Tablas del Maestro de Puestos"></dx:ASPxButton>

            </td>
             <td>
                <dx:ASPxButton ID="ASPxButtonAccionesPersonal" runat="server" Text="AccionesPersonal" OnClick="ASPxButtonAccionesPersonal_Click" ></dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="ASPxButtonUsuarios" runat="server" Text="Usuarios" OnClick="ASPxButtonUsuarios_Click"></dx:ASPxButton>
            </td>
        </tr>
       
    </table>
</asp:Content>
