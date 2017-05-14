using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using AMS.Classes;

namespace AMS
{
    public partial class XtraReportCelebrants : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportCelebrants()
        {
            InitializeComponent();
        }

        private void XtraReportGroupings_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {

        }

        private void PageFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XtraReportGroupings_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
