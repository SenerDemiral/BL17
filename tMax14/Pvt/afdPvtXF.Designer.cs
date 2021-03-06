﻿namespace BL17.Pvt
{
    partial class afdPvtXF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pVTAFDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvtDataSet = new BL17.Pvt.PvtDataSet();
            this.fieldAFDID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAFBID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFTRDRM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFTRTRH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAHTAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFRTAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOPID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOPHM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOPSTU = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRGLRBRT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRGDRBRT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATDq = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATDm = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTOB = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATDy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldROT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMOT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldACC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldACCCNTRY = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDST = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldORG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pVT_AFDTableAdapter = new BL17.Pvt.PvtDataSetTableAdapters.PVT_AFDTableAdapter();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVTAFDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip;
            this.pivotGridControl1.DataSource = this.pVTAFDBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldAFDID,
            this.fieldTUR,
            this.fieldAFBID,
            this.fieldFTRDRM,
            this.fieldFTRTRH,
            this.fieldAHTAD,
            this.fieldFRTAD,
            this.fieldOPID,
            this.fieldOPHM,
            this.fieldATD,
            this.fieldOPSTU,
            this.fieldRGLRBRT,
            this.fieldRGDRBRT,
            this.fieldATDq,
            this.fieldATDm,
            this.fieldTOB,
            this.fieldATDy,
            this.fieldROT,
            this.fieldMOT,
            this.fieldACC,
            this.fieldACCCNTRY,
            this.fieldDST,
            this.fieldORG});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 131;
            this.pivotGridControl1.Size = new System.Drawing.Size(856, 273);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.layoutsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // pVTAFDBindingSource
            // 
            this.pVTAFDBindingSource.DataMember = "PVT_AFD";
            this.pVTAFDBindingSource.DataSource = this.pvtDataSet;
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldAFDID
            // 
            this.fieldAFDID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAFDID.AreaIndex = 0;
            this.fieldAFDID.Caption = "AFDID";
            this.fieldAFDID.FieldName = "AFDID";
            this.fieldAFDID.Name = "fieldAFDID";
            // 
            // fieldTUR
            // 
            this.fieldTUR.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUR.AreaIndex = 1;
            this.fieldTUR.Caption = "Tür";
            this.fieldTUR.FieldName = "TUR";
            this.fieldTUR.Name = "fieldTUR";
            // 
            // fieldAFBID
            // 
            this.fieldAFBID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAFBID.AreaIndex = 2;
            this.fieldAFBID.Caption = "AFBID";
            this.fieldAFBID.FieldName = "AFBID";
            this.fieldAFBID.Name = "fieldAFBID";
            // 
            // fieldFTRDRM
            // 
            this.fieldFTRDRM.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldFTRDRM.AreaIndex = 3;
            this.fieldFTRDRM.Caption = "FtrDrm";
            this.fieldFTRDRM.FieldName = "FTRDRM";
            this.fieldFTRDRM.Name = "fieldFTRDRM";
            // 
            // fieldFTRTRH
            // 
            this.fieldFTRTRH.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldFTRTRH.AreaIndex = 4;
            this.fieldFTRTRH.Caption = "FtrTrh";
            this.fieldFTRTRH.FieldName = "FTRTRH";
            this.fieldFTRTRH.Name = "fieldFTRTRH";
            // 
            // fieldAHTAD
            // 
            this.fieldAHTAD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAHTAD.AreaIndex = 5;
            this.fieldAHTAD.Caption = "Charge";
            this.fieldAHTAD.FieldName = "AHTAD";
            this.fieldAHTAD.Name = "fieldAHTAD";
            // 
            // fieldFRTAD
            // 
            this.fieldFRTAD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldFRTAD.AreaIndex = 6;
            this.fieldFRTAD.Caption = "Firma";
            this.fieldFRTAD.FieldName = "FRTAD";
            this.fieldFRTAD.Name = "fieldFRTAD";
            // 
            // fieldOPID
            // 
            this.fieldOPID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOPID.AreaIndex = 7;
            this.fieldOPID.Caption = "OpID";
            this.fieldOPID.FieldName = "OPID";
            this.fieldOPID.Name = "fieldOPID";
            // 
            // fieldOPHM
            // 
            this.fieldOPHM.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOPHM.AreaIndex = 8;
            this.fieldOPHM.Caption = "OpHM";
            this.fieldOPHM.FieldName = "OPHM";
            this.fieldOPHM.Name = "fieldOPHM";
            // 
            // fieldATD
            // 
            this.fieldATD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATD.AreaIndex = 10;
            this.fieldATD.Caption = "ATD";
            this.fieldATD.FieldName = "ATD";
            this.fieldATD.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldATD.Name = "fieldATD";
            this.fieldATD.UnboundFieldName = "fieldATD";
            // 
            // fieldOPSTU
            // 
            this.fieldOPSTU.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOPSTU.AreaIndex = 9;
            this.fieldOPSTU.Caption = "OpStu";
            this.fieldOPSTU.FieldName = "OPSTU";
            this.fieldOPSTU.Name = "fieldOPSTU";
            // 
            // fieldRGLRBRT
            // 
            this.fieldRGLRBRT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRGLRBRT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRGLRBRT.AreaIndex = 0;
            this.fieldRGLRBRT.Caption = "Gelir";
            this.fieldRGLRBRT.CellFormat.FormatString = "n";
            this.fieldRGLRBRT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRGLRBRT.FieldName = "RGLRBRT";
            this.fieldRGLRBRT.Name = "fieldRGLRBRT";
            // 
            // fieldRGDRBRT
            // 
            this.fieldRGDRBRT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRGDRBRT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRGDRBRT.AreaIndex = 1;
            this.fieldRGDRBRT.Caption = "Gider";
            this.fieldRGDRBRT.CellFormat.FormatString = "n";
            this.fieldRGDRBRT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRGDRBRT.FieldName = "RGDRBRT";
            this.fieldRGDRBRT.Name = "fieldRGDRBRT";
            // 
            // fieldATDq
            // 
            this.fieldATDq.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATDq.AreaIndex = 12;
            this.fieldATDq.Caption = "ATDq";
            this.fieldATDq.FieldName = "ATD";
            this.fieldATDq.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldATDq.Name = "fieldATDq";
            this.fieldATDq.UnboundFieldName = "fieldATDq";
            // 
            // fieldATDm
            // 
            this.fieldATDm.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATDm.AreaIndex = 13;
            this.fieldATDm.Caption = "ATDm";
            this.fieldATDm.FieldName = "ATD";
            this.fieldATDm.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldATDm.Name = "fieldATDm";
            this.fieldATDm.UnboundFieldName = "fieldATDm";
            // 
            // fieldTOB
            // 
            this.fieldTOB.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTOB.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldTOB.AreaIndex = 0;
            this.fieldTOB.FieldName = "TOB";
            this.fieldTOB.Name = "fieldTOB";
            this.fieldTOB.Width = 118;
            // 
            // fieldATDy
            // 
            this.fieldATDy.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATDy.AreaIndex = 11;
            this.fieldATDy.Caption = "ATDy";
            this.fieldATDy.FieldName = "ATD";
            this.fieldATDy.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldATDy.Name = "fieldATDy";
            this.fieldATDy.UnboundFieldName = "fieldATDy";
            // 
            // fieldROT
            // 
            this.fieldROT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldROT.AreaIndex = 14;
            this.fieldROT.FieldName = "ROT";
            this.fieldROT.Name = "fieldROT";
            // 
            // fieldMOT
            // 
            this.fieldMOT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldMOT.AreaIndex = 15;
            this.fieldMOT.FieldName = "MOT";
            this.fieldMOT.Name = "fieldMOT";
            // 
            // fieldACC
            // 
            this.fieldACC.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldACC.AreaIndex = 16;
            this.fieldACC.Caption = "Acc";
            this.fieldACC.FieldName = "ACC";
            this.fieldACC.Name = "fieldACC";
            // 
            // fieldACCCNTRY
            // 
            this.fieldACCCNTRY.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldACCCNTRY.AreaIndex = 17;
            this.fieldACCCNTRY.Caption = "AccCntry";
            this.fieldACCCNTRY.FieldName = "ACCCNTRY";
            this.fieldACCCNTRY.Name = "fieldACCCNTRY";
            // 
            // fieldDST
            // 
            this.fieldDST.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldDST.AreaIndex = 18;
            this.fieldDST.Caption = "Dst";
            this.fieldDST.FieldName = "DST";
            this.fieldDST.Name = "fieldDST";
            // 
            // fieldORG
            // 
            this.fieldORG.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldORG.AreaIndex = 19;
            this.fieldORG.Caption = "Org";
            this.fieldORG.FieldName = "ORG";
            this.fieldORG.Name = "fieldORG";
            // 
            // pVT_AFDTableAdapter
            // 
            this.pVT_AFDTableAdapter.ClearBeforeFill = true;
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // afdPvtXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 273);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "afdPvtXF";
            this.Text = "Charge Pivot [afdPvtXF]";
            this.Load += new System.EventHandler(this.afdPvtXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pVTAFDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource pVTAFDBindingSource;
        private PvtDataSetTableAdapters.PVT_AFDTableAdapter pVT_AFDTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAFDID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAFBID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFTRDRM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFTRTRH;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAHTAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRTAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPHM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPSTU;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRGLRBRT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRGDRBRT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATDq;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATDm;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTOB;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATDy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraPivotGrid.PivotGridField fieldROT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMOT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldACC;
        private DevExpress.XtraPivotGrid.PivotGridField fieldACCCNTRY;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDST;
        private DevExpress.XtraPivotGrid.PivotGridField fieldORG;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
    }
}