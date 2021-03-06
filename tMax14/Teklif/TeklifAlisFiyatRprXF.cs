﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace BL17.Teklif
{
    public partial class TeklifAlisFiyatRprXF : DevExpress.XtraEditors.XtraForm
    {
        public TeklifAlisFiyatRprXF()
        {
            InitializeComponent();
        }

        private void TeklifAlisFiyatRprXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teklifDataSet.TKLF_RPR_ALS' table. You can move, or remove it, as needed.
            this.tKLF_RPR_ALSTableAdapter.Fill(this.teklifDataSet.TKLF_RPR_ALS);

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = tKLF_RPR_ALSGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Alış Fiyatları");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }
    }
}