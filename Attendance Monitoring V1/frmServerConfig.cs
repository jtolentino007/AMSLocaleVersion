using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Xml;
using AMS.Classes;

namespace AMS
{
    public partial class frmDashboardDesign : DevExpress.XtraEditors.XtraForm
    {
        public frmDashboardDesign()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        public void updateConfigFile(string con)
        {
        }

        private void dashboardDesigner1_Load(object sender, EventArgs e)
        {

        }
    }
}