<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="usuarios.aspx.vb" Inherits="SistemaAtencion.usuarios" %>

<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo_header_dgac.png" />
        <br />
        <br />
    
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceUsuarios" EnableTheming="True" KeyFieldName="login_oid" Theme="Moderno">
            <Settings ShowFilterRow="True" />
            <Columns>
                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                </dx:GridViewCommandColumn>
                <dx:GridViewDataTextColumn FieldName="login_oid" VisibleIndex="1" Caption="ID">
                    <EditFormSettings Visible="False" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="login_username" VisibleIndex="2" Caption="User">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="login_password" VisibleIndex="3" Caption="Password">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="login_nivelacceso" VisibleIndex="4" Caption="Nivel de Acceso">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="login_email" VisibleIndex="5" Caption="Email">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="login_nombres_completos" VisibleIndex="6" Caption="Nombres Completos">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="login_dependencia" VisibleIndex="7" Caption="Dependencia" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="seccion_oid" VisibleIndex="8" Caption="Seccion" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="observacion" VisibleIndex="9" Caption="Observacion" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn FieldName="todas_cias" VisibleIndex="11" Caption="Todas las Compañías" Visible="False">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataCheckColumn FieldName="solo_lectura" VisibleIndex="12" Caption="Solo Lectura" Visible="False">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataCheckColumn FieldName="acceso_can" VisibleIndex="13" Caption="Acceso a la CAN" Visible="False">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataCheckColumn Caption="Administrador" FieldName="administrador" VisibleIndex="14">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataTextColumn Caption="Acceso al Sistema" FieldName="sistema_acceso" VisibleIndex="10" Visible="False">
                    <PropertiesTextEdit EnableFocusedStyle="False">
                    </PropertiesTextEdit>
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:ASPxGridView>

                    <dx:ASPxButton ID="ASPxBotonVolver" runat="server" Text="Volver " Theme="MetropolisBlue">
                    </dx:ASPxButton>

        <br />
        <asp:SqlDataSource ID="SqlDataSourceUsuarios" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" DeleteCommand="DELETE FROM login_atencion WHERE (login_oid = @login_oid)" InsertCommand="INSERT INTO login_atencion(login_username, login_password, login_nivelacceso, login_email, login_nombres_completos, login_dependencia, seccion_oid, observacion, solo_lectura, administrador) VALUES (@login_username, @login_password, @login_nivelacceso, @login_email, @login_nombres_completos, @login_dependencia, @seccion_oid, @observacion, @solo_lectura, @administrador)" SelectCommand="SELECT login_atencion.* FROM login_atencion" UpdateCommand="UPDATE login_atencion SET login_username = @login_username, login_password = @login_password, login_nivelacceso = @login_nivelacceso, login_email = @login_email, login_nombres_completos = @login_nombres_completos, login_dependencia = @login_dependencia, observacion = @observacion, sistema_acceso = @sistema_acceso, solo_lectura = @solo_lectura, administrador = @administrador WHERE (login_oid = @login_oid)">
            <DeleteParameters>
                <asp:Parameter Name="login_oid" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="login_username" />
                <asp:Parameter Name="login_password" />
                <asp:Parameter Name="login_nivelacceso" />
                <asp:Parameter Name="login_email" />
                <asp:Parameter Name="login_nombres_completos" />
                <asp:Parameter Name="login_dependencia" />
                <asp:Parameter Name="seccion_oid" />
                <asp:Parameter Name="observacion" />
                <asp:Parameter Name="solo_lectura" />
                <asp:Parameter Name="administrador" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="login_username" />
                <asp:Parameter Name="login_password" />
                <asp:Parameter Name="login_nivelacceso" />
                <asp:Parameter Name="login_email" />
                <asp:Parameter Name="login_nombres_completos" />
                <asp:Parameter Name="login_dependencia" />
                <asp:Parameter Name="observacion" />
                <asp:Parameter Name="sistema_acceso" />
                <asp:Parameter Name="solo_lectura" />
                <asp:Parameter Name="administrador" />
                <asp:Parameter Name="login_oid" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
