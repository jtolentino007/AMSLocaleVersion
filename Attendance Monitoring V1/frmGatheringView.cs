using AMS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace AMS
{
    public partial class frmGatheringView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtGathering = new DataTable();
        DataTable dtAssignees = new DataTable();

        public static string GatheringInfo, GatheringID, viewAttendanceID;

        public frmGatheringView()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnFindGathering.Visibility = BarItemVisibility.Always;
            this.Close();
        }

        private void GetCurrentSelectedAttendance(string GatheringID)
        {
            using (var cmdReturn = new SqlCommand("GET_CURRENT_ATTENDANCE", Utilities.con))
            {
                cmdReturn.CommandType = CommandType.StoredProcedure;
                cmdReturn.Parameters.AddWithValue("@Filter", GatheringID);
                cmdReturn.ExecuteNonQuery();
            }
        }

        private void GetGatheringList()
        {
            using (var adapt = new SqlDataAdapter("GET_GATHERINGS", Utilities.con))
            {
                dtGathering.Clear();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtGathering);
                gridGathering.DataSource = dtGathering;
            }
        }

        private void SetGathering()
        {
            Instances.attendanceMontoring.barBtnEndAttendance.Visibility = BarItemVisibility.Always;
            Instances.attendanceMontoring.barBtnTimeIn.Visibility = BarItemVisibility.Always;
            Instances.attendanceMontoring.barBtnNewGathering.Visibility = BarItemVisibility.Always;
            Instances.attendanceMontoring.barBtnNewGathering.Visibility = BarItemVisibility.Never;
            Instances.attendanceMontoring.mnuBtnGatheringList.Visibility = BarItemVisibility.Never;
            Instances.attendanceMontoring.mnuBtnInterlocale.Visibility = BarItemVisibility.Always;
            Instances.attendanceMontoring.barBtnNewlyBaptized.Visibility = BarItemVisibility.Always;
            Instances.attendanceMontoring.barBtnLateStatus.Visibility = BarItemVisibility.Always;
            Instances.attendanceMontoring.barBtnLateStatus.Enabled = true;
            Instances.attendanceMontoring.txtSearch.Enabled = true;
            Instances.attendanceMontoring.gridAttendance.Enabled = true;
            Instances.attendanceMontoring.GetBrethrenList();
            Instances.attendanceMontoring.GetCurrentAttendance();
            Instances.attendanceMontoring.barStaticGatheringID.Caption = GatheringID;
            Instances.attendanceMontoring.barStaticGatheringType.Caption = GatheringInfo;
            Instances.attendanceMontoring.gridBrethren.Enabled = true;
            Instances.attendanceMontoring.barStaticGatheringID.Caption = GatheringID;
            Instances.attendanceMontoring.barStaticGatheringType.Caption = GatheringInfo;
            Instances.attendanceMontoring.barBtnLateStatus.Caption = "Activate Late Status";
            Instances.attendanceMontoring.lblTimerGathering.Text = gridView1.GetFocusedRowCellValue("Gathering_Type").ToString().ToUpper();
            Instances.attendanceMontoring.lblStatus.Text = "READY";
            Instances.attendanceMontoring.barBtnGenerateReport.Visibility = BarItemVisibility.Always;
            //Instances.attendanceForm.barStaticGatheringID.Caption = GatheringID;
            //Instances.attendanceForm.barStaticGatheringType.Caption = GatheringInfo;
            Instances.attendanceForm.lblGatheringBatch.Caption = "BATCH : " + Convert.ToDateTime(Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Batch_Time").ToString()).ToShortTimeString()).ToString();
            Instances.attendanceForm.lblGatheringDate.Caption = "DATE OF GATHERING : " + gridView1.GetFocusedRowCellValue("DateOfGathering").ToString();
            //frmAttendanceForm.Time = Convert.ToDateTime(Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Batch_Time").ToString()).ToShortTimeString());
            this.Close();
        }

        private void AcceptAttendance()
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No selected gathering(s) found");
            else
            {
                frmAttendanceForm.dtAttendance.Clear();
                //viewAttendanceID = Instances.setupGathering.SetAttendanceID();SetGathering();
                GetCurrentSelectedAttendance(gridView1.GetFocusedRowCellValue("Gathering_Id").ToString());
                GatheringID = gridView1.GetFocusedRowCellValue("Gathering_Id").ToString();
                GatheringInfo = gridView1.GetFocusedRowCellValue("Gathering_Type").ToString() + ", " + Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Batch_Time")).ToString("hh:mm tt") + " Batch";

                frmAttendanceForm.GatheringID = GatheringID;
                frmAttendanceForm.Status = 1;
                frmInterlocale.GatheringID = GatheringID;
                Instances.attendanceForm.lblGatheringBatch.Caption = "BATCH : " + Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Batch_Time").ToString()).ToShortTimeString();
                Instances.attendanceForm.lblGatheringDate.Caption = "DATE OF GATHERING : " + gridView1.GetFocusedRowCellValue("DateOfGathering").ToString();
                Instances.attendanceForm.lblGathering.Text = gridView1.GetFocusedRowCellValue("Gathering_Type").ToString();
                Instances.attendanceForm.GetAttendedBrethren();
                Instances.attendanceForm.GetAttendedBrethrenList(Convert.ToDateTime(gridView1.GetFocusedRowCellValue("DateOfGathering").ToString()), gridView1.GetFocusedRowCellValue("gathering_code").ToString());

                using (SqlDataAdapter TempAdapter = new SqlDataAdapter("GET_TEMP_ATTENDANCE", Utilities.con))
                {
                    TempAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    TempAdapter.Fill(frmAttendanceForm.dtAttendance);
                }

                Instances.assignees.txtAddpro.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["addpro"].ToString() : "");
                Instances.assignees.txtOfficers.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["officers"].ToString() : "");
                Instances.assignees.txtWorker.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["workers"].ToString() : "");
                Instances.assignees.txtRemarks.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["remarks"].ToString() : "");

                Instances.attendanceForm.ShowDialog();
                this.Hide();

            }
        }

        private void barBtnOK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.attendanceMontoring.lblStatus.Text = "READY";
            AcceptAttendance();
        }

        private void barBtnFindGathering_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
            barBtnFindGathering.Visibility = BarItemVisibility.Never;
        }

        private void gridGathering_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_GroupRowCollapsing(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            e.Allow = false;
        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void frmGatheringView_Load(object sender, EventArgs e)
        {
            GetGatheringList();
        }

        private void gridGathering_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //AcceptAttendance();
        }
    }
}
