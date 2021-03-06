﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BL17.Qry
{
    public partial class qsOpmXF : DevExpress.XtraEditors.XtraUserControl
    {
        public Ops.OpsDataSet.OPM_SELDataTable OPM;
        public string qsQry;

        public qsOpmXF()
        {
            InitializeComponent();

            qsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTAGS.ColumnEdit = Program.MF.TAGselOPSrepositoryItemCheckedComboBoxEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemCheckedComboBoxEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemCheckedComboBoxEdit;
            colOrgCntry.ColumnEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            colDstCntry.ColumnEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            colFirma.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colOnyYtk.ColumnEdit = Program.MF.YTKrepositoryItemCheckedComboBoxEdit;
            colOnyUsr.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            colOwnr.ColumnEdit = Program.MF.OWNRrepositoryItemCheckedComboBoxEdit; //Program.MF.OWNRrepositoryItemImageComboBox;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemCheckedComboBoxEdit;  //Program.MF.TOBrepositoryItemLookUpEdit;

            colNrmStu.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemCheckedComboBoxEdit;
            colPrbStu.ColumnEdit = Program.MF.OpsStuPrbRepositoryItemCheckedComboBoxEdit;

            colTAGS.ColumnEdit = Program.MF.TAGselOPSrepositoryItemCheckedComboBoxEdit;
            colBKMS.ColumnEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;

            qsGridControl.UseEmbeddedNavigator = true;
            qsGridControl.EmbeddedNavigator.Buttons.First.Visible = false;
            qsGridControl.EmbeddedNavigator.Buttons.Last.Visible = false;
            qsGridControl.EmbeddedNavigator.Buttons.Next.Visible = false;
            qsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            qsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = false;
            qsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            qsGridControl.EmbeddedNavigator.TextLocation = NavigatorButtonsTextLocation.None;

            qsLayoutView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            qsLayoutView.OptionsBehavior.AutoFocusCardOnScrolling = true;
            qsLayoutView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            qsLayoutView.OptionsBehavior.AutoFocusNewCard = true;
            qsLayoutView.OptionsView.ShowHeaderPanel = false;
            qsLayoutView.OptionsView.ShowCardExpandButton = false;
            qsLayoutView.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AlignGlobal;
            qsLayoutView.OptionsItemText.TextToControlDistance = 10;
            qsLayoutView.OptionsCustomization.AllowFilter = false;
            qsLayoutView.OptionsCustomization.AllowSort = false;

            qsGridControl.VisibleChanged += qsGridControl_VisibleChanged;
            Program.MF.QSrestore("qsOPM", 0, qryDataSet.qsOPM);
            if (qryDataSet.qsOPM.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsOPM.NewqsOPMRow();
                newRow.BKMD = false;
                //newRow.EXDGE = DateTime.Today.AddDays(-90);
                qryDataSet.qsOPM.Rows.Add(newRow);
            }
        }

        int frh = 0;
        private void qsGridControl_VisibleChanged(object sender, EventArgs e)
        {
            qsLayoutView.FocusedRowHandle = frh;
        }

        private void qsOpmXF_Load(object sender, EventArgs e)
        {
        }

        private void qsLayoutView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            qsLayoutView.SetRowCellValue(e.RowHandle, colBKMD, false);
        }

        private void searchSimpleButton_Click(object sender, EventArgs e)
        {
            qsLayoutView.FocusedColumn = colQRY;    // Change Column to prepareQry
            frh = qsLayoutView.FocusedRowHandle;
            Program.MF.QSsave("qsOPM", 0, qryDataSet.qsOPM);
            qsQry = qsLayoutView.GetFocusedRowCellDisplayText(colQRY);
            
            int nor = 0;
            Program.MF.startSW();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = opmTableAdapter.Fill(OPM, qsQry, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("OpsMaster", nor);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                    (this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel).HideImmediately();
            }
        }

        private void qsLayoutView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                e.Value = DBNull.Value;
        }

        private void qsLayoutView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchSimpleButton.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Insert && e.Control)
            {
                qsLayoutView.AddNewRow();
                e.Handled = true;
            }
        }

        private void prepareQry()
        {
            DevExpress.XtraGrid.Views.Layout.LayoutView view = qsLayoutView;

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colEXDGE)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("EXD >= '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colEXDGE)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colATDGE)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("ATD >= '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colATDGE)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colATDLT)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("ATD < '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colATDLT)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOPMID)))
            {
                string str = view.GetFocusedRowCellDisplayText(colOPMID);
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append(string.Format("OPMID in ({0})", str));
                }

                /*
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OPMid = {0}", view.GetFocusedRowCellDisplayText(colOPMID)));*/
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colRefNo)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(RefNo) containing upper('{0}')", view.GetFocusedRowCellDisplayText(colRefNo).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colVhc)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(Vhc) containing upper('{0}')", view.GetFocusedRowCellDisplayText(colVhc).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colCntNo)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("exists (select * from OPP where OPID = OPM.OPMID and upper(CntNo) containing upper('{0}'))", view.GetFocusedRowCellDisplayText(colCntNo).Replace("'", "''")));
            }

            
            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colFirma)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("{0} in (ShpID,CneID,CrrID,CraID,NfyID)", view.GetFocusedRowCellValue(colFirma)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTAGS)))
            {
                string TAGS = view.GetFocusedRowCellValue(colTAGS).ToString();
                if (!string.IsNullOrEmpty(TAGS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = TAGS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOwnr)))
            {
                string val = view.GetFocusedRowCellValue(colOwnr).ToString();
                if (!string.IsNullOrEmpty(val))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("OWNR in (");
                    string[] sa = val.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTOB)))
            {
                string val = view.GetFocusedRowCellValue(colTOB).ToString();
                if (!string.IsNullOrEmpty(val))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("TOB in (");
                    string[] sa = val.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colROT)))
            {
                string ROT = view.GetFocusedRowCellValue(colROT).ToString();
                if (!string.IsNullOrEmpty(ROT))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("ROT in (");
                    string[] sa = ROT.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colMOT)))
            {
                string MOT = view.GetFocusedRowCellValue(colMOT).ToString();
                if (!string.IsNullOrEmpty(MOT))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("MOT in (");
                    string[] sa = MOT.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOrgCntry)))
            {
                string OrgCntry = view.GetFocusedRowCellValue(colOrgCntry).ToString();
                if (!string.IsNullOrEmpty(OrgCntry))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("(");
                    string[] sa = OrgCntry.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("ORG starting '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colDstCntry)))
            {
                string DstCntry = view.GetFocusedRowCellValue(colDstCntry).ToString();
                if (!string.IsNullOrEmpty(DstCntry))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("(");
                    string[] sa = DstCntry.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("DST starting '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colBKMS)))
            {
                string BKMS = view.GetFocusedRowCellValue(colBKMS).ToString();
                if (!string.IsNullOrEmpty(BKMS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = BKMS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("BKMS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOnyYtk)))
            {
                string OnyYtk = view.GetFocusedRowCellValue(colOnyYtk).ToString();
                if (!string.IsNullOrEmpty(OnyYtk))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("OnyYtk in (");
                    string[] sa = OnyYtk.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOnyUsr)))
            {
                string OnyUsr = view.GetFocusedRowCellValue(colOnyUsr).ToString();
                if (!string.IsNullOrEmpty(OnyUsr))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("OnyUsr in (");
                    string[] sa = OnyUsr.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colNrmStu)))
            {
                string NrmStu = view.GetFocusedRowCellValue(colNrmStu).ToString();
                if (!string.IsNullOrEmpty(NrmStu))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("NSTU in (");
                    string[] sa = NrmStu.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colPrbStu)))
            {
                string PrbStu = view.GetFocusedRowCellValue(colPrbStu).ToString();
                if (!string.IsNullOrEmpty(PrbStu))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("PSTU in (");
                    string[] sa = PrbStu.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOnyTrhGE)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OnyTrh >= '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colOnyTrhGE)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colOnyTrhLT)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OnyTrh < '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colOnyTrhLT)));
            }
            
            view.SetFocusedRowCellValue(colQRY, sb.ToString());


        }

        private void qsLayoutView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (qsLayoutView.RowCount > 0)
                prepareQry();
        }

        private void qsLayoutView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = qsLayoutView;

            if (e.Column == colBKMD)
            {
                StringBuilder bkms = new StringBuilder();
                bkms.Append(view.GetFocusedRowCellValue(colBKMS));

                if ((bool)e.Value == true)
                {
                    if (!bkms.ToString().Contains(Program.USRtag))
                    {
                        if (bkms.Length > 0)
                            bkms.Append(", ");
                        bkms.Append(Program.USRtag);
                    }
                }
                else
                {
                    bkms.Replace(", " + Program.USRtag, "");
                    bkms.Replace(Program.USRtag, "");
                }
                view.SetFocusedRowCellValue(colBKMS, bkms.ToString());
            }
        }

        private void qsGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
