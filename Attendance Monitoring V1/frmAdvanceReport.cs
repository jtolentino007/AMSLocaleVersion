using AMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmAdvanceReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAdvanceReport()
        {
            InitializeComponent();
            gridControl1.DataSource = frmAttendanceForm.dtAttendedBrethren;
        }

    }
}
