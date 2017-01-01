namespace BL17.Ops
{
    partial class ProjeXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.opsDataSet = new BL17.Ops.OpsDataSet();
            this.prtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prtTableAdapter = new BL17.Ops.OpsDataSetTableAdapters.PRTTableAdapter();
            this.tableAdapterManager = new BL17.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.prtGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sablonlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prtGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TURrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colOZLDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prtBindingSource
            // 
            this.prtBindingSource.DataMember = "PRT";
            this.prtBindingSource.DataSource = this.opsDataSet;
            // 
            // prtTableAdapter
            // 
            this.prtTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = this.prtTableAdapter;
            this.tableAdapterManager.UpdateOrder = BL17.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prtGridControl
            // 
            this.prtGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.prtGridControl.DataSource = this.prtBindingSource;
            this.prtGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prtGridControl.Location = new System.Drawing.Point(0, 0);
            this.prtGridControl.MainView = this.prtGridView;
            this.prtGridControl.Name = "prtGridControl";
            this.prtGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit,
            this.TURrepositoryItemImageComboBox,
            this.repositoryItemRichTextEdit});
            this.prtGridControl.Size = new System.Drawing.Size(473, 404);
            this.prtGridControl.TabIndex = 1;
            this.prtGridControl.Tag = "PRT";
            this.prtGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.prtGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sablonlariToolStripMenuItem,
            this.editInfoToolStripMenuItem,
            this.jurnalToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // sablonlariToolStripMenuItem
            // 
            this.sablonlariToolStripMenuItem.Name = "sablonlariToolStripMenuItem";
            this.sablonlariToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sablonlariToolStripMenuItem.Text = "Sablon sec";
            this.sablonlariToolStripMenuItem.Click += new System.EventHandler(this.sablonlariToolStripMenuItem_Click);
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editInfoToolStripMenuItem.Text = "Edit Info";
            this.editInfoToolStripMenuItem.Click += new System.EventHandler(this.editInfoToolStripMenuItem_Click);
            // 
            // prtGridView
            // 
            this.prtGridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prtGridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.prtGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRTID,
            this.colTUR,
            this.colAD,
            this.colSDATE,
            this.colEDATE,
            this.colTXT,
            this.colOZLDRM});
            this.prtGridView.GridControl = this.prtGridControl;
            this.prtGridView.Name = "prtGridView";
            this.prtGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.prtGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.prtGridView_InitNewRow);
            // 
            // colPRTID
            // 
            this.colPRTID.FieldName = "PRTID";
            this.colPRTID.Name = "colPRTID";
            this.colPRTID.OptionsColumn.AllowEdit = false;
            this.colPRTID.OptionsColumn.AllowFocus = false;
            this.colPRTID.OptionsColumn.FixedWidth = true;
            this.colPRTID.Visible = true;
            this.colPRTID.VisibleIndex = 0;
            this.colPRTID.Width = 60;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.ColumnEdit = this.TURrepositoryItemImageComboBox;
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 1;
            this.colTUR.Width = 46;
            // 
            // TURrepositoryItemImageComboBox
            // 
            this.TURrepositoryItemImageComboBox.AutoHeight = false;
            this.TURrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TURrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bir", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Iki", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Uc", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dort", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bes", "5", -1)});
            this.TURrepositoryItemImageComboBox.Name = "TURrepositoryItemImageComboBox";
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 88;
            // 
            // colSDATE
            // 
            this.colSDATE.Caption = "StartDate";
            this.colSDATE.FieldName = "SDATE";
            this.colSDATE.Name = "colSDATE";
            this.colSDATE.OptionsColumn.FixedWidth = true;
            this.colSDATE.Visible = true;
            this.colSDATE.VisibleIndex = 3;
            this.colSDATE.Width = 68;
            // 
            // colEDATE
            // 
            this.colEDATE.Caption = "EndDate";
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.FixedWidth = true;
            this.colEDATE.Visible = true;
            this.colEDATE.VisibleIndex = 4;
            this.colEDATE.Width = 68;
            // 
            // colTXT
            // 
            this.colTXT.Caption = "Info";
            this.colTXT.ColumnEdit = this.repositoryItemRichTextEdit;
            this.colTXT.FieldName = "TXT";
            this.colTXT.Name = "colTXT";
            this.colTXT.OptionsColumn.AllowEdit = false;
            this.colTXT.OptionsColumn.AllowFocus = false;
            this.colTXT.Visible = true;
            this.colTXT.VisibleIndex = 6;
            this.colTXT.Width = 125;
            // 
            // repositoryItemRichTextEdit
            // 
            this.repositoryItemRichTextEdit.Name = "repositoryItemRichTextEdit";
            this.repositoryItemRichTextEdit.ShowCaretInReadOnly = false;
            // 
            // colOZLDRM
            // 
            this.colOZLDRM.Caption = "ÖzelDurum";
            this.colOZLDRM.ColumnEdit = this.repositoryItemMemoExEdit;
            this.colOZLDRM.FieldName = "OZLDRM";
            this.colOZLDRM.Name = "colOZLDRM";
            this.colOZLDRM.Visible = true;
            this.colOZLDRM.VisibleIndex = 5;
            // 
            // repositoryItemMemoExEdit
            // 
            this.repositoryItemMemoExEdit.AutoHeight = false;
            this.repositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit.Name = "repositoryItemMemoExEdit";
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            this.jurnalToolStripMenuItem.Click += new System.EventHandler(this.jurnalToolStripMenuItem_Click);
            // 
            // ProjeXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prtGridControl);
            this.Name = "ProjeXUC";
            this.Size = new System.Drawing.Size(473, 404);
            this.Load += new System.EventHandler(this.ProjeXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource prtBindingSource;
        private OpsDataSetTableAdapters.PRTTableAdapter prtTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl prtGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView prtGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colSDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colTXT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TURrepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sablonlariToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colOZLDRM;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
    }
}
