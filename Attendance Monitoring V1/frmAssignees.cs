using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraBars;

namespace AMS
{
    public partial class frmAssignee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtAddpro, dtOfficers;
        DataTable dtAssignees = new DataTable();

        public frmAssignee()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(checkedComboBoxEditAddPro.Text))
            {
                Utilities.ErrorMessage("Addpro is required");
                checkedComboBoxEditAddPro.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lueWorker.EditValue.ToString()))
            {
                Utilities.ErrorMessage("Worker field is required, please select NO WORKER if no worker is present.");
                checkedComboBoxEditOfficers.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(checkedComboBoxEditOfficers.Text))
            {
                Utilities.ErrorMessage("Officer is required, please select NO OFFICER if no worker is present.");
                checkedComboBoxEditOfficers.Focus();
                return false;
            }
            else
                return true;
        }

        private void clearAssignee()
        {
            lueWorker.ItemIndex = 0;
            checkedComboBoxEditAddPro.SetEditValue(null);
            checkedComboBoxEditOfficers.SetEditValue(null);
            txtRemarks.Text = "";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var cmdAttendance = new SqlCommand("INSERT_ATTENDANCE", Utilities.con))
            {
                cmdAttendance.CommandType = CommandType.StoredProcedure;
                cmdAttendance.Parameters.AddWithValue("@addpro", txtAddpro.Text);
                cmdAttendance.Parameters.AddWithValue("@officers", txtOfficers.Text);
                cmdAttendance.Parameters.AddWithValue("@workers", txtWorker.Text);
                cmdAttendance.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                cmdAttendance.ExecuteNonQuery();
                Utilities.SuccessMessage("Attendance Successfully ended");
                clearAssignee();  

                if (frmMain.flag == 1)
                {
                    Instances.attendanceForm.Hide();
                    Instances.main.Show();
                    Instances.main.barButtonItem5.Visibility = BarItemVisibility.Always;
                    Instances.main.barButtonItem6.Visibility = BarItemVisibility.Always;
                    Instances.main.mnuBtnAttendance.Visibility = BarItemVisibility.Never;
                }
                else
                {
                    Instances.attendanceForm.Hide();
                }

                Instances.attendanceForm.barButtonItemEndAttendance.Visibility = BarItemVisibility.Never;
                this.Hide();

            }
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void frmAssignee_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(frmAttendanceMonitoring.GatheringID))
            {
                using (var assigneeAdapter = new SqlDataAdapter("GET_ASSIGNEES", Utilities.con))
                {
                    dtAssignees.Clear();
                    assigneeAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    assigneeAdapter.SelectCommand.Parameters.AddWithValue("@GatheringID", frmAttendanceMonitoring.GatheringID);
                    assigneeAdapter.Fill(dtAssignees);

                    txtWorker.Text = dtAssignees.Rows[0]["workers"].ToString();
                    txtAddpro.Text = dtAssignees.Rows[0]["addpro"].ToString();
                    txtOfficers.Text = dtAssignees.Rows[0]["officers"].ToString();
                    txtRemarks.Text = dtAssignees.Rows[0]["remarks"].ToString();
                }
            }
        }
    }
}
