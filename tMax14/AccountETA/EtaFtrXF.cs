using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace BL17.AccountETA
{
    public partial class EtaFtrXF : DevExpress.XtraEditors.XtraForm
    {
        public string afbIDs = "";
        bool OK = true;
        StringBuilder sbXML = new StringBuilder();
        StringBuilder xIDs = new StringBuilder();

        public EtaFtrXF()
        {
            InitializeComponent();

            dateEdit1.EditValue = DateTime.Today;
            dateEdit2.EditValue = DateTime.Today.AddDays(1);
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            sbXML.Clear();
            sbXML.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            //sbXML.AppendLine("<FATURA xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
            sbXML.AppendLine("<faturalar>");

            int nor = this.etaFtrTableAdapter.Fill(this.acccountEtaDataSet.ETA_FTR, dateEdit1.DateTime, dateEdit2.DateTime);
            foreach (AcccountEtaDataSet.ETA_FTRRow row in this.acccountEtaDataSet.ETA_FTR.Rows)
            {
                if (!row.IsXMLNull())
                {
                    sbXML.Append(row.XML);
                    
                    if (xIDs.Length > 0)
                        xIDs.Append(",");
                    xIDs.Append(row.AFBID);
                }
            }
            sbXML.Append("</faturalar>");

            //create a random temporary file with an .xml file extension
            var path = Path.GetTempPath();
            var fileName = Guid.NewGuid().ToString() + ".xml";
            var fullFileName = Path.Combine(path, fileName);
            File.WriteAllText(fullFileName, sbXML.ToString());
            webBrowser1.Navigate(fullFileName);
            //File.Delete(fullFileName); SILEMIYOR
            
            exportSimpleButton.Enabled = OK;
            Cursor = Cursors.Default;

        }

        private void exportSimpleButton_Click(object sender, EventArgs e)
        {
            accountEtaQueriesTableAdapter.ETA_FTR_EXPORTED(xIDs.ToString());

            System.IO.Directory.CreateDirectory(@"C:\tMax2DIA");    //Create Dir if not exists
            string fileName = string.Format(@"C:\tMax2DIA\DIA-Fatura-{0:yyyy-MM-dd-HH-mm}.xml", DateTime.Now);

            System.IO.File.WriteAllText(fileName, sbXML.ToString(), Encoding.UTF8);
            XtraMessageBox.Show("Dosya: " + fileName, "Fatura Export DIA");
        }
    }
}