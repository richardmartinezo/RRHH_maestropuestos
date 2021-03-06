<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="filtros.ascx.vb" Inherits="SistemaAtencion.filtros" %>
<%@ Register namespace="DevExpress.Web" tagprefix="ASPxCallbackPanel" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>







<style type="text/css">

    .auto-style4 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
        height: 11px;
        width: 60px;
    }
    .auto-style5 {
        height: 11px;
    }
    .auto-style3 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
    }
    .auto-style7 {
        height: 11px;
        width: 81px;
    }
    .auto-style11 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
        width: 60px;
    }
    .auto-style10 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
        width: 81px;
    }
    .auto-style12 {
        height: 11px;
        width: 189px;
    }
    .auto-style13 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
        width: 189px;
    }
      #grad1 {
                height: 200px;
                background: red; /* For browsers that do not support gradients */
                background: -webkit-linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* For Safari 5.1 to 6.0 */
                background: -o-linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* For Opera 11.1 to 12.0 */
                background: -moz-linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* For Firefox 3.6 to 15 */
                background: linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* Standard syntax (must be last) */
            }
    .auto-style14 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
        width: 60px;
        height: 12px;
    }
    .auto-style15 {
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: x-small;
        height: 12px;
    }
    .auto-style17 {
        height: 23px;
        width: 11px;
    }
    .auto-style18 {
        height: 23px;
        width: 129px;
    }
    </style>
<p style="text-align: left">
    <table style="border-style: solid; border-width: 1px; width: 100%;">
        <tr>
            <td class="auto-style17" style="border-style: solid; border-width: 1px">
    <dx:ASPxButton ID="ASPxAdministracion" runat="server" Text="Administración Usuarios">
    </dx:ASPxButton>
            </td>
            <td class="auto-style18" style="border-style: solid; border-width: 1px">
    <dx:ASPxButton ID="ASPxReportes" runat="server" Text="Reportes">
    </dx:ASPxButton>
            </td>
           
            <td class="auto-style18">
    <dx:ASPxButton ID="ASPxReportes_aerop" runat="server" Text="Reportes por Aeropuertos">
    </dx:ASPxButton>
            </td>
           
        </tr>
    </table>
</p>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table class="style7">
            <tr>
                <td class="auto-style4">Cia:</td>
                <td class="auto-style5" colspan="2" style="text-align: left">
                    <dx:ASPxComboBox ID="ASPxComboBox_cias" runat="server" DataSourceID="SqlDataSource_cias_filtro" EnableCallbackMode="True" EnableClientSideAPI="True" Height="22px" TextField="CODIGO_OACI" TextFormatString="{0}; {1}; {2}" ValueField="CODIGO_OACI" Width="226px">
                       
 
                        <Columns>
                             <dx:ListBoxColumn Caption="Cod OACI" FieldName="CODIGO_OACI" />
                            <dx:ListBoxColumn Caption="Cod IATA" FieldName="SIGLAS_IATA" />
                            <dx:ListBoxColumn FieldName="NOMBRE" Width="500px" />
                        </Columns>
                        <ClearButton DisplayMode="OnHover">
                        </ClearButton>
                       
 
                    </dx:ASPxComboBox>
                </td>
                <td class="auto-style7" style="text-align: left"><span class="auto-style3">FECHA DESDE:</span></td>
                <td class="auto-style5" style="text-align: left">
                    <dx:ASPxDateEdit ID="ASPxDateEdit_fechainicio" runat="server" DisplayFormatString="dd/MM/yyyy" Date="2017-08-01">
                        <timesectionproperties visible="True">
                        </timesectionproperties>
                    </dx:ASPxDateEdit>
                </td>
                <td class="auto-style12" style="text-align: left">Tipo Formulario:</td>
                <td class="auto-style12" style="text-align: left">
                    <dx:ASPxComboBox ID="ASPxComboBox_tipo_formulario" runat="server" DataSourceID="SqlDataTipoFormulario" EnableCallbackMode="True" EnableClientSideAPI="True" Height="22px" TextField="tipo_formulario" TextFormatString="{0}" ValueField="cod_formulario" Width="226px">
                        <Columns>
                            <dx:ListBoxColumn Caption="Código" FieldName="cod_formulario" Name="cod_formulario" />
                            <dx:ListBoxColumn Caption="Tipo de Formulario" FieldName="tipo_formulario" Name="tipo_formulario" />
                            <dx:ListBoxColumn Caption="Descripción" FieldName="descripcion_formulario" Name="descripcion_formulario" />
                        </Columns>
                        <ClearButton DisplayMode="OnHover">
                        </ClearButton>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Aeropuerto:</td>
                <td colspan="2" style="text-align: left">
                    <dx:ASPxComboBox ID="ASPxComboBox_aerop" runat="server" DataSourceID="SqlDataSource_aerodrome" EnableCallbackMode="True" EnableClientSideAPI="True" Height="22px" IncrementalFilteringMode="Contains" TextField="AEROP_DESCRIP" TextFormatString="{0}" ValueField="PUNTORUTA_OACI" Width="226px">
                        <Columns>
                            <dx:ListBoxColumn Caption="Aeropuerto" FieldName="AEROP_DESCRIP" Width="400px" />
                            <dx:ListBoxColumn Caption="Cod OACI" FieldName="PUNTORUTA_OACI" />
                            <dx:ListBoxColumn FieldName="CIUDAD" />
                            <dx:ListBoxColumn FieldName="PAIS" />
                            <dx:ListBoxColumn Caption="REGION" FieldName="region" />
                        </Columns>
                        <ClearButton DisplayMode="OnHover">
                        </ClearButton>
                    </dx:ASPxComboBox>
                </td>
                <td class="auto-style10" style="text-align: left"><span class="auto-style3">FECHA HASTA:</span></td>
                <td class="auto-style3" style="text-align: left">
                    <dx:ASPxDateEdit ID="ASPxDateEdit_fechafin" runat="server" DisplayFormatString="dd/MM/yyyy" Date="2017-08-04">
                        <timesectionproperties visible="True">
                        </timesectionproperties>
                    </dx:ASPxDateEdit>
                </td>
                <td class="auto-style13" style="text-align: left">&nbsp;</td>
                <td class="auto-style13" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"><span class="auto-style3">&nbsp;</span></td>
                <td class="auto-style15">
                    <dx:ASPxButton ID="ASPxButton9" runat="server" AutoPostBack="False" CssClass="auto-style3" Text="Aplicar Filtro" ToolTip="Ver movimientos con filtro de fechas, Tipo Operación A/D, y Ver validado Aerop.">
                        <ClientSideEvents Click="function(s, e) {
	gridmaster.PerformCallback('nada');
}" />
                    </dx:ASPxButton>
                </td>
                <td class="auto-style15" colspan="4"></td>
                <td class="auto-style15">&nbsp;</td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:SqlDataSource ID="SqlDataSource_aerodrome" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand=" select * from [Vista_aeropuertos] where verificable = 1"></asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource_cias_filtro" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT TOP (50) CODIGO_OACI, OID, SIGLAS_IATA, NOMBRE, 
REPRESENTANTELEGAL, DIRECCREPRELEGAL, AFTN FROM
 Compania WHERE ((((CODIGO_OACI LIKE @param_cia_filtro)  OR (NOMBRE LIKE @param_cia_filtro))) and aftn is not null)">
    <SelectParameters>
        <asp:Parameter Name="param_cia_filtro" />
    </SelectParameters>
</asp:SqlDataSource>

<asp:SqlDataSource ID="SqlDataTipoFormulario" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT cod_formulario, tipo_formulario, descripcion_formulario FROM tipo_formulario"></asp:SqlDataSource>


