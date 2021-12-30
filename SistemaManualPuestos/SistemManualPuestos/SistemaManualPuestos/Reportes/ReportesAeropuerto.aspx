<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReportesAeropuerto.aspx.vb" Inherits="SistemaAtencion.ReportesAeropuerto"   %>


<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td>Fecha Inicio:</td>
                            <td>
                                <dx:ASPxDateEdit ID="ASPxFechaInicio" runat="server">
                                </dx:ASPxDateEdit>
                            </td>
                            <td><strong>Presentar Reporte:</strong></td>
                            <td><strong>Regresar:</strong></td>
                        </tr>
                        <tr>
                            <td>Fecha Fin:</td>
                            <td>
                                <dx:ASPxDateEdit ID="ASPxFechaFin" runat="server">
                                </dx:ASPxDateEdit>
                            </td>
                            <td rowspan="3">
                                <dx:ASPxButton ID="ASPxPresentarReporteBoton" runat="server" Text="Reporte">
                                    <Image Url="~/Images/printer_laserjet.png">
                                    </Image>
                                </dx:ASPxButton>
                            </td>
                            <td rowspan="3">
                                <dx:ASPxButton ID="ASPxPresentarReporteBoton0" runat="server" Text="Regresar">
                                    <Image Url="~/Images/cancelado.jpg">
                                    </Image>
                                </dx:ASPxButton>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <dx:ASPxTextBox ID="ASPxCompania" runat="server" Width="170px" Visible="False">
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <dx:ASPxTextBox ID="ASPxAeropuerto" runat="server" Width="170px" Visible="False">
                                </dx:ASPxTextBox>
                                <br />
                                <dx:ASPxComboBox ID="ASPxComboAeropuerto" runat="server" DataSourceID="SqlDataSourceaerops" ValueField="designador_oaci" Visible="False">
                                    <Columns>
                                        <dx:ListBoxColumn Caption="OACI" FieldName="designador_oaci" Name="OACI">
                                        </dx:ListBoxColumn>
                                        <dx:ListBoxColumn Caption="Aeropuerto" FieldName="aerodromo" Name="Aeropuerto">
                                        </dx:ListBoxColumn>
                                    </Columns>
                                </dx:ASPxComboBox>
                                <asp:SqlDataSource ID="SqlDataSourceaerops" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT designador_oaci, designador_iata, aerodromo FROM Aerodrome WHERE (verificable = 1)"></asp:SqlDataSource>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="494px" Width="1260px" ShowParameterPrompts="False" Font-Names="Verdana" Font-Size="8pt" ProcessingMode="Remote" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
                        <ServerReport ReportPath="/reportedayli/Reporte_atencion_usuario&quot;" />
                    </rsweb:ReportViewer>
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
