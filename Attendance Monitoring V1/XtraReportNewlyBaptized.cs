using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using AMS.Classes;

namespace AMS
{
    public partial class XtraReportNewlyBaptized : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportNewlyBaptized()
        {
            InitializeComponent();
        }

        private void XtraReportNewlyBaptized_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {

        }

        private void PageFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XtraReportNewlyBaptized_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
