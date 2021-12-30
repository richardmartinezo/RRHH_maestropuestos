using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReportMaestro
/// </summary>
public class XtraReportMaestro : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle FieldCaption;
    private XRControlStyle PageInfo;
    private XRControlStyle DataField;
    private DevExpress.XtraReports.Parameters.Parameter id;
    private XRLabel xrLabel53;
    private ReportHeaderBand reportHeaderBand1;
    private XRPictureBox xrPictureBox1;
    private XRTable xrTableMatrizPuesto;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell43;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell39;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell35;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell31;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell23;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell57;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell22;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell56;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell74;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell13;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell71;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell100;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell102;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell101;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell128;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell120;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell122;
    private XRTableCell xrTableCell123;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell114;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell117;
    private XRTableCell xrTableCell118;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell109;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private XRTableCell xrTableCell113;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell130;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRLabel xrLabel1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReportMaestro()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportMaestro));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTableMatrizPuesto = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.id = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableMatrizPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableMatrizPuesto});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 2034.375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableMatrizPuesto
            // 
            this.xrTableMatrizPuesto.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableMatrizPuesto.Dpi = 100F;
            this.xrTableMatrizPuesto.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTableMatrizPuesto.Name = "xrTableMatrizPuesto";
            this.xrTableMatrizPuesto.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow13,
            this.xrTableRow12,
            this.xrTableRow11,
            this.xrTableRow10,
            this.xrTableRow9,
            this.xrTableRow8,
            this.xrTableRow7,
            this.xrTableRow6,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow5,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow30,
            this.xrTableRow31,
            this.xrTableRow4,
            this.xrTableRow3,
            this.xrTableRow16,
            this.xrTableRow20,
            this.xrTableRow19,
            this.xrTableRow21,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow24,
            this.xrTableRow29,
            this.xrTableRow28,
            this.xrTableRow27,
            this.xrTableRow26,
            this.xrTableRow25});
            this.xrTableMatrizPuesto.SizeF = new System.Drawing.SizeF(1440F, 2034.375F);
            this.xrTableMatrizPuesto.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Dpi = 100F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell1.Dpi = 100F;
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "1. DATOS DE IDENTIFICACIÓN DEL PUESTO";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell1.Weight = 1.4263246355149524D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell2.Dpi = 100F;
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.ForeColor = System.Drawing.Color.White;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "3. RELACIONES INTERNAS Y EXTERNAS";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 1.4263245935071565D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell3.Dpi = 100F;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.ForeColor = System.Drawing.Color.White;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "4. INSTRUCCIÓN FORMAL REQUERIDA";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell3.Weight = 2.8526492583019358D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell48});
            this.xrTableRow2.Dpi = 100F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell19.Dpi = 100F;
            this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBackColor = false;
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.Text = "Código:";
            this.xrTableCell19.Weight = 0.71316231775747618D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.mpcodigo")});
            this.xrTableCell4.Dpi = 100F;
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Weight = 0.71316231775747618D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell5.Dpi = 100F;
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "INTERFAZ";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell5.Weight = 1.4263245935071565D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell6.Dpi = 100F;
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.RowSpan = 3;
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "Nivel de Instrucción:\t";
            this.xrTableCell6.Weight = 1.4263246291509679D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivinndetalle")});
            this.xrTableCell48.Dpi = 100F;
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.Weight = 1.4263246291509679D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell49});
            this.xrTableRow13.Dpi = 100F;
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell44.Dpi = 100F;
            this.xrTableCell44.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseBackColor = false;
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.Text = "Denominación del Puesto:";
            this.xrTableCell44.Weight = 0.71316231775747618D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivdescripcion")});
            this.xrTableCell45.Dpi = 100F;
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.Weight = 0.71316231775747618D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.mpinterfaz_puestos")});
            this.xrTableCell46.Dpi = 100F;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.RowSpan = 8;
            this.xrTableCell46.Weight = 1.4263245935071565D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Dpi = 100F;
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.Text = "Área de Conocimiento:";
            this.xrTableCell47.Weight = 1.4263246291509679D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivinndetalle2")});
            this.xrTableCell49.Dpi = 100F;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Weight = 1.4263246291509679D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell50});
            this.xrTableRow12.Dpi = 100F;
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell40.Dpi = 100F;
            this.xrTableCell40.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseBackColor = false;
            this.xrTableCell40.StylePriority.UseFont = false;
            this.xrTableCell40.Text = "Nivel:";
            this.xrTableCell40.Weight = 0.71316231775747618D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivdescripcion")});
            this.xrTableCell41.Dpi = 100F;
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Weight = 0.71316231775747618D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Dpi = 100F;
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Text = "xrTableCell42";
            this.xrTableCell42.Weight = 1.4263245935071565D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell43.Dpi = 100F;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseBackColor = false;
            this.xrTableCell43.Text = "xrTableCell43";
            this.xrTableCell43.Weight = 1.4263246291509679D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivinndetalle3")});
            this.xrTableCell50.Dpi = 100F;
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Weight = 1.4263246291509679D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell51});
            this.xrTableRow11.Dpi = 100F;
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell36.Dpi = 100F;
            this.xrTableCell36.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseBackColor = false;
            this.xrTableCell36.StylePriority.UseFont = false;
            this.xrTableCell36.Text = "Unidad Administrativa:";
            this.xrTableCell36.Weight = 0.71316231775747618D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.udaerodescripcion")});
            this.xrTableCell37.Dpi = 100F;
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 0.71316231775747618D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Dpi = 100F;
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Text = "xrTableCell38";
            this.xrTableCell38.Weight = 1.4263245935071565D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell39.Dpi = 100F;
            this.xrTableCell39.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.RowSpan = 5;
            this.xrTableCell39.StylePriority.UseBackColor = false;
            this.xrTableCell39.StylePriority.UseFont = false;
            this.xrTableCell39.Text = "Área de Conocimiento:";
            this.xrTableCell39.Weight = 1.4263246291509679D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.mpaereaconocimiento")});
            this.xrTableCell51.Dpi = 100F;
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.RowSpan = 5;
            this.xrTableCell51.Weight = 1.4263246291509679D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell52});
            this.xrTableRow10.Dpi = 100F;
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell32.Dpi = 100F;
            this.xrTableCell32.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBackColor = false;
            this.xrTableCell32.StylePriority.UseFont = false;
            this.xrTableCell32.Text = "Rol:";
            this.xrTableCell32.Weight = 0.71316231775747618D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.rdescripcion")});
            this.xrTableCell33.Dpi = 100F;
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Weight = 0.71316231775747618D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Dpi = 100F;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Text = "xrTableCell34";
            this.xrTableCell34.Weight = 1.4263245935071565D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Dpi = 100F;
            this.xrTableCell35.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseFont = false;
            this.xrTableCell35.Text = "xrTableCell35";
            this.xrTableCell35.Weight = 1.4263246291509679D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Dpi = 100F;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.Weight = 1.4263246291509679D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell53});
            this.xrTableRow9.Dpi = 100F;
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell28.Dpi = 100F;
            this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBackColor = false;
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.Text = "Grupo Ocupacional:";
            this.xrTableCell28.Weight = 0.71316231775747618D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.godescripcion")});
            this.xrTableCell29.Dpi = 100F;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Weight = 0.71316231775747618D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Dpi = 100F;
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Text = "xrTableCell30";
            this.xrTableCell30.Weight = 1.4263245935071565D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Dpi = 100F;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Text = "xrTableCell31";
            this.xrTableCell31.Weight = 1.4263246291509679D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Dpi = 100F;
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Text = "xrTableCell53";
            this.xrTableCell53.Weight = 1.4263246291509679D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell54});
            this.xrTableRow8.Dpi = 100F;
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell24.Dpi = 100F;
            this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBackColor = false;
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.Text = "Grado:";
            this.xrTableCell24.Weight = 0.71316231775747618D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.mpgrado")});
            this.xrTableCell25.Dpi = 100F;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Weight = 0.71316231775747618D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Dpi = 100F;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Text = "xrTableCell26";
            this.xrTableCell26.Weight = 1.4263245935071565D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Dpi = 100F;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Text = "xrTableCell27";
            this.xrTableCell27.Weight = 1.4263246291509679D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Dpi = 100F;
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Text = "xrTableCell54";
            this.xrTableCell54.Weight = 1.4263246291509679D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell55});
            this.xrTableRow7.Dpi = 100F;
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell20.Dpi = 100F;
            this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBackColor = false;
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.Text = "Ámbito:";
            this.xrTableCell20.Weight = 0.71316231775747618D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.adescripcion")});
            this.xrTableCell21.Dpi = 100F;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Weight = 0.71316231775747618D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Dpi = 100F;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Text = "xrTableCell22";
            this.xrTableCell22.Weight = 1.4263245935071565D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Dpi = 100F;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Text = "xrTableCell23";
            this.xrTableCell23.Weight = 1.4263246291509679D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Dpi = 100F;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.Text = "xrTableCell55";
            this.xrTableCell55.Weight = 1.4263246291509679D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell18});
            this.xrTableRow6.Dpi = 100F;
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell16.Dpi = 100F;
            this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell16.ForeColor = System.Drawing.Color.White;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.RowSpan = 2;
            this.xrTableCell16.StylePriority.UseBackColor = false;
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UseForeColor = false;
            this.xrTableCell16.Text = "2. MISIÓN ";
            this.xrTableCell16.Weight = 2.8526492549059776D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell18.Dpi = 100F;
            this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell18.ForeColor = System.Drawing.Color.White;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBackColor = false;
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.StylePriority.UseForeColor = false;
            this.xrTableCell18.Text = "5. EXPERIENCIA LABORAL REQUERIDA";
            this.xrTableCell18.Weight = 2.8526492065341977D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell60,
            this.xrTableCell62,
            this.xrTableCell61,
            this.xrTableCell56});
            this.xrTableRow14.Dpi = 100F;
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.BackColor = System.Drawing.Color.SkyBlue;
            this.xrTableCell17.Dpi = 100F;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBackColor = false;
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.Weight = 2.8526492549059776D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell60.Dpi = 100F;
            this.xrTableCell60.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.RowSpan = 2;
            this.xrTableCell60.StylePriority.UseBackColor = false;
            this.xrTableCell60.StylePriority.UseFont = false;
            this.xrTableCell60.Text = "Tiempo de Experiencia:";
            this.xrTableCell60.Weight = 0.5080456708026686D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.texpdescripcion")});
            this.xrTableCell62.Dpi = 100F;
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Weight = 0.89450685251852657D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.texpdescripcion2")});
            this.xrTableCell61.Dpi = 100F;
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.Weight = 0.73693438157945312D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.texpdescripcion3")});
            this.xrTableCell56.Dpi = 100F;
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.Weight = 0.71316230163354943D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67});
            this.xrTableRow15.Dpi = 100F;
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.mpmision")});
            this.xrTableCell63.Dpi = 100F;
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.RowSpan = 6;
            this.xrTableCell63.Weight = 2.8526492549059776D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Dpi = 100F;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Text = "xrTableCell64";
            this.xrTableCell64.Weight = 0.5080456708026686D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivinndetalle")});
            this.xrTableCell65.Dpi = 100F;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Weight = 0.89450685251852657D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivinndetalle2")});
            this.xrTableCell66.Dpi = 100F;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Weight = 0.73693438157945312D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.nivinndetalle3")});
            this.xrTableCell67.Dpi = 100F;
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Weight = 0.71316230163354943D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell57});
            this.xrTableRow5.Dpi = 100F;
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Dpi = 100F;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Text = "xrTableCell14";
            this.xrTableCell14.Weight = 2.8526492290221088D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell15.Dpi = 100F;
            this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBackColor = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.Text = "Especificidad de la experiencia";
            this.xrTableCell15.Weight = 0.50804569252047838D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.eexpdescripcion")});
            this.xrTableCell57.Dpi = 100F;
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.Weight = 2.3446035657814575D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell73,
            this.xrTableCell74});
            this.xrTableRow17.Dpi = 100F;
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Dpi = 100F;
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.Weight = 2.8526492290221088D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell74.Dpi = 100F;
            this.xrTableCell74.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell74.ForeColor = System.Drawing.Color.White;
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseBackColor = false;
            this.xrTableCell74.StylePriority.UseFont = false;
            this.xrTableCell74.StylePriority.UseForeColor = false;
            this.xrTableCell74.Text = "6. CAPACITACIÓN REQUERIDA PARA EL PUESTO";
            this.xrTableCell74.Weight = 2.8526492583019358D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow18.Dpi = 100F;
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Weight = 1D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Dpi = 100F;
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.Text = "xrTableCell77";
            this.xrTableCell77.Weight = 2.8526492290221088D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell78.Dpi = 100F;
            this.xrTableCell78.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.StylePriority.UseBackColor = false;
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.Text = "Temática de la Capacitación";
            this.xrTableCell78.Weight = 2.8526492583019358D;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell129,
            this.xrTableCell130});
            this.xrTableRow30.Dpi = 100F;
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 1D;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.Dpi = 100F;
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.Text = "xrTableCell129";
            this.xrTableCell129.Weight = 2.8526492290221088D;
            // 
            // xrTableCell130
            // 
            this.xrTableCell130.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell130.Dpi = 100F;
            this.xrTableCell130.Name = "xrTableCell130";
            this.xrTableCell130.RowSpan = 2;
            this.xrTableCell130.StylePriority.UseBackColor = false;
            this.xrTableCell130.Text = "xrTableCell130";
            this.xrTableCell130.Weight = 2.8526492583019358D;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell131,
            this.xrTableCell132});
            this.xrTableRow31.Dpi = 100F;
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 1D;
            // 
            // xrTableCell131
            // 
            this.xrTableCell131.Dpi = 100F;
            this.xrTableCell131.Name = "xrTableCell131";
            this.xrTableCell131.Text = "xrTableCell131";
            this.xrTableCell131.Weight = 2.8526492290221088D;
            // 
            // xrTableCell132
            // 
            this.xrTableCell132.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell132.Dpi = 100F;
            this.xrTableCell132.Name = "xrTableCell132";
            this.xrTableCell132.StylePriority.UseBackColor = false;
            this.xrTableCell132.Text = "xrTableCell132";
            this.xrTableCell132.Weight = 2.8526492583019358D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow4.Dpi = 100F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell10.Dpi = 100F;
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell10.ForeColor = System.Drawing.Color.White;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseForeColor = false;
            this.xrTableCell10.Text = "7. ACTIVIDADES ESENCIALES";
            this.xrTableCell10.Weight = 1.4263246355149524D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell11.Dpi = 100F;
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell11.ForeColor = System.Drawing.Color.White;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseForeColor = false;
            this.xrTableCell11.Text = "8. CONOCIMIENTOS ADICIONALES RELACIONADOS A LAS ACTIVIDADES ESENCIALES";
            this.xrTableCell11.Weight = 1.4263245935071565D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell12.Dpi = 100F;
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell12.ForeColor = System.Drawing.Color.White;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseForeColor = false;
            this.xrTableCell12.Text = "9. COMPETENCIAS TÉCNICAS";
            this.xrTableCell12.Weight = 2.8526492583019358D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell13,
            this.xrTableCell59});
            this.xrTableRow3.Dpi = 100F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "QueryDetalle.mpdactividad")});
            this.xrTableCell7.Dpi = 100F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.RowSpan = 16;
            this.xrTableCell7.Weight = 1.4263246355149524D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "QueryDetalle.mpddescripcion")});
            this.xrTableCell8.Dpi = 100F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.RowSpan = 16;
            this.xrTableCell8.Weight = 1.4263245935071565D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell9.Dpi = 100F;
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.Text = "Denominación de la Competencia";
            this.xrTableCell9.Weight = 1.0531900273535955D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell13.Dpi = 100F;
            this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.Text = "Nivel";
            this.xrTableCell13.Weight = 1.0862969163728564D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell59.Dpi = 100F;
            this.xrTableCell59.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.StylePriority.UseBackColor = false;
            this.xrTableCell59.StylePriority.UseFont = false;
            this.xrTableCell59.Text = "Comportamiento Observable";
            this.xrTableCell59.Weight = 0.713162314575484D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70,
            this.xrTableCell58,
            this.xrTableCell71});
            this.xrTableRow16.Dpi = 100F;
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Dpi = 100F;
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Text = "xrTableCell68";
            this.xrTableCell68.Weight = 1.4263246355149524D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Dpi = 100F;
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Text = "xrTableCell69";
            this.xrTableCell69.Weight = 1.4263245935071565D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Dpi = 100F;
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.Text = "xrTableCell70";
            this.xrTableCell70.Weight = 1.0531900273535955D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Dpi = 100F;
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.Text = "xrTableCell58";
            this.xrTableCell58.Weight = 1.0862969163728564D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Dpi = 100F;
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Text = "xrTableCell71";
            this.xrTableCell71.Weight = 0.713162314575484D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell84,
            this.xrTableCell85});
            this.xrTableRow20.Dpi = 100F;
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Dpi = 100F;
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.Weight = 1.4263246355149524D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.Dpi = 100F;
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.Weight = 1.4263245935071565D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Dpi = 100F;
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.Text = "xrTableCell83";
            this.xrTableCell83.Weight = 1.0531900273535955D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Dpi = 100F;
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.Text = "xrTableCell84";
            this.xrTableCell84.Weight = 1.0862969163728564D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Dpi = 100F;
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.Text = "xrTableCell85";
            this.xrTableCell85.Weight = 0.713162314575484D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell72,
            this.xrTableCell75,
            this.xrTableCell76,
            this.xrTableCell79,
            this.xrTableCell80});
            this.xrTableRow19.Dpi = 100F;
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Dpi = 100F;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.Text = "xrTableCell72";
            this.xrTableCell72.Weight = 1.4263246355149524D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Dpi = 100F;
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Text = "xrTableCell75";
            this.xrTableCell75.Weight = 1.4263245935071565D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Dpi = 100F;
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.Text = "xrTableCell76";
            this.xrTableCell76.Weight = 1.0531900273535955D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Dpi = 100F;
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.Text = "xrTableCell79";
            this.xrTableCell79.Weight = 1.0862969163728564D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Dpi = 100F;
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.Text = "xrTableCell80";
            this.xrTableCell80.Weight = 0.713162314575484D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90});
            this.xrTableRow21.Dpi = 100F;
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Dpi = 100F;
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.Weight = 1.4263246355149524D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Dpi = 100F;
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.Weight = 1.4263245935071565D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Dpi = 100F;
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.Text = "xrTableCell88";
            this.xrTableCell88.Weight = 1.0531900273535955D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Dpi = 100F;
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.Text = "xrTableCell89";
            this.xrTableCell89.Weight = 1.0862969163728564D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Dpi = 100F;
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.Text = "xrTableCell90";
            this.xrTableCell90.Weight = 0.713162314575484D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93,
            this.xrTableCell94,
            this.xrTableCell95});
            this.xrTableRow22.Dpi = 100F;
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.Weight = 1D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Dpi = 100F;
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.Text = "xrTableCell91";
            this.xrTableCell91.Weight = 1.4263246355149524D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Dpi = 100F;
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Text = "xrTableCell92";
            this.xrTableCell92.Weight = 1.4263245935071565D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Dpi = 100F;
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.Text = "xrTableCell93";
            this.xrTableCell93.Weight = 1.0531900273535955D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Dpi = 100F;
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Text = "xrTableCell94";
            this.xrTableCell94.Weight = 1.0862969163728564D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.Dpi = 100F;
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.Text = "xrTableCell95";
            this.xrTableCell95.Weight = 0.713162314575484D;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell96,
            this.xrTableCell97,
            this.xrTableCell100});
            this.xrTableRow23.Dpi = 100F;
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.Dpi = 100F;
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.Text = "xrTableCell96";
            this.xrTableCell96.Weight = 1.4263246355149524D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.Dpi = 100F;
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.Text = "xrTableCell97";
            this.xrTableCell97.Weight = 1.4263245935071565D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.BackColor = System.Drawing.Color.DarkBlue;
            this.xrTableCell100.Dpi = 100F;
            this.xrTableCell100.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell100.ForeColor = System.Drawing.Color.White;
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.StylePriority.UseBackColor = false;
            this.xrTableCell100.StylePriority.UseFont = false;
            this.xrTableCell100.StylePriority.UseForeColor = false;
            this.xrTableCell100.Text = "10. COMPETENCIAS CONDUCTUALES";
            this.xrTableCell100.Weight = 2.8526492583019358D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell98,
            this.xrTableCell99,
            this.xrTableCell102,
            this.xrTableCell103,
            this.xrTableCell101});
            this.xrTableRow24.Dpi = 100F;
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 1D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Dpi = 100F;
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.Text = "xrTableCell98";
            this.xrTableCell98.Weight = 1.4263246355149524D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.Dpi = 100F;
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.Text = "xrTableCell99";
            this.xrTableCell99.Weight = 1.4263245935071565D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell102.Dpi = 100F;
            this.xrTableCell102.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseBackColor = false;
            this.xrTableCell102.StylePriority.UseFont = false;
            this.xrTableCell102.Text = "Denominación de la Competencia";
            this.xrTableCell102.Weight = 1.0531900273535955D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell103.Dpi = 100F;
            this.xrTableCell103.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.StylePriority.UseBackColor = false;
            this.xrTableCell103.StylePriority.UseFont = false;
            this.xrTableCell103.Text = "Nivel";
            this.xrTableCell103.Weight = 1.0862969163728564D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.BackColor = System.Drawing.Color.PaleTurquoise;
            this.xrTableCell101.Dpi = 100F;
            this.xrTableCell101.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.StylePriority.UseBackColor = false;
            this.xrTableCell101.StylePriority.UseFont = false;
            this.xrTableCell101.Text = "Comportamiento Observable";
            this.xrTableCell101.Weight = 0.713162314575484D;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell124,
            this.xrTableCell125,
            this.xrTableCell126,
            this.xrTableCell127,
            this.xrTableCell128});
            this.xrTableRow29.Dpi = 100F;
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Weight = 1D;
            // 
            // xrTableCell124
            // 
            this.xrTableCell124.Dpi = 100F;
            this.xrTableCell124.Name = "xrTableCell124";
            this.xrTableCell124.Text = "xrTableCell124";
            this.xrTableCell124.Weight = 1.4263246355149524D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Dpi = 100F;
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.Text = "xrTableCell125";
            this.xrTableCell125.Weight = 1.4263245935071565D;
            // 
            // xrTableCell126
            // 
            this.xrTableCell126.Dpi = 100F;
            this.xrTableCell126.Name = "xrTableCell126";
            this.xrTableCell126.Text = "xrTableCell126";
            this.xrTableCell126.Weight = 1.0531900273535955D;
            // 
            // xrTableCell127
            // 
            this.xrTableCell127.Dpi = 100F;
            this.xrTableCell127.Name = "xrTableCell127";
            this.xrTableCell127.Text = "xrTableCell127";
            this.xrTableCell127.Weight = 1.0862969163728564D;
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.Dpi = 100F;
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.Text = "xrTableCell128";
            this.xrTableCell128.Weight = 0.713162314575484D;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell119,
            this.xrTableCell120,
            this.xrTableCell121,
            this.xrTableCell122,
            this.xrTableCell123});
            this.xrTableRow28.Dpi = 100F;
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 1D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.Dpi = 100F;
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.Text = "xrTableCell119";
            this.xrTableCell119.Weight = 1.4263246355149524D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Dpi = 100F;
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Text = "xrTableCell120";
            this.xrTableCell120.Weight = 1.4263245935071565D;
            // 
            // xrTableCell121
            // 
            this.xrTableCell121.Dpi = 100F;
            this.xrTableCell121.Name = "xrTableCell121";
            this.xrTableCell121.Text = "xrTableCell121";
            this.xrTableCell121.Weight = 1.0531900273535955D;
            // 
            // xrTableCell122
            // 
            this.xrTableCell122.Dpi = 100F;
            this.xrTableCell122.Name = "xrTableCell122";
            this.xrTableCell122.Text = "xrTableCell122";
            this.xrTableCell122.Weight = 1.0862969163728564D;
            // 
            // xrTableCell123
            // 
            this.xrTableCell123.Dpi = 100F;
            this.xrTableCell123.Name = "xrTableCell123";
            this.xrTableCell123.Text = "xrTableCell123";
            this.xrTableCell123.Weight = 0.713162314575484D;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell114,
            this.xrTableCell115,
            this.xrTableCell116,
            this.xrTableCell117,
            this.xrTableCell118});
            this.xrTableRow27.Dpi = 100F;
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 1D;
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.Dpi = 100F;
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.Text = "xrTableCell114";
            this.xrTableCell114.Weight = 1.4263246355149524D;
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.Dpi = 100F;
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.Text = "xrTableCell115";
            this.xrTableCell115.Weight = 1.4263245935071565D;
            // 
            // xrTableCell116
            // 
            this.xrTableCell116.Dpi = 100F;
            this.xrTableCell116.Name = "xrTableCell116";
            this.xrTableCell116.Text = "xrTableCell116";
            this.xrTableCell116.Weight = 1.0531900273535955D;
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.Dpi = 100F;
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.Text = "xrTableCell117";
            this.xrTableCell117.Weight = 1.0862969163728564D;
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.Dpi = 100F;
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.Text = "xrTableCell118";
            this.xrTableCell118.Weight = 0.713162314575484D;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell109,
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112,
            this.xrTableCell113});
            this.xrTableRow26.Dpi = 100F;
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 1D;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.Dpi = 100F;
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.Text = "xrTableCell109";
            this.xrTableCell109.Weight = 1.4263246355149524D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Dpi = 100F;
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.Text = "xrTableCell110";
            this.xrTableCell110.Weight = 1.4263245935071565D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Dpi = 100F;
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.Text = "xrTableCell111";
            this.xrTableCell111.Weight = 1.0531900273535955D;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.Dpi = 100F;
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.Text = "xrTableCell112";
            this.xrTableCell112.Weight = 1.0862969163728564D;
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.Dpi = 100F;
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.Text = "xrTableCell113";
            this.xrTableCell113.Weight = 0.713162314575484D;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell104,
            this.xrTableCell105,
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108});
            this.xrTableRow25.Dpi = 100F;
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 1D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.Dpi = 100F;
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.Text = "xrTableCell104";
            this.xrTableCell104.Weight = 1.4263246355149524D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Dpi = 100F;
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.Text = "xrTableCell105";
            this.xrTableCell105.Weight = 1.4263245935071565D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.Dpi = 100F;
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.Text = "xrTableCell106";
            this.xrTableCell106.Weight = 1.0531900273535955D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Dpi = 100F;
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.Text = "xrTableCell107";
            this.xrTableCell107.Weight = 1.0862969163728564D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.Dpi = 100F;
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.Text = "xrTableCell108";
            this.xrTableCell108.Weight = 0.713162314575484D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "win-sqlserv-01_RRHH_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            queryParameter1.Name = "id";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "1";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "QueryDetalle";
            queryParameter2.Name = "id";
            queryParameter2.Type = typeof(int);
            queryParameter2.ValueInfo = "1";
            customSqlQuery2.Parameters.Add(queryParameter2);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Type = typeof(int);
            this.id.ValueInfo = "0";
            // 
            // xrLabel53
            // 
            this.xrLabel53.Dpi = 100F;
            this.xrLabel53.Font = new System.Drawing.Font("Arial", 20F);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(314.3333F, 21.45834F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(382.7917F, 39F);
            this.xrLabel53.StyleName = "Title";
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.Text = "Descripción y perfil del puesto";
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPictureBox1,
            this.xrLabel53});
            this.reportHeaderBand1.Dpi = 100F;
            this.reportHeaderBand1.HeightF = 86.16667F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.mpid")});
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(766.7917F, 21.45834F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 100F;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(1210F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(230F, 80F);
            // 
            // XtraReportMaestro
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(3, 0, 0, 100);
            this.PageHeight = 1268;
            this.PageWidth = 1752;
            this.PaperKind = System.Drawing.Printing.PaperKind.A3ExtraTransverse;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.id});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "16.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableMatrizPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
