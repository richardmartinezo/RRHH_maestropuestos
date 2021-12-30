<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="grilla.ascx.vb" Inherits="SistemaAtencion.grilla" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script>

    function checkValue() {
        //alert(cbTest.cpText);
        
        if (cbTest.cpText == "print") {
            ASPxPopupControl1.Show();
            //location.href = 'reporte_inspec_word.aspx';
        }
        
        cbTest.cpText = "ninguno";
        var a = '<%=Session("tipo_reporte") %>';

         }
</script>

<body style="text-align: left">



<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <dx:ASPxGridView ID="ASPxGridView3" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridmaster" DataSourceID="SqlDataSource_atencion" KeyFieldName="id" Theme="Mulberry" VisibleRowCount="true" Width="99%" EnableTheming="True">
            <ClientSideEvents EndCallback="function(s, e) {
    
	cbTest.PerformCallback();
}" />
            <TotalSummary>
                <dx:ASPxSummaryItem FieldName="asientos_ofrecidos" ShowInColumn="asientos_ofrecidos" ShowInGroupFooterColumn="asientos_ofrecidos" SummaryType="Sum" />
                <dx:ASPxSummaryItem FieldName="capacidad_carga" ShowInColumn="capacidad_carga" ShowInGroupFooterColumn="capacidad_carga" SummaryType="Sum" />
                <dx:ASPxSummaryItem FieldName="tripulacion" ShowInColumn="tripulacion" ShowInGroupFooterColumn="tripulacion" SummaryType="Sum" />
            </TotalSummary>
            <EditFormLayoutProperties ColCount="6">
                <Items>
                    <dx:GridViewColumnLayoutItem ColSpan="6" ColumnName="DGAC Asignado">
                    </dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColSpan="6" ColumnName="Tipo Reclamo">
                    </dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColSpan="6" ColumnName="Estado reclamo">
                    </dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColSpan="3" ColumnName="Dias en Trámite">
                    </dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem Caption="Dias de Duración del Trámite" ColSpan="3" ColumnName="dias_tramite_finalizado">
                    </dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColSpan="6" ColumnName="cod_formulario">
                    </dx:GridViewColumnLayoutItem>
                    <dx:GridViewTabbedLayoutGroup ColSpan="6" ActiveTabIndex="1">
                        <Items>
                            <dx:GridViewLayoutGroup Caption="Datos del Usuario" Name="DatosUsuario">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="Nombres Usuario">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Mail Usuario">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Cédula">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Fecha Evento">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Descripción Reclamo" RowSpan="8">
                                    </dx:GridViewColumnLayoutItem>
                                </Items>
                            </dx:GridViewLayoutGroup>
                            <dx:GridViewLayoutGroup Caption="Datos Compañía y Aeropuerto" Name="DatosCIA">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="Compania">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem Caption="Número de Vuelo" ColumnName="Num_Vuelo">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem Caption="Aeropuerto" ColumnName="Aeródromo">
                                    </dx:GridViewColumnLayoutItem>
                                </Items>
                            </dx:GridViewLayoutGroup>
                            <dx:GridViewLayoutGroup Caption="Datos de Registro">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="id">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Fecha Creación">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Acción tomada" RowSpan="5">
                                    </dx:GridViewColumnLayoutItem>
                                </Items>
                            </dx:GridViewLayoutGroup>
                        </Items>
                    </dx:GridViewTabbedLayoutGroup>
                    <dx:EditModeCommandLayoutItem ColSpan="4" Name="CommandControls" RowSpan="3">
                    </dx:EditModeCommandLayoutItem>
                </Items>
                <SettingsItemCaptions Location="Left" />
            </EditFormLayoutProperties>
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="True" VisibleIndex="0">
                </dx:GridViewCommandColumn>
                <dx:GridViewDataTextColumn Caption="Cédula" FieldName="usuario_cedula" VisibleIndex="11" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn Caption="Fecha Creación" FieldName="fecha_crea" VisibleIndex="16" Visible="False">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataTextColumn Caption="Usuario Crea" FieldName="usuario_crea" VisibleIndex="14" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Usuario Modifica" FieldName="usuario_modifica" VisibleIndex="15" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn Caption="Fecha Modificación" FieldName="fecha_modifica" VisibleIndex="17" Visible="False">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataMemoColumn Caption="Acción tomada" FieldName="detalle_accion" VisibleIndex="13" Visible="False">
                    <PropertiesMemoEdit Height="200px" Width="300px">
                    </PropertiesMemoEdit>
                </dx:GridViewDataMemoColumn>
                <dx:GridViewDataTextColumn Caption="Dias en Trámite" FieldName="num_dias_tramite" ReadOnly="True" VisibleIndex="1" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Nombre Compañía" FieldName="NOMBRE" ReadOnly="True" VisibleIndex="10" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="dias_tramite_finalizado" Visible="False" VisibleIndex="12">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataMemoColumn Caption="Descripción Reclamo" FieldName="usuario_detalle_queja" Name="usuario_detalle_queja" ShowInCustomizationForm="True" VisibleIndex="7">
                    <PropertiesMemoEdit Columns="80" Height="250px" Rows="15" Width="350px">
                    </PropertiesMemoEdit>
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Tipo Reclamo" FieldName="id_tipo_queja" ShowInCustomizationForm="True" VisibleIndex="1">
                            <PropertiesComboBox DataSourceID="SqlDataSource_tipoqueja" ImageUrlField="imagen" TextField="nombre_tipo_queja" ValueField="id" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Estado reclamo" FieldName="id_tipo_estado_queja" ShowInCustomizationForm="True" VisibleIndex="2">
                            <PropertiesComboBox DataSourceID="SqlDataSource_estadoqueja" ImageUrlField="imagen" TextField="nombre_tipo_estado_queja" ValueField="id" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="DGAC Asignado" FieldName="usuario_dgac" ShowInCustomizationForm="True" VisibleIndex="3">
                            <PropertiesComboBox DataSourceID="SqlDataSource_Usuarios" TextField="login_nombres_completos" TextFormatString="{0}; {1}; {2}" ValueField="login_username">
                                <Columns>
                                    
<dx:ListBoxColumn Caption="Usuario" FieldName="login_username" Name="Usuario">
                                    </dx:ListBoxColumn>
                                    
<dx:ListBoxColumn Caption="Nombre" FieldName="login_nombres_completos" Name="Nombre">
                                    </dx:ListBoxColumn>
                                    
<dx:ListBoxColumn Caption="Correo" FieldName="login_email" Name="Correo">
                                    </dx:ListBoxColumn>
                                
</Columns>
                            
</PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Compania" FieldName="cod_compania" ShowInCustomizationForm="True" VisibleIndex="4" Visible="False">
                            <PropertiesComboBox ClientInstanceName="combo_cia" DataSourceID="SqlDataSource_cias" EnableCallbackMode="True" EnableClientSideAPI="True" TextField="NOMBRE" TextFormatString="{0}; {1}" ValueField="CODIGO_OACI">
                                <Columns>
                                    
<dx:ListBoxColumn FieldName="CODIGO_OACI">
                                    </dx:ListBoxColumn>
                                    
<dx:ListBoxColumn FieldName="NOMBRE">
                                    </dx:ListBoxColumn>
                                
</Columns>
                            
</PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Id Alarma" FieldName="id_alarma_queja" ShowInCustomizationForm="True" VisibleIndex="5">
                            <PropertiesComboBox DataSourceID="SqlDataSource_alarmaqueja" ImageUrlField="imagen" TextField="alarma" ValueField="id_alarma_queja">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataDateColumn Caption="Fecha Evento" FieldName="fecha" ShowInCustomizationForm="True" VisibleIndex="6">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Aeródromo" FieldName="cod_aeropuerto" ShowInCustomizationForm="True" VisibleIndex="7">
                            <PropertiesComboBox ClientInstanceName="combo_aerop" DataSourceID="SqlDataSource_Aeropuertos" EnableCallbackMode="True" EnableClientSideAPI="True" TextField="aerodromo" TextFormatString="{0}; {1}" ValueField="PUNTORUTA_OACI">
                                <Columns>
                                    
<dx:ListBoxColumn FieldName="PUNTORUTA_OACI">
                                    </dx:ListBoxColumn>
                                    
<dx:ListBoxColumn FieldName="aerodromo">
                                    </dx:ListBoxColumn>
                                
</Columns>
                            
</PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn Caption="Num_Vuelo" FieldName="num_vuelo" ShowInCustomizationForm="True" VisibleIndex="8">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Mail Usuario" FieldName="usuario_mail" ShowInCustomizationForm="True" VisibleIndex="9">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Nombres Usuario" FieldName="usuario_nombres" ShowInCustomizationForm="True" VisibleIndex="10">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                </dx:GridViewDataMemoColumn>
                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption="Reporte" Name="Reporte" VisibleIndex="9">
                    <CustomButtons>
                        <dx:GridViewCommandColumnCustomButton Text="Print">
                            <Image Url="~/Images/printer2.png">
                            </Image>
                        </dx:GridViewCommandColumnCustomButton>
                    </CustomButtons>
                </dx:GridViewCommandColumn>
                <dx:GridViewDataComboBoxColumn FieldName="cod_formulario" Visible="False" VisibleIndex="18">
                    <PropertiesComboBox DataSourceID="SqlDataSource_tipo_formulario" TextField="tipo_formulario" ValueField="cod_formulario">
                        <Columns>
                            <dx:ListBoxColumn Caption="Código" FieldName="cod_formulario" Name="cod_formulario">
                            </dx:ListBoxColumn>
                            <dx:ListBoxColumn Caption="Tipo de Formulario" FieldName="tipo_formulario" Name="tipo_formulario">
                            </dx:ListBoxColumn>
                        </Columns>
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
            </Columns>
            <SettingsDetail ShowDetailRow="True" />
            <Templates>
                <DetailRow>
                    <table class="dxflInternalEditorTable" >
                        <tr>
                            <td>
                                <dx:ASPxGridView ID="ASPxGridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceatencion_usuario_detalle" EnableTheming="True" KeyFieldName="id_atencion_usuario_detalle" OnRowInserting="ASPxGridView4_RowInserting" Theme="Mulberry" Width="449px">
                                    <SettingsDataSecurity AllowEdit="False" />
                                    <Columns>
                                        <dx:GridViewCommandColumn Visible="False" VisibleIndex="0">
                                        </dx:GridViewCommandColumn>
                                        <dx:GridViewDataDateColumn Caption="Fecha Inicio" FieldName="fecha_inicio" VisibleIndex="1">
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn FieldName="id_atencion_usuario" Visible="False" VisibleIndex="2">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="id_atencion_usuario_detalle" ReadOnly="True" Visible="False" VisibleIndex="3">
                                            <EditFormSettings Visible="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Usuario Asignado" FieldName="usuario_asignado" VisibleIndex="4">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="detalle_cambio" Visible="False" VisibleIndex="5">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataMemoColumn Caption="Cambio en el Registro" FieldName="detalle_cambio_extendido" VisibleIndex="6">
                                        </dx:GridViewDataMemoColumn>
                                    </Columns>
                                    <Styles>
                                        <Header Border-BorderStyle="Solid" Border-BorderWidth="1px" Font-Names="Arial" Font-Size="Small">
                                        </Header>
                                        <Cell Border-BorderColor="#CCCCCC" Border-BorderStyle="Solid" Border-BorderWidth="1px" Font-Names="Arial" Font-Size="X-Small">
                                        </Cell>
                                    </Styles>
                                </dx:ASPxGridView>
                            </td>
                            <td style="padding: 0px" valign="top">
                                <dx:ASPxFileManager ID="ASPxFileManager1" runat="server" DataSourceID="SqlDataSourceAdjuntos" Height="316px" Width="709px" OnFileDownloading="ASPxFileManager1_FileDownloading">
                                    <Settings ThumbnailFolder="~/Thumb/" />
                                    <SettingsEditing AllowCopy="True" AllowCreate="True" AllowDelete="True" AllowDownload="True" AllowMove="True" AllowRename="True" />
                                    <SettingsDataSource FileBinaryContentFieldName="Contenido" IsFolderFieldName="isfolder" KeyFieldName="id_adjuntos" LastWriteTimeFieldName="lastwrite" NameFieldName="namefield" ParentKeyFieldName="ParentID" />
                                </dx:ASPxFileManager>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:SqlDataSource ID="SqlDataSourceAdjuntos" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" DeleteCommand="DELETE FROM adjuntos_atencion_usuario WHERE (id_adjuntos = @id_adjuntos)" InsertCommand="INSERT INTO adjuntos_atencion_usuario(ParentID, namefield, Contenido, isfolder, lastwrite, id_atencion_usuario) VALUES (@ParentID, @namefield, @Contenido, @isfolder, @lastwrite, @id_atencion_usuario)" OnInserting="SqlDataSourceAdjuntos_Inserting" OnSelecting="SqlDataSourceAdjuntos_Selecting" SelectCommand="SELECT id_adjuntos, ParentID, namefield, Contenido, isfolder, lastwrite, id_atencion_usuario FROM adjuntos_atencion_usuario WHERE (id_atencion_usuario = @id_atencion_usuario)" UpdateCommand="UPDATE adjuntos_atencion_usuario SET ParentID = @ParentID, namefield = @namefield, Contenido = @Contenido, isfolder = @isfolder, lastwrite = @lastwrite, id_atencion_usuario = @id_atencion_usuario WHERE (id_adjuntos = @id_adjuntos)">
                        <DeleteParameters>
                            <asp:Parameter Name="id_adjuntos" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="ParentID" />
                            <asp:Parameter Name="namefield" />
                            <asp:Parameter Name="Contenido" />
                            <asp:Parameter Name="isfolder" />
                            <asp:Parameter Name="lastwrite" />
                            <asp:Parameter Name="id_atencion_usuario" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:Parameter Name="id_atencion_usuario" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="ParentID" />
                            <asp:Parameter Name="namefield" />
                            <asp:Parameter Name="Contenido" />
                            <asp:Parameter Name="isfolder" />
                            <asp:Parameter Name="lastwrite" />
                            <asp:Parameter Name="id_atencion_usuario" />
                            <asp:Parameter Name="id_adjuntos" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSourceatencion_usuario_detalle" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" DeleteCommand="DELETE FROM atencion_usuario_detalle WHERE (id_atencion_usuario_detalle = @id_atencion_usuario_detalle)" InsertCommand="INSERT INTO atencion_usuario_detalle(id_atencion_usuario, estado_atencion, fecha_inicio, detalle_cambio, usuario_asignado) VALUES (@id_atencion_usuario, @estado_atencion, @fecha_inicio, @detalle_cambio, @usuario_asignado)" SelectCommand="SELECT estado_atencion, fecha_inicio, id_atencion_usuario, id_atencion_usuario_detalle, dias_transcurridos, usuario_asignado, detalle_cambio, detalle_cambio_extendido FROM atencion_usuario_detalle WHERE (id_atencion_usuario = @id_atencion_usuario)" UpdateCommand="UPDATE atencion_usuario_detalle SET estado_atencion = @estado_atencion, fecha_inicio = @fecha_inicio, id_atencion_usuario = @id_atencion_usuario, usuario_asignado = @usuario_asignado, detalle_cambio = @detalle_cambio WHERE (id_atencion_usuario_detalle = @id_atencion_usuario_detalle)" OnSelecting="SqlDataSourceatencion_usuario_detalle_Selecting" OnInserting="SqlDataSourceatencion_usuario_detalle_Inserting">
                        <DeleteParameters>
                            <asp:Parameter Name="id_atencion_usuario_detalle" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="id_atencion_usuario" />
                            <asp:Parameter Name="estado_atencion" />
                            <asp:Parameter Name="fecha_inicio" />
                            <asp:Parameter Name="detalle_cambio" />
                            <asp:Parameter Name="usuario_asignado" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:Parameter Name="id_atencion_usuario" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="estado_atencion" />
                            <asp:Parameter Name="fecha_inicio" />
                            <asp:Parameter Name="id_atencion_usuario" />
                            <asp:Parameter Name="usuario_asignado" />
                            <asp:Parameter Name="detalle_cambio" />
                            <asp:Parameter Name="id_atencion_usuario_detalle" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </DetailRow>
            </Templates>
            <SettingsPager PageSize="50">
                <PageSizeItemSettings Items="20" ShowAllItem="True" Visible="True">
                </PageSizeItemSettings>
            </SettingsPager>
            <SettingsEditing Mode="PopupEditForm">
                <BatchEditSettings EditMode="Row" StartEditAction="DblClick" />
            </SettingsEditing>
            <Settings ShowFilterRow="True" ShowFooter="True" ShowGroupPanel="True" VerticalScrollableHeight="320" VerticalScrollBarMode="Auto" />
            <SettingsPopup>
                <EditForm HorizontalAlign="Center" />
            </SettingsPopup>
            <SettingsLoadingPanel Text="  Cargando Por favor espere...." />
            <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />
            <Styles>
                <AlternatingRow BackColor="#FFEAD5" Enabled="True">
                </AlternatingRow>
                <DetailButton Font-Italic="True">
                    <BackgroundImage HorizontalPosition="center" ImageUrl="~/Images/detalle1.png" Repeat="NoRepeat" VerticalPosition="center" />
                </DetailButton>
            </Styles>
        </dx:ASPxGridView>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:SqlDataSource ID="SqlDataSource_atencion" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" DeleteCommand="DELETE FROM [atencion_usuario] WHERE [id] = @id" InsertCommand="INSERT INTO atencion_usuario(id_tipo_queja, fecha, usuario_mail, usuario_cedula, usuario_nombres, usuario_detalle_queja, id_tipo_estado_queja, id_alarma_queja, detalle_accion, fecha_crea, usuario_crea, usuario_modifica, fecha_modifica, id_operation, cod_compania, num_vuelo, usuario_dgac, cod_aeropuerto, cod_formulario) VALUES (@id_tipo_queja, @fecha, @usuario_mail, @usuario_cedula, @usuario_nombres, @usuario_detalle_queja, @id_tipo_estado_queja, @id_alarma_queja, @detalle_accion, @fecha_crea, @usuario_crea, @usuario_modifica, @fecha_modifica, @id_operation, @cod_compania, @num_vuelo, @usuario_dgac, @cod_aeropuerto, @cod_formulario)" SelectCommand="SELECT id, id_tipo_queja, fecha, usuario_mail, usuario_cedula, usuario_nombres, usuario_detalle_queja, id_tipo_estado_queja, id_alarma_queja, detalle_accion, fecha_crea, usuario_crea, usuario_modifica, fecha_modifica, id_operation, cod_compania, SIGLAS_IATA, cod_aeropuerto, NOMBRE, num_vuelo, num_dias_tramite, usuario_dgac, dias_tramite_finalizado, cod_formulario FROM Vista_atencion WHERE (fecha BETWEEN @f1 AND @f2) AND (cod_compania LIKE @compa OR cod_compania IS NULL) AND (cod_aeropuerto LIKE @aerop OR cod_aeropuerto IS NULL) AND (usuario_dgac LIKE @usuario_dgac OR usuario_dgac IS NULL) AND (cod_formulario LIKE @cod_formulario OR cod_formulario IS NULL)" UpdateCommand="UPDATE atencion_usuario SET id_tipo_queja = @id_tipo_queja, id_alarma_queja = @id_alarma_queja, fecha = @fecha, usuario_mail = @usuario_mail, usuario_cedula = @usuario_cedula, usuario_nombres = @usuario_nombres, usuario_detalle_queja = @usuario_detalle_queja, id_tipo_estado_queja = @id_tipo_estado_queja, detalle_accion = @detalle_accion, usuario_crea = @usuario_crea, usuario_modifica = @usuario_modifica, id_operation = @id_operation, cod_compania = @cod_compania, num_vuelo = @num_vuelo, usuario_dgac = @usuario_dgac, cod_aeropuerto = @cod_aeropuerto, cod_formulario = @cod_formulario WHERE (id = @id)">
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int64" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="id_tipo_queja" Type="Int64" />
        <asp:Parameter Name="fecha" Type="DateTime" />
        <asp:Parameter Name="usuario_mail" Type="String" />
        <asp:Parameter Name="usuario_cedula" Type="String" />
        <asp:Parameter Name="usuario_nombres" Type="String" />
        <asp:Parameter Name="usuario_detalle_queja" Type="String" />
        <asp:Parameter Name="id_tipo_estado_queja" Type="Int64" />
        <asp:Parameter Name="id_alarma_queja" />
        <asp:Parameter Name="detalle_accion" Type="String" />
        <asp:Parameter Name="fecha_crea" Type="Object" />
        <asp:Parameter Name="usuario_crea" Type="String" />
        <asp:Parameter Name="usuario_modifica" Type="String" />
        <asp:Parameter Name="fecha_modifica" Type="DateTime" />
        <asp:Parameter Name="id_operation" Type="Int64" />
        <asp:Parameter Name="cod_compania" />
        <asp:Parameter Name="num_vuelo" />
        <asp:Parameter Name="usuario_dgac" />
        <asp:Parameter Name="cod_aeropuerto" />
        <asp:Parameter Name="cod_formulario" />
    </InsertParameters>
    <SelectParameters>
        <asp:Parameter Name="f1" />
        <asp:Parameter Name="f2" />
        <asp:Parameter Name="compa" />
        <asp:Parameter Name="aerop" />
        <asp:Parameter Name="usuario_dgac" />
        <asp:Parameter Name="cod_formulario" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="id_tipo_queja" Type="Int64" />
        <asp:Parameter Name="id_alarma_queja" />
        <asp:Parameter Name="fecha" Type="DateTime" />
        <asp:Parameter Name="usuario_mail" Type="String" />
        <asp:Parameter Name="usuario_cedula" Type="String" />
        <asp:Parameter Name="usuario_nombres" Type="String" />
        <asp:Parameter Name="usuario_detalle_queja" Type="String" />
        <asp:Parameter Name="id_tipo_estado_queja" Type="Int64" />
        <asp:Parameter Name="detalle_accion" Type="String" />
        <asp:Parameter Name="usuario_crea" Type="String" />
        <asp:Parameter Name="usuario_modifica" Type="String" />
        <asp:Parameter Name="id_operation" Type="Int64" />
        <asp:Parameter Name="cod_compania" />
        <asp:Parameter Name="num_vuelo" />
        <asp:Parameter Name="usuario_dgac" />
        <asp:Parameter Name="cod_aeropuerto" />
        <asp:Parameter Name="cod_formulario" />
        <asp:Parameter Name="id" Type="Int64" />
    </UpdateParameters>
</asp:SqlDataSource>

<asp:SqlDataSource ID="SqlDataSource_tipoqueja" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT * FROM [tipo_queja]"></asp:SqlDataSource>

<asp:SqlDataSource ID="SqlDataSource_alarmaqueja" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT * FROM [alarma_queja]"></asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource_estadoqueja" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT * FROM [tipo_estado_queja]"></asp:SqlDataSource>


<asp:SqlDataSource ID="SqlDataSource_cias" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT TOP (50) CODIGO_OACI, OID, SIGLAS_IATA, NOMBRE, REPRESENTANTELEGAL, DIRECCREPRELEGAL, AFTN FROM Compania WHERE (CODIGO_OACI LIKE @p1) OR (NOMBRE LIKE @p1) and AFTN = 1111111">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="p1" />
    </SelectParameters>
</asp:SqlDataSource>



<asp:SqlDataSource ID="SqlDataSource_Usuarios" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT TOP (50) login_username, login_nombres_completos, login_dependencia, login_email, administrador FROM login_atencion">
</asp:SqlDataSource>


<asp:SqlDataSource ID="SqlDataSource_Aeropuertos" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT TOP (50) PUNTORUTA_OACI, PUNTORUTA_IATA, verificable, aerodromo, CIUDAD FROM Vista_aeropuertos WHERE (PUNTORUTA_OACI LIKE  @aerop) OR (aerodromo LIKE @aerop ) AND (verificable = 1)">
    <SelectParameters>
        <asp:Parameter Name="aerop" />
    </SelectParameters>
</asp:SqlDataSource>



<asp:SqlDataSource ID="SqlDataSource_tipo_formulario" runat="server" ConnectionString="<%$ ConnectionStrings:iFISConnectionString %>" SelectCommand="SELECT TOP (50) cod_formulario, tipo_formulario, descripcion_formulario FROM tipo_formulario">
</asp:SqlDataSource>



    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="ASPxPopupControl1" CloseAnimationType="Fade" Text="ImpresionTicket">
        <ClientSideEvents Shown="function(s, e) {
	ASPxPopupControl1.RefreshContentUrl(); 
}" />
        <ContentCollection>
<dx:PopupControlContentControl runat="server"></dx:PopupControlContentControl>
</ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxCallback ID="cbTest" runat="server" ClientIDMode="AutoID" ClientInstanceName="cbTest">
        <ClientSideEvents EndCallback="function(s, e) {
	checkValue();
}" />
    </dx:ASPxCallback>



</body>


