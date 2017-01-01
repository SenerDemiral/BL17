using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BL17.Account
{
    public partial class FaturaKapaXF : DevExpress.XtraEditors.XtraForm
    {
        private int afbID;
        private string tur;

        public FaturaKapaXF(int afbID, string tur)
        {
            InitializeComponent();

            this.afbID = afbID;
            this.tur = tur;

            if (tur.Substring(1, 1) != "D")
                dknNoTextEdit.Enabled = false;

            contextMenuStrip1.Enabled = false;
            if (tur == "BS" || tur == "BA")
                contextMenuStrip1.Enabled = true;
        }

        private void kapaSimpleButton_Click(object sender, EventArgs e)
        {
            string hata = "";
            if (string.IsNullOrWhiteSpace(ftrNoTextEdit.Text))
                hata = "FaturaNo girin";
            else if (dknNoTextEdit.Enabled && string.IsNullOrWhiteSpace(ftrNoTextEdit.Text))
                hata = "DekontNo girin";
            else if (ftrTrhDateEdit.EditValue == null)
                hata = "Belge tarihi girin";

            if (hata != "")
            {
                XtraMessageBox.Show(hata);
                return;
            }

            try
            {
                accountQueriesTableAdapter.AFB_KAPA_NOTRH(afbID, ftrNoTextEdit.Text, ftrTrhDateEdit.DateTime, dknNoTextEdit.Text, Program.USR);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Fatura Kapat");
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        private void faturaNoALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ftrNo = accountQueriesTableAdapter.FTRNO_GET().ToString();
            ftrNoTextEdit.Text = ftrNo;
        }

        private void faturaNoBelirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                var dmy = Int64.Parse(ftrNoTextEdit.Text);
                accountQueriesTableAdapter.FTRNO_SET(ftrNoTextEdit.Text);
            } 
            catch (Exception ex)
            {
                XtraMessageBox.Show("Integer sayı girmelisiniz", "FaturaNo Belirle" + ex.Message);
            }
        }
    }
}