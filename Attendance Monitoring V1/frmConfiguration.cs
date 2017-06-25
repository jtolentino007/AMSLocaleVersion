using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

namespace AMS
{
    public partial class frmConfiguration : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmConfiguration()
        {
            InitializeComponent();
            
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["AMSConnection"];
            MessageBox.Show(conSettings.ConnectionString);
        }
    }
}