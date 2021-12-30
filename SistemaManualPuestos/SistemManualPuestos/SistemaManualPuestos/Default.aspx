<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="SistemaAtencion._Default" %>



<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>







<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    &nbsp;</h1>
                <h2><span class="auto-style2"><strong>
                    <br />
                    Sistema de Registro de Manual de Puestos.</strong></span></h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Login de Usuario:</h3>
    <p>
        <table>
            <tr>
                <td class="style10">Usuario:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Textuser" runat="server"></asp:TextBox>
                </td>
                <td class="style4" rowspan="2">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <dx:ASPxButton ID="ASPxButtonlogin" runat="server" Text="Ingresar">
                            </dx:ASPxButton>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="style13">Password:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="Textpass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style12">
                    <asp:Image ID="Image3" runat="server" Height="72px" ImageUrl="~/Images/firefox.png" Width="70px" />
                </td>
                <td class="auto-style7"></td>
                <td class="style4"></td>
            </tr>
            <tr>
                <td colspan="2">
                    Funciona con Firefox&nbsp;24.0<br />
                    Mail de Soporte: <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0000CC" NavigateUrl="mailto:sopor.aplica.seadac@aviacioncivil.gob.ec">sopor.aplica.seadac@aviacioncivil.gob.ec</asp:HyperLink>
                </td>
                <td class="style4">&nbsp;</td>
            </tr>
        </table>
    </p>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" HeaderText="Error credenciales no válidas!" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="511px" ClientInstanceName="ASPxPopupControl2">
                            <ContentCollection>
<dx:PopupControlContentControl runat="server">
    <table class="dxflInternalEditorTable_SoftOrange">
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style8">Error credenciales de usuario No reconocidas!</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/mypc_lock.png" />
            </td>
            <td class="auto-style8">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <dx:ASPxButton ID="ASPxButton7" runat="server" EnableTheming="True" Height="16px" Text="Aceptar !" Theme="SoftOrange" Width="104px">
                            <ClientSideEvents Click="function(s, e) {
ASPxPopupControl2.Hide();	
}" />
                        </dx:ASPxButton>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <br />
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
                                </dx:PopupControlContentControl>
</ContentCollection>
                        </dx:ASPxPopupControl>
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style2 {
            font-family: "Segoe UI";
            font-size: x-large;
            padding-top: 20px;
        }
        .style10
        {
            width: 38px;
            height: 43px;
        }
        .auto-style5 {
            width: 127px;
            height: 43px;
        }
        .style4
        {
            width: 92px;
            width: 81px;
            background-image:url('~/mages/ama-vida-iso.png');
           background-position     :top;
           background-repeat             :repeat-x; 
        }
        .style13
        {
            width: 38px;
        }
        .auto-style6 {
            width: 127px;
        }
        .style12
        {
            height: 19px;
            width: 38px;
        }
        .auto-style7 {
            height: 19px;
            width: 127px;
        }
        .auto-style8 {
            width: 270px;
        }
    </style>
</asp:Content>

