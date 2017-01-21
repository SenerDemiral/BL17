using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class FaturaXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public FaturaXR(int AFBid, string Antet, string Usr, bool AllIn = false)
        {
            InitializeComponent();

            // Force the report creation without requesting the parameter value from end-users.
            this.RequestParameters = false;

            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            ReportDataSet.SMTPRow SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprFaturaTableAdapter.Fill(reportDataSet.RPR_FATURA, AFBid, Usr);
            //rprFaturaOpsTableAdapter.Fill(reportDataSet.RPR_FATURA_OPS, AFBid);
            rprFaturaDtyTableAdapter.Fill(reportDataSet.RPR_FATURA_DTY, AFBid, "1");

            int nor = rprFaturaHouseTableAdapter.Fill(reportDataSet.RPR_FATURA_HOUSE, AFBid);
            if (nor > 0)
                DetailReportMaster.Visible = false;
            else
            {
                rprFaturaMasterTableAdapter.Fill(reportDataSet.RPR_FATURA_MASTER, AFBid);
                DetailReportHouse.Visible = false;
            }

            if (!reportDataSet.RPR_FATURA[0].IsOPIDNull())
                opInfoTableAdapter.Fill(reportDataSet.OP_INFO, reportDataSet.RPR_FATURA[0].OPID, reportDataSet.RPR_FATURA[0].OPHM);

            string tur = reportDataSet.RPR_FATURA[0].TUR;
            string drm = reportDataSet.RPR_FATURA[0].DRM;
            string eFtr = reportDataSet.RPR_FATURA[0].EFTR;

            // Rapor BosKagida basilacak sekilde ayarli 
			antetli.Value = false;	// Faturaya bas
            if (Antet == "Antetli")
                antetli.Value = true;	// BosKagida bas
            
            Watermark.Text = "";
            if (drm == "A")
                Watermark.Text = "DRAFT";
            if (eFtr == "T")
                Watermark.Text += " eFatura";
            if (tur == "AA")
                Watermark.Text += " Alış";
            if (tur == "AS")
                Watermark.Text += " Satış İade";
            if (tur == "AV" || tur == "BV" || tur == "AM" || tur == "BM" || tur == "AD" || tur == "BD")     // aVans/Belgesiz,fazlaMesai,Dekont
                Watermark.Text = "";

            eMails = reportDataSet.RPR_FATURA.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_FATURA.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_FATURA.Rows[0]["EMAILBODY"].ToString();
			/*
            if (Antet != "Antetli" && SMTP.FIRMA == "TUNASET")
            {
                TopMargin.HeightF = 50F; // 150F;
                PageFooter.Visible = false;
                Detail.HeightF = 1000F; // 1200F;

                xrLabelAdr.SizeF = new System.Drawing.SizeF(800F, 300F);
                xrLabelTrh.LocationF = new PointF(1589.93F, 710F);//855,915,     1589
                xrLabelRef.LocationF = new PointF(1589.93F, 775F);//915,975
            }
			*/
            xrLabel53.Visible = !AllIn;
            xrLabel55.Visible = !AllIn;
            xrLine1.Visible = !AllIn;
            Detail1.Visible = !AllIn;

            xrLabelAll_In.Visible = AllIn;

			//Faturaya basiliyorsa
			if(Antet != "Antetli") {
				PageFooter.Visible = false;
				Detail.HeightF = 1100F;
				xrLabelTrh.LocationF = new PointF(1300F, 830F);
				xrLabelRef.LocationF = new PointF(1300F, 880F);
			}


		}

    }
}
