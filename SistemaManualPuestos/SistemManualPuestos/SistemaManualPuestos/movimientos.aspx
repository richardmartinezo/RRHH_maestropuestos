<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="movimientos.aspx.vb" Inherits="SistemaAtencion.movimientos" %>
<%@ Register src="Pantallaprincipal/filtros.ascx" tagname="filtros" tagprefix="uc1" %>
<%@ Register src="Pantallaprincipal/grilla.ascx" tagname="grilla" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:filtros ID="filtros1" runat="server" />
<p>
    <uc2:grilla ID="grilla1" runat="server" />
</p>
<p>
</p>
</asp:Content>
