using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using AMS.Classes;
using System.Data.SqlClient;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.ReportGeneration;
using System.Collections.Generic;

namespace AMS
{
    public partial class frmAttendanceMonitoring : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtBrethren = new DataTable();
        public static DataTable dtAttendance = new DataTable();
        public static string GatheringID;
        public static DateTime Time;
        public static DataRow drAttendance;
        public static bool _isGatheringSetup = false;

        public static int Status = 1;
        public frmAttendanceMonitoring()
        {
            InitializeComponent();
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void RecoverGathering()
        {
            using (var adapter = new SqlDataAdapter("GET_TEMP_ATTENDANCE", Utilities.con))
            {
                dtAttendance.Clear();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dtAttendance);
            }
        }

        private void frmAttendanceMonitoring_Load(object sender, EventArgs e)
        {
            RecoverGathering();
            if (dtAttendance.Rows.Count > 0)
            {
                gridAttendance.DataSource = dtAttendance;
                GetBrethrenList();
                GetAttendedBrethren();
                GatheringID = dtAttendance.Rows[0][2].ToString();
                barStaticGatheringID.Caption = GatheringID;
                barStaticGatheringType.Caption = dtAttendance.Rows[0][9].ToString();
                lblTimerGathering.Text = dtAttendance.Rows[0][9].ToString().ToUpper();
                lblStatus.Text = "READY";
                mnuBtnInterlocale.Visibility = BarItemVisibility.Always;
                barBtnTimeIn.Visibility = BarItemVisibility.Always;
                barBtnEndAttendance.Visibility = BarItemVisibility.Always;
                barBtnNewlyBaptized.Visibility = BarItemVisibility.Always;
                barBtnNewGathering.Visibility = BarItemVisibility.Never;
                mnuBtnGatheringList.Visibility = BarItemVisibility.Never;
                gridAttendance.Enabled = true;
                gridBrethren.Enabled = true;
                txtSearch.Enabled = true;
            }
            //else
            //{
            //    mnuBtnInterlocale.Visibility = BarItemVisibility.Never;
            //    barBtnTimeIn.Visibility = BarItemVisibility.Never;
            //    barBtnEndAttendance.Visibility = BarItemVisibility.Never;
            //    barBtnNewlyBaptized.Visibility = BarItemVisibility.Never;
            //    barBtnLateStatus.Visibility = BarItemVisibility.Never;
            //    lblStatus.Text = "PLEASE CREATE/SELECT GATHERING";
            //    gridBrethren.Enabled = false;
            //    gridAttendance.Enabled = false;
            //    txtSearch.Enabled = false;
            //}
            peBrethren.Image = null;
            barStaticLocale.Caption = "Locale of " + frmLogin.Locale;
        }

        public void GetBrethrenList()
        {
            using (var adapt = new SqlDataAdapter("GET_BRETHREN", Utilities.con))
            {
                dtBrethren.Clear();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtBrethren);
                gridBrethren.DataSource = dtBrethren;
            }
        }

        public void GetCurrentAttendance()
        {
            using (var Attendance = new SqlDataAdapter("GET_TEMP_ATTENDANCE", Utilities.con))
            {
                dtAttendance.Clear();
                Attendance.SelectCommand.CommandType = CommandType.StoredProcedure;
                Attendance.Fill(dtAttendance);
                gridAttendance.DataSource = dtAttendance;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = gridBrethren.DataSource;
            bs.Filter = "Church_Id LIKE '%" + txtSearch.Text + "%' OR BrethrenName LIKE '%" + txtSearch.Text + "%'";
            gridBrethren.DataSource = bs;
        }

        private void mnuBtnGatheringList_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Instances.viewGatherings.ShowDialog();
        }

        private void barBtnNewGathering_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.setupGathering.ShowDialog();
        }

        private void mnuBtnInterlocale_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (frmGatheringSetup.GatheringID != null || frmGatheringView.GatheringID != null)
                GatheringID = (frmGatheringView.GatheringID == null ? frmGatheringSetup.GatheringID : frmGatheringView.GatheringID);
            else
                frmInterlocale.GatheringID = GatheringID;

            Instances.Interlocale.ShowDialog();
        }

        private void mnuBtnClose_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (barBtnEndAttendance.Visibility == BarItemVisibility.Always)
                Utilities.ErrorMessage("You must end this batch to close this form");
            else
                this.Hide();
        }

        //public string GatheringIDValue()
        //{
        //    if (frmGatheringSetup.GatheringID == null)
        //        return frmGatheringView.GatheringID;
        //    else
        //        return frmGatheringSetup.GatheringID;
        //}

        private void barBtnTimeIn_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            foreach (var row in gridView2.GetSelectedRows())
            {
                if (gridView2.SelectedRowsCount == 0)
                    lblStatus.Text = "No Brethren Selected";
                else if (gridView2.RowCount == 0)
                    lblStatus.Text = "No Brethren Found";
                else if (Utilities.CheckBrethrenIfAttended(GatheringID, gridView2.GetRowCellValue(row, "brethren_id").ToString()))
                    lblStatus.Text = "Brethren Already Timed In";
                else
                {
                    //splashScreenManager1.ShowWaitForm();
                    using (var cmd = new SqlCommand("INSERT_TEMP_ATTENDANCE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tempGathering_ID", GatheringID);
                        cmd.Parameters.AddWithValue("@tempChurch_ID", gridView2.GetRowCellValue(row, "Church_Id"));
                        cmd.Parameters.AddWithValue("@tempAttendance_Status", Status);
                        cmd.Parameters.AddWithValue("@tempReal_Time", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@is_interlocale", false);
                        cmd.Parameters.AddWithValue("@remarks", "");
                        cmd.Parameters.AddWithValue("@temp_brethren_id", gridView2.GetRowCellValue(row, "brethren_id"));
                        cmd.ExecuteNonQuery();

                        if (!string.IsNullOrWhiteSpace(gridView2.GetRowCellValue(row, "Image_Path").ToString()))
                            peBrethren.Image = Image.FromFile(gridView2.GetRowCellValue(row, "Image_Path").ToString());
                        else
                            peBrethren.Image = null;

                        lblStatus.Text = gridView2.GetRowCellValue(row, "BrethrenName").ToString() + " SUCCESSFULLY TIMED IN";
                    }

                    drAttendance = dtAttendance.NewRow();
                    drAttendance["temp_brethren_id"] = gridView2.GetRowCellValue(row, "brethren_id").ToString();
                    drAttendance["tempChurch_ID"] = gridView2.GetRowCellValue(row, "Church_Id").ToString();
                    drAttendance["Name"] = gridView2.GetRowCellValue(row, "BrethrenName").ToString();
                    drAttendance["tempReal_Time"] = DateTime.Now.ToShortTimeString();
                    drAttendance["tempAttendance_Status"] = (Status == 1 ? "TIMED IN" : "LATE");
                    drAttendance["is_interlocale"] = "NO";
                    drAttendance["remarks"] = "";
                    dtAttendance.Rows.Add(drAttendance);
                    dtAttendance.AcceptChanges();

                    GetAttendedBrethren();
                }

                txtSearch.ResetText();
            }
        }

        public void ReturnAttendanceToNormal()
        {
            barBtnEndAttendance.Visibility = BarItemVisibility.Never;
            mnuBtnGatheringList.Visibility = BarItemVisibility.Always;
            barBtnNewGathering.Visibility = BarItemVisibility.Always;
            barBtnTimeIn.Visibility = BarItemVisibility.Never;
            barBtnNewlyBaptized.Visibility = BarItemVisibility.Never;
            mnuBtnInterlocale.Visibility = BarItemVisibility.Never;
            barBtnLateStatus.Visibility = BarItemVisibility.Never;
            barBtnGenerateReport.Visibility = BarItemVisibility.Never;
            txtSearch.Enabled = false;
            gridAttendance.Enabled = false;
            gridBrethren.Enabled = false;
            barStaticGatheringType.Caption = null;
            barStaticGatheringID.Caption = null;
            lblStatus.Text = "READY";
            peBrethren.Image = null;
            lblTimerGathering.Text = "NO ACTIVE GATHERING";
            dtBrethren.Clear();
        }

        public void GetAttendedBrethren()
        {
            for (int j = 0; j < dtAttendance.Rows.Count; j++)
            {
                for (int m = 0; m < dtBrethren.Rows.Count; m++)
                {
                    if (dtBrethren.Rows[m]["brethren_id"].ToString() == dtAttendance.Rows[j]["temp_brethren_id"].ToString())
                    {
                        dtBrethren.Rows.RemoveAt(m);
                    }
                }
                dtBrethren.AcceptChanges();
            }
        }

        private void barBtnEndAttendance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utilities.QuestionMessage("Are you sure you want to End this Attendance?"))
            {
                if (gridView1.RowCount == 0)
                    Utilities.ErrorMessage("No Brethren Attended in this Batch");
                else
                {
                    using (var cmdAttendance = new SqlCommand("INSERT_ATTENDANCE", Utilities.con))
                    {
                        cmdAttendance.CommandType = CommandType.StoredProcedure;
                        cmdAttendance.ExecuteNonQuery();
                        GetCurrentAttendance();
                        ReturnAttendanceToNormal();
                        Utilities.SuccessMessage("Attendance Sheet Successfully Saved!");
                        this.Close();
                    }
                }
            }
        }

        private void barBtnNewlyBaptized_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.NewlyBaptizedForm.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barBtnTimeIn.PerformClick();
            }
        }

        private void frmAttendanceMonitoring_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                barBtnEndAttendance.PerformClick();
            }
        }

        private void frmAttendanceMonitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (barBtnEndAttendance.Visibility == BarItemVisibility.Always)
            {
                Utilities.ErrorMessage("You must end this batch to close this form");
                e.Cancel = true;
            }
            else
                this.Hide();
        }

        private void barBtnLateStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utilities.QuestionMessage("Are you sure you want to Activate Late Status?"))
            {
                Status = 2;
                barBtnLateStatus.Caption = "Late Status Activated";
                barBtnLateStatus.Enabled = false;
            }
        }

        private void barBtnGenerateReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gridAttendance.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            gridAttendance.ShowPrintPreview();
        }

        private void gridAttendance_Click(object sender, EventArgs e)
        {

        }
    }
}
