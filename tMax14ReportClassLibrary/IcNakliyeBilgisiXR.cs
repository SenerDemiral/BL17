﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class IcNakliyeBilgisiXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public IcNakliyeBilgisiXR(int OPHid)
        {
            InitializeComponent();

            //rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprInbTableAdapter.Fill(reportDataSet.RPR_INB, OPHid);

            eMails = reportDataSet.RPR_INB.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_INB.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_INB.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
