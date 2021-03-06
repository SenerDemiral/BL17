﻿namespace BL17.AccountAk
{
    partial class AkhXF
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
            this.fieldAKID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHSPNO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldKAKMID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMAKMID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGDRTUT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXHSP1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXHSP2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXHSP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.akhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountAkDataSet = new BL17.AccountAk.AccountAkDataSet();
            this.akhTableAdapter = new BL17.AccountAk.AccountAkDataSetTableAdapters.AKHTableAdapter();
            this.fieldGLRTUT = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.akhBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldAKID,
            this.fieldHSPNO,
            this.fieldKAKMID,
            this.fieldMAKMID,
            this.fieldGDRTUT,
            this.fieldXHSP1,
            this.fieldXHSP2,
            this.fieldXHSP,
            this.fieldGLRTUT});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(500, 320);
            this.pivotGridControl1.TabIndex = 1;
            // 
            // fieldAKID
            // 
            this.fieldAKID.AreaIndex = 0;
            this.fieldAKID.FieldName = "AKID";
            this.fieldAKID.Name = "fieldAKID";
            this.fieldAKID.Visible = false;
            // 
            // fieldHSPNO
            // 
            this.fieldHSPNO.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldHSPNO.AreaIndex = 0;
            this.fieldHSPNO.Caption = "HspNo";
            this.fieldHSPNO.FieldName = "HSPNO";
            this.fieldHSPNO.Name = "fieldHSPNO";
            // 
            // fieldKAKMID
            // 
            this.fieldKAKMID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldKAKMID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldKAKMID.AreaIndex = 0;
            this.fieldKAKMID.Caption = "KarMrkz";
            this.fieldKAKMID.FieldName = "KAKMID";
            this.fieldKAKMID.Name = "fieldKAKMID";
            // 
            // fieldMAKMID
            // 
            this.fieldMAKMID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldMAKMID.AreaIndex = 1;
            this.fieldMAKMID.Caption = "MsrfMrkz";
            this.fieldMAKMID.FieldName = "MAKMID";
            this.fieldMAKMID.Name = "fieldMAKMID";
            // 
            // fieldGDRTUT
            // 
            this.fieldGDRTUT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGDRTUT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGDRTUT.AreaIndex = 0;
            this.fieldGDRTUT.Caption = "Masraf";
            this.fieldGDRTUT.CellFormat.FormatString = "#,###;#,###; ";
            this.fieldGDRTUT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGDRTUT.FieldName = "GDRTUT";
            this.fieldGDRTUT.Name = "fieldGDRTUT";
            // 
            // fieldXHSP1
            // 
            this.fieldXHSP1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXHSP1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldXHSP1.AreaIndex = 0;
            this.fieldXHSP1.Caption = "xHsp1";
            this.fieldXHSP1.FieldName = "XHSP1";
            this.fieldXHSP1.Name = "fieldXHSP1";
            // 
            // fieldXHSP2
            // 
            this.fieldXHSP2.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXHSP2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldXHSP2.AreaIndex = 1;
            this.fieldXHSP2.Caption = "xHsp2";
            this.fieldXHSP2.FieldName = "XHSP2";
            this.fieldXHSP2.Name = "fieldXHSP2";
            // 
            // fieldXHSP
            // 
            this.fieldXHSP.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXHSP.AreaIndex = 2;
            this.fieldXHSP.Caption = "xHsp";
            this.fieldXHSP.FieldName = "XHSP";
            this.fieldXHSP.Name = "fieldXHSP";
            // 
            // akhBindingSource
            // 
            this.akhBindingSource.DataMember = "AKH";
            this.akhBindingSource.DataSource = this.accountAkDataSet;
            // 
            // accountAkDataSet
            // 
            this.accountAkDataSet.DataSetName = "AccountAkDataSet";
            this.accountAkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akhTableAdapter
            // 
            this.akhTableAdapter.ClearBeforeFill = true;
            // 
            // fieldGLRTUT
            // 
            this.fieldGLRTUT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGLRTUT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGLRTUT.AreaIndex = 1;
            this.fieldGLRTUT.Caption = "Gelir";
            this.fieldGLRTUT.CellFormat.FormatString = "#,###;#,###; ";
            this.fieldGLRTUT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGLRTUT.FieldName = "GLRTUT";
            this.fieldGLRTUT.Name = "fieldGLRTUT";
            // 
            // AkhXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "AkhXF";
            this.Text = "AkhXF";
            this.Load += new System.EventHandler(this.AkhXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountAkDataSet accountAkDataSet;
        private System.Windows.Forms.BindingSource akhBindingSource;
        private AccountAkDataSetTableAdapters.AKHTableAdapter akhTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAKID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHSPNO;
        private DevExpress.XtraPivotGrid.PivotGridField fieldKAKMID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMAKMID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGDRTUT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXHSP1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXHSP2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXHSP;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGLRTUT;
    }
}