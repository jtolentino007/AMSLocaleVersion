﻿using System;
using System.Data;
using AMS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmGatheringSetup : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string setupAttendanceID;
        public static string GatheringID;
        public static int sGatheringID;
        public static frmAttendanceMonitoring frmAMS = new frmAttendanceMonitoring();
        DataTable dtBatches = new DataTable();

        public frmGatheringSetup()
        {
            InitializeComponent();
        }

        public string SetAttendanceID()
        {
            string AttendanceID;
            string vAttendanceID = Utilities.GetLastCodeFromTable("Attendance_Id", "Attendance");
            if (vAttendanceID == null)
                AttendanceID = "A001";
            else
                AttendanceID = "A00" + Convert.ToInt64(vAttendanceID.Replace("A00", "") + 1);

            return AttendanceID;
        }

        private void LoadGatheringTypes()
        {
            Utilities.FillLookUpEdit(cmbGatheringType, "GET_GATHERING_TYPES", "gathering", "gathering_id");
        }

        private void LoadBatch()
        {
            Utilities.FillLookUpEdit(lueBatch, "GET_BATCHES", "Batch_Time", "Batch_ID");
        }

        public void FilterBatch(string vCriteria)
        {
            dtBatches.Clear();
            using (var BatchAdapter = new SqlDataAdapter("FILTER_BATCHES", Utilities.con))
            {
                BatchAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                BatchAdapter.SelectCommand.Parameters.AddWithValue("@GatheringType", vCriteria);
                BatchAdapter.Fill(dtBatches);
                lueBatch.Properties.DataSource = dtBatches;
            }
        }

        private void ClearGathering()
        {
            dtDateGathering.EditValue = DateTime.Now;
            lueBatch.EditValue = null;
            cmbViewingType.SelectedIndex = -1;
        }

        private void mnuBtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmGatheringSetup_Load(object sender, EventArgs e)
        {
            dtDateGathering.Enabled = false;
            lueBatch.EditValue = null;
            btnEdit.Visible = true;
            LoadBatch();
            LoadGatheringTypes();
            dtDateGathering.EditValue = DateTime.Now;
            cmbGatheringType.ItemIndex = 0;
            string gatheringCode = cmbGatheringType.GetColumnValue("gathering_code").ToString();
            FilterBatch(gatheringCode);
        }

        private string SetGatheringID(string GatheringType, string TimeOfGathering)
        {
            DateTime dt = Convert.ToDateTime(dtDateGathering.EditValue);
            int weekOfMonth = (dt.Day + Convert.ToInt32(dt.DayOfWeek)) / 7 + 1;
            string GatheringID = dt.Year.ToString().Substring(2,2) + dt.Month.ToString() + GatheringType + "W" + weekOfMonth.ToString() + dt.DayOfWeek.ToString().ToUpper().Substring(0,3) + TimeOfGathering;
            return GatheringID;
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(cmbGatheringType.Text))
            {
                Utilities.ErrorMessage("Gathering Type is Required");
                cmbGatheringType.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lueBatch.Text))
            {
                Utilities.ErrorMessage("Batch is Required");
                lueBatch.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbViewingType.Text))
            {
                Utilities.ErrorMessage("Viewing Type is required");
                cmbViewingType.Focus();
                return false;
            }
            else
                return true;
        }

        public void ActivateAttendanceForm()
        {
            frmAttendanceForm.dtAttendance.Clear();

            Instances.attendanceForm.lblGathering.Text = cmbGatheringType.Text;

            Instances.attendanceForm.lblGatheringBatch.Caption = lueBatch.Text;

            Instances.attendanceForm.lblGatheringDate.Caption = dtDateGathering.Text;

            Instances.attendanceForm.GetBrethrenList();

            Instances.attendanceForm.InitializeAttendeesTable();

            Instances.attendanceForm.GetAttendedBrethrenList(Convert.ToDateTime(dtDateGathering.Text), cmbGatheringType.GetColumnValue("gathering_code").ToString());
            
            
            //Instances.attendanceMontoring.barBtnEndAttendance.Visibility = BarItemVisibility.Always;
            //Instances.attendanceMontoring.barBtnTimeIn.Visibility = BarItemVisibility.Always;
            //Instances.attendanceMontoring.barBtnNewGathering.Visibility = BarItemVisibility.Never;
            //Instances.attendanceMontoring.txtSearch.Enabled = true;
            //Instances.attendanceMontoring.gridAttendance.Enabled = true;
            //Instances.attendanceMontoring.gridBrethren.Enabled = true;
            //Instances.attendanceMontoring.barBtnNewGathering.Visibility = BarItemVisibility.Never;
            //Instances.attendanceMontoring.mnuBtnGatheringList.Visibility = BarItemVisibility.Never;
            //Instances.attendanceMontoring.mnuBtnInterlocale.Visibility = BarItemVisibility.Always;
            //Instances.attendanceMontoring.barBtnNewlyBaptized.Visibility = BarItemVisibility.Always;
            //Instances.attendanceMontoring.barBtnLateStatus.Visibility = BarItemVisibility.Always;
            //Instances.attendanceMontoring.barBtnLateStatus.Enabled = true;
            //Instances.attendanceMontoring.barBtnLateStatus.Caption = "Activate Late Status";
            //Instances.attendanceMontoring.lblTimerGathering.Text = cmbGatheringType.Text.ToUpper();
            //Instances.attendanceMontoring.lblStatus.Text = "READY";
            //Instances.attendanceMontoring.barBtnGenerateReport.Visibility = BarItemVisibility.Always;
            //frmAttendanceMonitoring.Status = 1;
            //Instances.attendanceMontoring.GetBrethrenList();
            //Instances.attendanceMontoring.GetCurrentAttendance();
        }

        private void mnuBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dtDateGathering.EditValue);
            int weekOfMonth = (dt.Day + Convert.ToInt32(dt.DayOfWeek)) / 7 + 1;
            if (IsValid())
            {
                //frmAttendanceMonitoring.GatheringID = SetGatheringID(cmbGatheringType.EditValue.ToString(), lueBatch.Text.Replace(" ", ""));
                if (Utilities.CheckRecordIfExists("Gathering_Id", SetGatheringID(cmbGatheringType.GetColumnValue("gathering_code").ToString(), lueBatch.Text), "Gathering"))
                    Utilities.ErrorMessage("Gathering Already Exists");
                else { 
                    
                    using (var cmd = new SqlCommand("INSERT_GATHERING", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@GatheringId", SetGatheringID(cmbGatheringType.GetColumnValue("gathering_code").ToString(), lueBatch.Text));
                        cmd.Parameters.AddWithValue("@GatheringType", cmbGatheringType.EditValue);
                        cmd.Parameters.AddWithValue("@GatheringWeek", "W" + weekOfMonth.ToString());
                        cmd.Parameters.AddWithValue("@GatheringMonth", dt.Month.ToString("D2"));
                        cmd.Parameters.AddWithValue("@GatheringYear", dt.Year.ToString());
                        cmd.Parameters.AddWithValue("@ViewingType", cmbViewingType.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@GatheringDay", dt.DayOfWeek.ToString().ToUpper().Substring(0, 3));
                        cmd.Parameters.AddWithValue("@Gathering_Date", dt.Day.ToString());
                        cmd.Parameters.AddWithValue("@Batch_ID", lueBatch.EditValue.ToString());
                        cmd.ExecuteNonQuery();
                        Utilities.SuccessMessage("Gathering Successfully Created");
                        GatheringID = SetGatheringID(cmbGatheringType.GetColumnValue("gathering_code").ToString(), lueBatch.Text);
                        frmAttendanceForm.GatheringID = GatheringID;
                        frmInterlocale.GatheringID = GatheringID;
                        Utilities.GenerateSystemLog("Created " + SetGatheringID(cmbGatheringType.Text, lueBatch.Text), "Gathering Management", 1);
                        //Instances.attendanceForm.barStaticGatheringID.Caption = "Gathering ID : " + frmAttendanceMonitoring.GatheringID;
                        //Instances.attendanceForm.barStaticGatheringType.Caption = "Gathering : " + cmbGatheringType.Text + ", " + lueBatch.Text + " Batch";
                        frmAttendanceMonitoring.Time = Convert.ToDateTime(Convert.ToDateTime(lueBatch.Text).ToShortTimeString());
                        Instances.attendanceForm.lblGatheringBatch.Caption = "BATCH : " + Convert.ToDateTime(lueBatch.Text).ToShortTimeString();
                        Instances.attendanceForm.lblGatheringDate.Caption = "DATE OF GATHERING : " + dtDateGathering.Text;
                        ActivateAttendanceForm();
                        Instances.attendanceForm.ShowDialog();
                        ClearGathering();
                        this.Hide();
                    }
                    setupAttendanceID = SetAttendanceID();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dtDateGathering.Enabled = true;
            btnEdit.Visible = false;
            btnSet.Visible = true;
        }

        private void cmbGatheringyType_TextChanged(object sender, EventArgs e)
        {
            string gatheringCode = cmbGatheringType.GetColumnValue("gathering_code").ToString();
            FilterBatch(gatheringCode);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            dtDateGathering.Enabled = false;
            btnEdit.Visible = true;
            btnSet.Visible = false;
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            Utilities.SFMode = "Add";
            sGatheringID = Convert.ToInt32(cmbGatheringType.EditValue);
            Instances.BatchAddEdit.ShowDialog();
        }
    }
}