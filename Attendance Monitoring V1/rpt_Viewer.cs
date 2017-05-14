using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace AMS
{
    public partial class rpt_Viewer : Form
    {
        string exeFolder = "";
        public rpt_Viewer()
        {
            InitializeComponent();
        }

        private void rpt_Viewer_Load(object sender, EventArgs e)
        {
            exeFolder = Path.GetDirectoryName(Application.StartupPath);
        }

        private DataTable GetODT()
        {
            DataTable dt = new DataTable();


            SqlConnection conn = new SqlConnection(ConfigurationManager
                .ConnectionStrings["AMSConnection"].ConnectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_SSRS_Attendance_Summary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Gathering_Year", dateTimePicker1.Value.Year.ToString());
                cmd.Parameters.AddWithValue("@Gathering_Month", dateTimePicker1.Value.Month.ToString());
                cmd.Parameters.AddWithValue("@No_of_absence", cboNoAbsences.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


            return dt;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DataTable dt = GetODT();
            reportViewer1.Visible = true;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\jdevb\Documents\Attendance Monitoring\Attendance Monitoring System (Locale Version)\AMS v1\Attendance Monitoring V1\rpt_ODT_Attendance_Summary.rdlc";

            //string reportPath = Path.Combine(exeFolder, @"\rpt_ODT_Attendance_Summary.rdlc");
            //reportViewer1.LocalReport.ReportPath = reportPath;

            ReportParameter[] rptParams = new ReportParameter[] { 
                    new ReportParameter("Gathering_Year", dateTimePicker1.Value.Year.ToString()),
                    new ReportParameter("Gathering_Month", dateTimePicker1.Value.Month.ToString()),
                    new ReportParameter("No_of_absence",  cboNoAbsences.Text)
            };

            reportViewer1.LocalReport.SetParameters(rptParams);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DS_ODT_Attendance_Summary", dt));
            reportViewer1.RefreshReport();

        }
    }
}
