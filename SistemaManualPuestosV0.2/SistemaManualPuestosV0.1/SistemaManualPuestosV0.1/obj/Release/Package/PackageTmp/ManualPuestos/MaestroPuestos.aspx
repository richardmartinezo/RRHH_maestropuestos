<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="MaestroPuestos.aspx.cs" Inherits="SistemaManualPuestosV0._1.ManualPuestos.MaestroPuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>

        function checkValue() {

           // alert("llego1");
            //alert(cbTest.cpText);
            if (cbTest.cpText == "Print") {
              //  alert("llego");
                ASPxPopupControl1.Show();
                // ASPxPopupControl1.Show

            }

            cbTest.cpText = "ninguno";


        }
</script>
    <script type ="text/javascript">

        
        </script>

       <dx:ASPxLabel ID="ASPxLabelUsuarioSesion" runat="server" Text=""></dx:ASPxLabel>
       <dx:ASPxLabel ID="ASPxLabelIDDetalle" runat="server" Text="" Visible="False"></dx:ASPxLabel>
                                <br />
                                <dx:ASPxGridView ID="ASPxGridViewPuestos" runat="server" DataSourceID="SqlDataSourceManualPuestos" AutoGenerateColumns="False" KeyFieldName="id" Theme="Material" EnableTheming="True" OnCustomButtonCallback="ASPxGridViewPuestos_CustomButtonCallback" OnDetailRowExpandedChanged="ASPxGridViewPuestos_DetailRowExpandedChanged" OnStartRowEditing="ASPxGridViewPuestos_StartRowEditing">
                                    <ClientSideEvents EndCallback="function(s, e) {
	cbTest.PerformCallback();

}" />
                                    <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                                    <Templates>
                                        <DetailRow>
                                            <dx:ASPxGridView ID="ASPxGridViewDetalleMaestros" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDetalleMaestro" KeyFieldName="id" ClientInstanceName="ASPxGridViewDetalleMaestros" OnStartRowEditing="ASPxGridViewDetalleMaestros_StartRowEditing" OnCustomButtonCallback="ASPxGridViewDetalleMaestros_CustomButtonCallback" OnInitNewRow="ASPxGridViewDetalleMaestros_InitNewRow">
                                                <SettingsEditing Mode="Inline" NewItemRowPosition="Bottom">
                                                    <BatchEditSettings EditMode="Row" />
                                                </SettingsEditing>
                                                <Columns>
                                                    <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" VisibleIndex="1" Visible="False">
                                                        <EditFormSettings Visible="False" />
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="id_maestro_puesto" VisibleIndex="2" Visible="False">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="id_original" VisibleIndex="3" Visible="False">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="descripcion" VisibleIndex="4">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="actividad" VisibleIndex="5">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="frecuencia" VisibleIndex="6">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="co" VisibleIndex="7">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="cm" VisibleIndex="8">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="interfaz" VisibleIndex="9">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="codigo_puesto" VisibleIndex="12">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="orden" VisibleIndex="13">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewCommandColumn Caption="ComandosDetalle" Name="ComandosDetalle" VisibleIndex="0" ShowNewButtonInHeader="True">
                                                        <CustomButtons>
                                                            <dx:GridViewCommandColumnCustomButton ID="EditDetail">
                                                                <Image Url="~/Images/edit2.png">
                                                                </Image>
                                                            </dx:GridViewCommandColumnCustomButton>
                                                        </CustomButtons>
                                                    </dx:GridViewCommandColumn>
                                                    <dx:GridViewDataComboBoxColumn Caption="Competencias Tecnicas" FieldName="id_com_tecnica" VisibleIndex="10">
                                                        <PropertiesComboBox DataSourceID="SqlDataSourceCompetenciasConductualesV2" TextField="denominacion" ValueField="id" TextFormatString="{0}; {1}; {2}; {3}; {4}; {5}">
                                                            <Columns>
                                                                <dx:ListBoxColumn FieldName="id">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="numero_denominacion">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="nivel">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="comportamiento">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="definicion">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="denominacion">
                                                                </dx:ListBoxColumn>
                                                            </Columns>
                                                        </PropertiesComboBox>
                                                    </dx:GridViewDataComboBoxColumn>
                                                    <dx:GridViewDataComboBoxColumn FieldName="id_com_conductuales" VisibleIndex="14" Caption="Competencias Conductuales">
                                                        <PropertiesComboBox DataSourceID="SqlDataSourceCompetenciasConductualesV2" TextField="denominacion" ValueField="id" TextFormatString="{0}; {1}; {2}; {3}; {4}; {5}">
                                                            <Columns>
                                                                <dx:ListBoxColumn FieldName="id">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="nivel">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="definicion">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="denominacion">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="comportamiento">
                                                                </dx:ListBoxColumn>
                                                                <dx:ListBoxColumn FieldName="numero_denominacion">
                                                                </dx:ListBoxColumn>
                                                            </Columns>
                                                        </PropertiesComboBox>
                                                    </dx:GridViewDataComboBoxColumn>
                                                    <dx:GridViewDataComboBoxColumn Caption="Relevancia" FieldName="id_relevancia" VisibleIndex="11">
                                                        <PropertiesComboBox DataSourceID="SqlDataSourceRelevanci" TextField="nivel" ValueField="id">
                                                        </PropertiesComboBox>
                                                    </dx:GridViewDataComboBoxColumn>
                                                </Columns>
                                            </dx:ASPxGridView>
                                            <asp:SqlDataSource ID="SqlDataSourceDetalleMaestro" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" DeleteCommand="DELETE FROM MaestroPuestosDetalle WHERE (id = @id)" InsertCommand="INSERT INTO MaestroPuestosDetalle(id_maestro_puesto, id_original, descripcion, actividad, frecuencia, co, cm, interfaz, id_com_tecnica, id_relevancia, codigo_puesto, orden, id_com_conductuales) VALUES (@id_maestro_puesto, @id_original, @descripcion, @actividad, @frecuencia, @co, @cm, @interfaz, @id_com_tecnica, @id_relevancia, @codigo_puesto, @orden, @id_com_conductuales)" OnSelecting="SqlDataSourceDetalleMaestro_Selecting" SelectCommand="SELECT id, id_maestro_puesto, id_original, descripcion, actividad, frecuencia, co, cm, interfaz, id_com_tecnica, id_relevancia, codigo_puesto, orden, id_com_conductuales FROM MaestroPuestosDetalle WHERE (id_maestro_puesto = @id_maestro_puesto)" UpdateCommand="UPDATE MaestroPuestosDetalle SET descripcion = @descripcion, actividad = @actividad, frecuencia = @frecuencia, co = @co, cm = @cm, interfaz = @interfaz, id_com_tecnica = @id_com_tecnica, id_relevancia = @id_relevancia, codigo_puesto = @codigo_puesto, orden = @orden, id_com_conductuales = @id_com_conductuales WHERE (id = @id_detalle)" OnUpdating="SqlDataSourceDetalleMaestro_Updating" OnInserting="SqlDataSourceDetalleMaestro_Inserting">
                                                <DeleteParameters>
                                                    <asp:Parameter Name="id" />
                                                </DeleteParameters>
                                                <InsertParameters>
                                                    <asp:Parameter Name="id_maestro_puesto" />
                                                    <asp:Parameter Name="id_original" />
                                                    <asp:Parameter Name="descripcion" />
                                                    <asp:Parameter Name="actividad" />
                                                    <asp:Parameter Name="frecuencia" />
                                                    <asp:Parameter Name="co" />
                                                    <asp:Parameter Name="cm" />
                                                    <asp:Parameter Name="interfaz" />
                                                    <asp:Parameter Name="id_com_tecnica" />
                                                    <asp:Parameter Name="id_relevancia" />
                                                    <asp:Parameter Name="codigo_puesto" />
                                                    <asp:Parameter Name="orden" />
                                                    <asp:Parameter Name="id_com_conductuales" />
                                                </InsertParameters>
                                                <SelectParameters>
                                                    <asp:Parameter Name="id_maestro_puesto" />
                                                </SelectParameters>
                                                <UpdateParameters>
                                                    <asp:Parameter Name="descripcion" />
                                                    <asp:Parameter Name="actividad" />
                                                    <asp:Parameter Name="frecuencia" />
                                                    <asp:Parameter Name="co" />
                                                    <asp:Parameter Name="cm" />
                                                    <asp:Parameter Name="interfaz" />
                                                    <asp:Parameter Name="id_com_tecnica" />
                                                    <asp:Parameter Name="id_relevancia" />
                                                    <asp:Parameter Name="codigo_puesto" />
                                                    <asp:Parameter Name="orden" />
                                                    <asp:Parameter Name="id_com_conductuales" />
                                                    <asp:Parameter Name="id" />
                                                    <asp:Parameter Name="id_detalle" />
                                                </UpdateParameters>
                                            </asp:SqlDataSource>
                                        </DetailRow>
                                    </Templates>
                                    <SettingsEditing Mode="PopupEditForm">
                                    </SettingsEditing>
                                    <Settings ShowFilterRow="True" />
                                    <SettingsDataSecurity AllowDelete="False" />
                                    <SettingsPopup>
                                        <EditForm AllowResize="True" MinWidth="30%" />
                                    </SettingsPopup>
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" VisibleIndex="0" Caption="ID">
                                            <EditFormSettings Visible="False"></EditFormSettings>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="denominacion" VisibleIndex="3" Caption="Denominación"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="mision" ShowInCustomizationForm="True" Caption="Misi&#243;n" VisibleIndex="4"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="mision" VisibleIndex="5" Caption="Misión"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="grado" VisibleIndex="7" Caption="Grado"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="titulo_requerido" VisibleIndex="15" Caption="Titulo Requerido"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="area_conocimiento" VisibleIndex="18" Caption="Area de Conocimiento"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="contenido_experiencia" VisibleIndex="20" Caption="Contenido Experiencia"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="puntos" VisibleIndex="21" Caption="Puntos" Visible="False"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="interfaz_puesto" VisibleIndex="22" Caption="Interfaz del Puesto" Visible="False"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="habilidad_gestion" VisibleIndex="23" Caption="Habilidad Gestión" Visible="False"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="observaciones" VisibleIndex="28" Caption="Observaciones"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="escala" VisibleIndex="29" Caption="Escala"></dx:GridViewDataTextColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_nivel" VisibleIndex="6" Caption="Nivel">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceNivel" TextField="descripcion" ValueField="id"></PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>


                                        <dx:GridViewDataComboBoxColumn FieldName="id_proceso" VisibleIndex="8" Caption="Proceso">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceProceso" TextField="prodescripcion" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id" Name="Id"></dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="codigo_proceso" Name="Cod_Proceso"></dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="prodescripcion" Name="ProDescripcion"></dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="prototipo" Name="Prototipo"></dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_unidad" VisibleIndex="9" Caption="Unidad">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceUnidad" TextField="aerodescripcion" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id" Name="ID">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="aerodescripcion" Name="Descripcion">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="codigo_unidad" Name="codunidad">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="dependencia_codigo" Name="depcodigo">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="proceso" Name="proceso">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_rol" VisibleIndex="10" Caption="Rol">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceRol" TextField="rdescripcion" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="puntajerol">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="puntajetiempo">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="rcodigo">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="rdescripcion">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="rnivel">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="tiempoexperiencia">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_niv_instruccion" VisibleIndex="12" Caption="Nivel Instruccion">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceNivelInstruccion" TextField="ndetalle" ValueField="id"></PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>

                                        <dx:GridViewDataComboBoxColumn FieldName="id_ambito" VisibleIndex="11" Caption="Ambito">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceAmbito" TextField="descripcion" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_an_estudio" VisibleIndex="16" Caption="Años Estudio">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceAnEstudio" TextField="anioestudio" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_an_estudio_post" VisibleIndex="17" Caption="Años Estudio Postgrado">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceAnEstudioPost" TextField="anioestudio" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_hab_comunicacion" VisibleIndex="24" Caption="Habilidad Comunicación">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceHabilidadComunicacion" TextField="f2" TextFormatString="{0}; {1}; {2}; {3}" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="f2">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="f4">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="puntaje">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_con_trabajo" VisibleIndex="25" Caption="Con Trabajo">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceConTrabajo" TextField="Descripcion" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="Descripcion">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="valor">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_toma_decisiones" VisibleIndex="26" Caption="Toma Decisiones">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceTomaDecisiones" TextField="descripcion" TextFormatString="{0}; {1}; {2}" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="descripcion">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="valor">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_con_resultados" VisibleIndex="27" Caption="Con Resultados">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceConResultados" TextField="descripcion" TextFormatString="{0}; {1}; {2}" ValueField="id">
                                                <Columns>
                                                    <dx:ListBoxColumn FieldName="id">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="descripcion">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn FieldName="valor">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewCommandColumn ShowClearFilterButton="True" ShowEditButton="True" ShowNewButton="True" VisibleIndex="1">
                                        </dx:GridViewCommandColumn>
                                        <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption="Reporte" Name="Reporte" VisibleIndex="2">
                                            <CustomButtons>
                                                <dx:GridViewCommandColumnCustomButton ID="Print" Text="Reporte">
                                                    <Image Url="~/Images/report1.png">
                                                    </Image>
                                                </dx:GridViewCommandColumnCustomButton>
                                            </CustomButtons>
                                        </dx:GridViewCommandColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_expecificacion_experiencia" Caption="Especificacion Experiencia" VisibleIndex="19">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceEspecifidadExperiencia" TextField="descripcion" ValueField="id"></PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn FieldName="id_tiempo_experiencia" Caption="Tiempo Experiencia" VisibleIndex="30">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceTiempoExperiencia" TextField="descripcion" ValueField="id"></PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>

                                        <dx:GridViewDataComboBoxColumn Caption="Nivel Intruccion 2" VisibleIndex="13">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceNivelInstruccion" TextField="ndetalle" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn Caption="Nivel Instruccion 3" VisibleIndex="14">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceNivelInstruccion" TextField="ndetalle" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn Caption="Tiempo Experiencia 2" VisibleIndex="31">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceTiempoExperiencia" TextField="descripcion" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>
                                        <dx:GridViewDataComboBoxColumn Caption="Tiempo Experiencia 3" VisibleIndex="32">
                                            <PropertiesComboBox DataSourceID="SqlDataSourceTiempoExperiencia" TextField="descripcion" ValueField="id">
                                            </PropertiesComboBox>
                                        </dx:GridViewDataComboBoxColumn>

                                    </Columns>
                                </dx:ASPxGridView>

                                <asp:SqlDataSource runat="server" ID="SqlDataSourceManualPuestos" ConnectionString='<%$ ConnectionStrings:RRHHConnectionString %>' SelectCommand="SELECT id, codigo, denominacion, mision, id_nivel, grado, id_proceso, id_unidad, id_rol, id_ambito, id_niv_instruccion, titulo_requerido, id_an_estudio, id_an_estudio_post, area_conocimiento, id_expecificacion_experiencia, contenido_experiencia, puntos, interfaz_puesto, habilidad_gestion, id_hab_comunicacion, id_con_trabajo, id_toma_decisiones, id_con_resultados, observaciones, escala, id_grp_ocupacional, id_tiempo_experiencia, id_niv_instruccion2, id_niv_instruccion3, id_tiempo_experiencia2, id_tiempo_experiencia3 FROM MaestroPuestos" InsertCommand="INSERT INTO MaestroPuestos(codigo, denominacion, mision, id_nivel, grado, id_proceso, id_unidad, id_rol, id_ambito, id_niv_instruccion, titulo_requerido, id_an_estudio, id_an_estudio_post, area_conocimiento, id_expecificacion_experiencia, contenido_experiencia, puntos, interfaz_puesto, habilidad_gestion, id_hab_comunicacion, id_con_trabajo, id_toma_decisiones, id_con_resultados, observaciones, escala, id_niv_instruccion2, id_niv_instruccion3, id_tiempo_experiencia, id_tiempo_experiencia2, id_tiempo_experiencia3) VALUES (@codigo, @denominacion, @mision, @id_nivel, @grado, @id_proceso, @id_unidad, @id_rol, @id_ambito, @id_niv_instruccion, @titulo_requerido, @id_an_estudio, @id_an_estudio_post, @area_conocimiento, @id_expecificacion_experiencia, @contenido_experiencia, @puntos, @interfaz_puesto, @habilidad_gestion, @id_hab_comunicacion, @id_con_trabajo, @id_toma_decisiones, @id_con_resultados, @observaciones, @escala, @id_niv_instruccion2, @id_niv_instruccion3, @id_tiempo_experiencia, @id_tiempo_experiencia2, @id_tiempo_experiencia3)"
                                    UpdateCommand="UPDATE MaestroPuestos SET codigo = @codigo, denominacion = @denominacion, mision = @mision, id_nivel = @id_nivel, grado = @grado, id_proceso = @id_proceso, id_unidad = @id_unidad, id_rol = @id_rol, id_ambito = @id_ambito, id_niv_instruccion = @id_niv_instruccion, titulo_requerido = @titulo_requerido, id_an_estudio = @id_an_estudio, id_an_estudio_post = @id_an_estudio_post, area_conocimiento = @area_conocimiento, id_expecificacion_experiencia = @id_expecificacion_experiencia, contenido_experiencia = @contenido_experiencia, puntos = @puntos, interfaz_puesto = @interfaz_puesto, habilidad_gestion = @habilidad_gestion, id_hab_comunicacion = @id_hab_comunicacion, id_con_trabajo = @id_con_trabajo, id_toma_decisiones = @id_toma_decisiones, id_con_resultados = @id_con_resultados, observaciones = @observaciones, escala = @escala, id_grp_ocupacional = @id_grp_ocupacional, id_tiempo_experiencia = @id_tiempo_experiencia, id_niv_instruccion2 = @id_niv_instruccion2, id_niv_instruccion3 = @id_niv_instruccion3, id_tiempo_experiencia2 = @id_tiempo_experiencia2, id_tiempo_experiencia3 = @id_tiempo_experiencia3 WHERE (id = @id)">
                                    <InsertParameters>
                                        <asp:Parameter Name="codigo" />
                                        <asp:Parameter Name="denominacion" />
                                        <asp:Parameter Name="mision" />
                                        <asp:Parameter Name="id_nivel" />
                                        <asp:Parameter Name="grado" />
                                        <asp:Parameter Name="id_proceso" />
                                        <asp:Parameter Name="id_unidad" />
                                        <asp:Parameter Name="id_rol" />
                                        <asp:Parameter Name="id_ambito" />
                                        <asp:Parameter Name="id_niv_instruccion" />
                                        <asp:Parameter Name="titulo_requerido" />
                                        <asp:Parameter Name="id_an_estudio" />
                                        <asp:Parameter Name="id_an_estudio_post" />
                                        <asp:Parameter Name="area_conocimiento" />
                                        <asp:Parameter Name="id_expecificacion_experiencia" />
                                        <asp:Parameter Name="contenido_experiencia" />
                                        <asp:Parameter Name="puntos" />
                                        <asp:Parameter Name="interfaz_puesto" />
                                        <asp:Parameter Name="habilidad_gestion" />
                                        <asp:Parameter Name="id_hab_comunicacion" />
                                        <asp:Parameter Name="id_con_trabajo" />
                                        <asp:Parameter Name="id_toma_decisiones" />
                                        <asp:Parameter Name="id_con_resultados" />
                                        <asp:Parameter Name="observaciones" />
                                        <asp:Parameter Name="escala" />
                                        <asp:Parameter Name="id_niv_instruccion2" />
                                        <asp:Parameter Name="id_niv_instruccion3" />
                                        <asp:Parameter Name="id_tiempo_experiencia" />
                                        <asp:Parameter Name="id_tiempo_experiencia2" />
                                        <asp:Parameter Name="id_tiempo_experiencia3" />
                                    </InsertParameters>
                                    <UpdateParameters>
                                        <asp:Parameter Name="codigo" />
                                        <asp:Parameter Name="denominacion" />
                                        <asp:Parameter Name="mision" />
                                        <asp:Parameter Name="id_nivel" />
                                        <asp:Parameter Name="grado" />
                                        <asp:Parameter Name="id_proceso" />
                                        <asp:Parameter Name="id_unidad" />
                                        <asp:Parameter Name="id_rol" />
                                        <asp:Parameter Name="id_ambito" />
                                        <asp:Parameter Name="id_niv_instruccion" />
                                        <asp:Parameter Name="titulo_requerido" />
                                        <asp:Parameter Name="id_an_estudio" />
                                        <asp:Parameter Name="id_an_estudio_post" />
                                        <asp:Parameter Name="area_conocimiento" />
                                        <asp:Parameter Name="id_expecificacion_experiencia" />
                                        <asp:Parameter Name="contenido_experiencia" />
                                        <asp:Parameter Name="puntos" />
                                        <asp:Parameter Name="interfaz_puesto" />
                                        <asp:Parameter Name="habilidad_gestion" />
                                        <asp:Parameter Name="id_hab_comunicacion" />
                                        <asp:Parameter Name="id_con_trabajo" />
                                        <asp:Parameter Name="id_toma_decisiones" />
                                        <asp:Parameter Name="id_con_resultados" />
                                        <asp:Parameter Name="observaciones" />
                                        <asp:Parameter Name="escala" />
                                        <asp:Parameter Name="id_grp_ocupacional" />
                                        <asp:Parameter Name="id_tiempo_experiencia" />
                                        <asp:Parameter Name="id_niv_instruccion2" />
                                        <asp:Parameter Name="id_niv_instruccion3" />
                                        <asp:Parameter Name="id_tiempo_experiencia2" />
                                        <asp:Parameter Name="id_tiempo_experiencia3" />
                                        <asp:Parameter Name="id" />
                                    </UpdateParameters>
                                </asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceNivel" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [Niveles]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceProceso" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [Proceso]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceUnidad" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [UnidadesDependencia]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceRol" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [Roles]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceNivelInstruccion" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [NivelInstruccion]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceAnEstudio" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [AnioEstudio] WHERE ([postgrado] = @postgrado)">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="NO" Name="postgrado" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceAnEstudioPost" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [AnioEstudio] WHERE ([postgrado] = @postgrado)">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="SI" Name="postgrado" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceHabilidadComunicacion" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [HabilidadComunicacion]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceConTrabajo" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [ConTrabajo]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceCompetenciasConductuales" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [CompetenciasConductuales]"></asp:SqlDataSource>
                                                            
    <asp:SqlDataSource ID="SqlDataSourceCompetenciasTecnicas" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT id, cdetalle FROM CompetenciasTecnicas"></asp:SqlDataSource>
                                                            
    <br />
    <asp:SqlDataSource ID="SqlDataSourceCompetenciasConductualesV2" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [CompetenciasConductualesV2]"></asp:SqlDataSource>
                                                            
    <asp:SqlDataSource ID="SqlDataSourceCompetenciasTecnicasV2" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [CompetenciasTecnicasV2]"></asp:SqlDataSource>
                                                            
    <asp:SqlDataSource ID="SqlDataSourceTomaDecisiones" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [TomaDecisiones]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceConResultados" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [ConResultados]"></asp:SqlDataSource>
                                <dx:ASPxHiddenField ID="ASPxHiddenFieldDetalle" runat="server" ClientInstanceName="ASPxHiddenFieldDetalle">
    </dx:ASPxHiddenField>
    <asp:HiddenField ID="HiddenFieldStandard" runat="server" ClientIDMode="Inherit" />
                                <asp:SqlDataSource ID="SqlDataSourceAmbito" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [Ambito]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceTiempoExperiencia" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [TiempoExperiencia]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceEspecifidadExperiencia" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [EspecifidadExperiencia]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceGrupoOcupacional" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT * FROM [GrupoOcupacional]"></asp:SqlDataSource>

                                <asp:SqlDataSource ID="SqlDataSourceRelevanci" runat="server" ConnectionString="<%$ ConnectionStrings:RRHHConnectionString %>" SelectCommand="SELECT id, nivel FROM Relevancia"></asp:SqlDataSource>

                                <br />
                                <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" HeaderText="Permiso" ClientInstanceName="ASPxPopupControl1">
                                    <ClientSideEvents Shown="function(s, e) {
	ASPxPopupControl1.RefreshContentUrl(); 


}" />
                                    <ContentCollection>
                                        <dx:PopupControlContentControl runat="server">
                                        </dx:PopupControlContentControl>
                                    </ContentCollection>
                                </dx:ASPxPopupControl>
                                <dx:ASPxCallback ID="cbTest" runat="server" ClientIDMode="AutoID" ClientInstanceName="cbTest" OnCallback="cbTest_Callback">
                                    <ClientSideEvents EndCallback="function(s, e) {
	checkValue();
}" />
            </dx:ASPxCallback>

     </asp:Content>
