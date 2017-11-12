using AMS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace AMS
{
    public partial class frmInterlocale : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtInterlocale = new DataTable();
        DataTable dtInterlocaleLocale = new DataTable();
        string InterlocaleIDValue;
        public static string GatheringID;
        public frmInterlocale()
        {
            InitializeComponent();
        }

        private string InterlocaleID()
        {
            string LastInsertedID = Utilities.GetLastAlphaNumericColumn("Interlocale_Id", "Interlocale");

            if (LastInsertedID == null)
                return "IL-1";
            else
                return "IL-" + (Convert.ToInt16(LastInsertedID.Replace("IL-", "")) + 1);
        }

        private void LoadInterlocale()
        {
            Utilities.SQLConnectionOpen();
            using (var adapt = new SqlDataAdapter("GET_INTERLOCALE", Utilities.con))
            {
                dtInterlocale.Clear();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtInterlocale);
                gridInterlocale.DataSource = dtInterlocale;
            }
        }

        private void InitializeInterlocaleInput()
        {
            LabelDoB.Show();
            LabelCI.Text = "Church ID :";
            LabelCI.Hide();
            dateBaptism.EditValue = DateTime.Now.ToShortDateString();
            LabelDoB.Hide();
            //btnChurchID.Show();
            //btnBoth.Show();
            //btnBaptism.Show();
        }

        private void HideButtons()
        {
            btnChurchID.Hide();
            btnBoth.Hide();
            btnBaptism.Hide();
        }

        public void FillComboBoxLocale()
        {
            using(var adapt = new SqlDataAdapter("GET_INTERLOCALE_LOCALE", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtInterlocaleLocale);
            }

            foreach (DataRow Row in dtInterlocaleLocale.Rows)
            {
                txtLocale.Properties.Items.Add(Row["Locale"]);
            }
            txtLocale.Properties.Sorted = true;

        }

        private void frmInterlocale_Load(object sender, EventArgs e)
        {
            InitializeInterlocaleInput();
            AttendanceStatus();
            Utilities.FMode = "Add";
            gridView1.ShowFindPanel();
            ClearFields();
            LoadInterlocale();
            FillComboBoxLocale();
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtChurchID.ResetText();
            txtFirstname.ResetText();
            txtMiddlename.ResetText();
            txtLastname.ResetText();
            txtLocale.ResetText();
            dateBaptism.Text = "";
            txtChurchID.Focus();
            Utilities.FMode = "Add";
            btnSave.Text = "Save";
            InitializeInterlocaleInput();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                Utilities.ErrorMessage("First name is required");
                txtFirstname.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                Utilities.ErrorMessage("Last name is required");
                txtLastname.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLocale.Text))
            {
                Utilities.ErrorMessage("Locale is required");
                txtLocale.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (Utilities.FMode == "Add")
                {
                    string interlocaleID = InterlocaleID();
                    using (var cmd = new SqlCommand("INSERT_INTERLOCALE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Interlocale_ID", interlocaleID);
                        cmd.Parameters.AddWithValue("@Church_Id", txtChurchID.Text);
                        cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
                        cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@Locale", txtLocale.Text);
                        cmd.Parameters.AddWithValue("@DateOfBaptism", dateBaptism.EditValue);
                        cmd.ExecuteNonQuery();
                        Utilities.SuccessMessage("New Interlocale has been successfully saved!");
                        Utilities.GenerateSystemLog("Added Interlocale, " + txtFirstname.Text + " " + txtLastname.Text, "Interlocale Module", 1);

                        //DataRow dr = dtInterlocale.NewRow();
                        //dr["Interlocale_Id"] = interlocaleID;
                        //dr["Church_Id"] = txtChurchID.Text;
                        //dr["Firstname"] = txtFirstname.Text;
                        //dr["Middlename"] = txtMiddlename.Text;
                        //dr["Lastname"] = txtLastname.Text;
                        //dr["Locale"] = txtLocale.Text;
                        //dr["DateOfBaptism"] = dateBaptism.EditValue;
                        //dtInterlocale.Rows.Add(dr);
                        //dtInterlocale.AcceptChanges();

                        //gridInterlocale.DataSource = dtInterlocale;
                        //ClearFields();
                    }

                    using (var cmdAttendance = new SqlCommand("INSERT_TEMP_ATTENDANCE", Utilities.con))
                    {
                        cmdAttendance.CommandType = CommandType.StoredProcedure;
                        cmdAttendance.Parameters.AddWithValue("@tempGathering_ID", frmAttendanceForm.GatheringID);
                        //cmd.Parameters.AddWithValue("@tempChurch_ID", gridView1.GetRowCellValue(row, "Church_Id"));
                        cmdAttendance.Parameters.AddWithValue("@tempAttendance_Status", frmAttendanceForm.Status);
                        cmdAttendance.Parameters.AddWithValue("@tempReal_Time", DateTime.Now.ToShortTimeString());
                        cmdAttendance.Parameters.AddWithValue("@is_interlocale", true);
                        //cmd.Parameters.AddWithValue("@remarks", gridView1.GetRowCellValue(row, "Locale"));
                        cmdAttendance.Parameters.AddWithValue("@temp_brethren_id", interlocaleID);
                        cmdAttendance.Parameters.AddWithValue("@locale", txtLocale.Text);
                        cmdAttendance.ExecuteNonQuery();
                        var InterlocaleName = txtFirstname.Text + " " + txtLastname.Text;
                        Utilities.SuccessMessage(InterlocaleName + " Successfully Timed In");

                        frmAttendanceForm.drAttendance = frmAttendanceForm.dtAttendance.NewRow();
                        var dr = frmAttendanceForm.drAttendance;
                        dr["temp_brethren_id"] = interlocaleID;
                        dr["tempChurch_ID"] = txtChurchID.Text;
                        dr["Name"] = InterlocaleName;
                        dr["tempReal_Time"] = DateTime.Now.ToShortTimeString();
                        dr["tempAttendance_Status"] = (frmAttendanceForm.Status == 1 ? "TIMED IN" : "LATE");
                        dr["is_interlocale"] = "YES";
                        dr["locale"] = txtLocale.Text;
                        frmAttendanceForm.dtAttendance.Rows.Add(dr);
                        frmAttendanceForm.dtAttendance.AcceptChanges();

                        Instances.attendanceForm.lblChurchID.Text = txtChurchID.Text;
                        Instances.attendanceForm.lblName.Text = InterlocaleName;
                        Instances.attendanceForm.lblLocale.Text = txtLocale.Text;

                        this.Close();
                    }
                }
                else
                {
                    using (var cmd = new SqlCommand("UPDATE_INTERLOCALE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Interlocale_Id", InterlocaleIDValue);
                        cmd.Parameters.AddWithValue("@Church_Id", txtChurchID.Text);
                        cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
                        cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@Locale", txtLocale.Text);
                        cmd.Parameters.AddWithValue("@DateOfBaptism", dateBaptism.EditValue);
                        cmd.ExecuteNonQuery();
                        Utilities.SuccessMessage("Interlocale has been successfully updated!");
                        Utilities.GenerateSystemLog("Edited Interlocale, " + txtFirstname.Text + " " + txtLastname.Text, "Interlocale Module", 1);

                        DataRow drUpdate = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                        drUpdate["Interlocale_Id"] = InterlocaleIDValue;
                        drUpdate["Church_Id"] = txtChurchID.Text;
                        drUpdate["Firstname"] = txtFirstname.Text;
                        drUpdate["Middlename"] = txtMiddlename.Text;
                        drUpdate["Lastname"] = txtLastname.Text;
                        drUpdate["Locale"] = txtLocale.Text;
                        drUpdate["DateOfBaptism"] = dateBaptism.EditValue;
                        dtInterlocale.AcceptChanges();

                        gridInterlocale.DataSource = dtInterlocale;
                        ClearFields();
                    }
                }
                
            }
        }

        public string AttendanceIDValue()
        {
            if (frmGatheringSetup.setupAttendanceID == null)
                return frmGatheringView.viewAttendanceID;
            else
                return frmGatheringSetup.setupAttendanceID;
        }

        public int AttendanceStatus()
        {
            int Status;
            TimeSpan TimeLate = Convert.ToDateTime(DateTime.Now.ToShortTimeString()) - frmAttendanceMonitoring.Time;
            if (TimeLate >= TimeSpan.FromMinutes(30))
                Status = 2;
            else
                Status = 1;

            return Status;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void barBtnAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var row in gridView1.GetSelectedRows())
            {
                if (gridView1.SelectedRowsCount == 0)
                    Utilities.ErrorMessage("No Interlocale(s) Selected");
                else if (gridView1.RowCount == 0)
                    Utilities.ErrorMessage("No Record(s) Found");
                //else if (Utilities.CheckBrethrenIfAttended(frmAttendanceMonitoring.GatheringID, gridView1.GetRowCellValue(row, "Interlocale_Id").ToString()))
                //    Utilities.ErrorMessage("Interlocale Brethren Already Timed in");
                else
                {
                    using (var cmd = new SqlCommand("INSERT_TEMP_ATTENDANCE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tempGathering_ID", frmAttendanceMonitoring.GatheringID);
                        //cmd.Parameters.AddWithValue("@tempChurch_ID", gridView1.GetRowCellValue(row, "Church_Id"));
                        cmd.Parameters.AddWithValue("@tempAttendance_Status", frmAttendanceMonitoring.Status);
                        cmd.Parameters.AddWithValue("@tempReal_Time", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@is_interlocale", true);
                        //cmd.Parameters.AddWithValue("@remarks", gridView1.GetRowCellValue(row, "Locale"));
                        cmd.Parameters.AddWithValue("@temp_brethren_id", gridView1.GetRowCellValue(row, "Interlocale_Id").ToString());
                        cmd.Parameters.AddWithValue("@locale", gridView1.GetRowCellValue(row, "Locale").ToString());
                        cmd.ExecuteNonQuery();
                        var InterlocaleName = gridView1.GetRowCellValue(row, "Firstname").ToString() + " " + gridView1.GetRowCellValue(row, "Lastname");
                        Utilities.SuccessMessage(InterlocaleName + " Successfully Timed In");
                        Instances.attendanceMontoring.lblStatus.Text = txtFirstname.Text + " " + txtLastname.Text + " SUCCESSFULLY TIMED IN";

                        //Instances.attendanceMontoring.peBrethren.Image = null;

                        frmAttendanceMonitoring.drAttendance = frmAttendanceMonitoring.dtAttendance.NewRow();
                        var dr = frmAttendanceMonitoring.drAttendance;
                        dr["temp_brethren_id"] = gridView1.GetRowCellValue(row, "Interlocale_Id").ToString();
                        dr["tempChurch_ID"] = gridView1.GetRowCellValue(row, "Church_Id").ToString();
                        dr["Name"] = InterlocaleName;
                        dr["tempReal_Time"] = DateTime.Now.ToShortTimeString();
                        dr["tempAttendance_Status"] = (frmAttendanceMonitoring.Status == 1 ? "TIMED IN" : "LATE");
                        dr["is_interlocale"] = "YES";
                        dr["locale"] = gridView1.GetRowCellValue(row, "Locale").ToString();
                        frmAttendanceMonitoring.dtAttendance.Rows.Add(dr);
                        frmAttendanceMonitoring.dtAttendance.AcceptChanges();
                        
                        this.Close();
                    }
                }
            }
        }

        private void gridInterlocale_MouseClick(object sender, MouseEventArgs e)
        {
            Utilities.FMode = "Edit";
            InterlocaleIDValue = gridView1.Columns.View.GetFocusedRowCellValue("Interlocale_Id").ToString();
            txtChurchID.Text = gridView1.Columns.View.GetFocusedRowCellValue("Church_Id").ToString();
            txtFirstname.Text = gridView1.Columns.View.GetFocusedRowCellValue("Firstname").ToString();
            txtLastname.Text = gridView1.Columns.View.GetFocusedRowCellValue("Lastname").ToString();
            txtLocale.Text = gridView1.Columns.View.GetFocusedRowCellValue("Locale").ToString();
            txtMiddlename.Text = gridView1.Columns.View.GetFocusedRowCellValue("Middlename").ToString();
            dateBaptism.EditValue = gridView1.Columns.View.GetFocusedRowCellValue("DateOfBaptism").ToString();
            btnSave.Text = "Update";
        }

        private void btnChurchID_Click(object sender, EventArgs e)
        {
            txtChurchID.Show();
            LabelCI.Text = "Church ID :";
            HideButtons();
        }

        private void btnBaptism_Click(object sender, EventArgs e)
        {
            dateBaptism.Show();
            LabelCI.Text = "Date of Baptism :";
            HideButtons();
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            txtChurchID.Show();
            LabelDoB.Show();
            LabelCI.Text = "Church ID :";
            txtChurchID.Focus();
            dateBaptism.Show();
            HideButtons();
        }
    }
}
