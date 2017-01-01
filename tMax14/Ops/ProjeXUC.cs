using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BL17.Ops
{
    public partial class ProjeXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public ProjeXUC()
        {
            InitializeComponent();
        }

        public void Save()
        {
            this.Validate();
            this.prtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.opsDataSet);

        }

        private void ProjeXUC_Load(object sender, EventArgs e)
        {
            prtTableAdapter.Fill(opsDataSet.PRT);

            prtGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTUR.ColumnEdit = Program.MF.prtTurRepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(prtGridControl);
        }

        private void prtGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colPRTID, Program.MF.mainQueriesTableAdapter.GET_PK("PRJ"));
        }

        private void sablonlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeSablonXUC frm = new ProjeSablonXUC();
            if (frm.ShowDialog() == DialogResult.OK)
                prtGridView.SetFocusedRowCellValue(colTXT, frm.prsRow.SABLON);

        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeSablonEditXF frm = new ProjeSablonEditXF();
            frm.Text = "Proje Info";
            frm.richText = prtGridView.GetFocusedRowCellValue(colTXT).ToString();
            frm.ShowDialog();
            prtGridView.SetFocusedRowCellValue(colTXT, frm.richText);
            frm.Dispose();
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PK = (int)prtGridView.GetFocusedRowCellValue(colPRTID);
            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "PRT";
            frm.RefID = PK;
            frm.ShowDialog();
            frm.Dispose();

        }
    }
}
