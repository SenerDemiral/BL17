using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BL17.AccountAk
{
    public partial class AkoXF : DevExpress.XtraEditors.XtraForm
    {
        public int akID = 0;
        public string akAD = "";

        public AkoXF()
        {
            InitializeComponent();
        }

        private void AkoXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("[{0}] {1} Ops Sayıları", akID, akAD);
            this.aKOTableAdapter.Fill(this.accountAkDataSet.AKO, akID);
        }
    }
}