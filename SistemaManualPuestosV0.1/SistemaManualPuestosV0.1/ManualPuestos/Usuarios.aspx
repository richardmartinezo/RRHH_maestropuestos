<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="SistemaManualPuestosV0._1.ManualPuestos.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" Width="200px">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxPanel ID="ASPxPanel1" runat="server" Width="200px">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <dx:ASPxLabel ID="ASPxLabelUsuarioSesion" runat="server" Text=""></dx:ASPxLabel>
                            <dx:ASPxGridView ID="ASPxGridViewPuestos" runat="server" DataSourceID="SqlDataSourceManualPuestos" AutoGenerateColumns="False" KeyFieldName="id">
                                <Columns>
                                    <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" VisibleIndex="1">
                                        <EditFormSettings Visible="False"></EditFormSettings>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="usuario" VisibleIndex="2" Caption="Usuario"></dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="password" VisibleIndex="3" Caption="Password"></dx:GridViewDataTextColumn>
                                    <dx:GridViewDataCheckColumn FieldName="permiso_acciones_personal" ShowInCustomizationForm="True" VisibleIndex="4">
                                    </dx:GridViewDataCheckColumn>
                                    <dx:GridViewDataCheckColumn FieldName="permiso_maestro_puestos" ShowInCustomizationForm="True" VisibleIndex="5">
                                    </dx:GridViewDataCheckColumn>
                                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                                    </dx:GridViewCommandColumn>
                                </Columns>
                            </dx:ASPxGridView>

                            <asp:SqlDataSource runat="server" ID="SqlDataSourceManualPuestos" ConnectionString='<%$ ConnectionStrings:RRHHConnectionString %>' SelectCommand="SELECT * FROM [Usuarios]" DeleteCommand="DELETE FROM Usuarios WHERE (id = @id)" InsertCommand="INSERT INTO Usuarios(usuario, password, permiso_acciones_personal, permiso_maestro_puestos) VALUES (@usuario, @password, @permiso_acciones_personal, @permiso_maestro_puestos)" UpdateCommand="UPDATE Usuarios SET usuario = @usuario, password = @password, permiso_acciones_personal = @permiso_acciones_personal, permiso_maestro_puestos = @permiso_maestro_puestos WHERE (id = @id)">
                                <DeleteParameters>
                                    <asp:Parameter Name="id" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="usuario" />
                                    <asp:Parameter Name="password" />
                                    <asp:Parameter Name="permiso_acciones_personal" />
                                    <asp:Parameter Name="permiso_maestro_puestos" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="usuario" />
                                    <asp:Parameter Name="password" />
                                    <asp:Parameter Name="permiso_acciones_personal" />
                                    <asp:Parameter Name="permiso_maestro_puestos" />
                                    <asp:Parameter Name="id" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
