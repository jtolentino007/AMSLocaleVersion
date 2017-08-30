using AMS.Classes;
using DevExpress.Data.Filtering;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmAttendanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtBrethren = new DataTable();
        public static DataTable dtAttendance = new DataTable();
        public static string GatheringID;
        public static DateTime Time;
        public static DataRow drAttendance;
        public static bool _isGatheringSetup = false;
        public static Form amsForm { get; set; }
        public static int Status = 1;

        public frmAttendanceForm()
        {
            InitializeComponent();
        }

        public void GetBrethrenList()
        {
            using (var adapt = new SqlDataAdapter("GET_BRETHREN_LIST", Utilities.con))
            {
                dtBrethren.Clear();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtBrethren);
                gridBrethren.DataSource = dtBrethren;
            }
        }

        public void InitializeAttendeesTable()
        {
            dtAttendance.Columns.Add("temp_brethren_id");
            dtAttendance.Columns.Add("tempChurch_ID");
            dtAttendance.Columns.Add("Name");
            dtAttendance.Columns.Add("tempReal_Time");
            dtAttendance.Columns.Add("tempAttendance_Status");
            dtAttendance.Columns.Add("is_interlocale");
            dtAttendance.Columns.Add("locale");
            dtAttendance.AcceptChanges();
        }

        private void frmAttendanceForm_Load(object sender, EventArgs e)
        {
            GetBrethrenList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridView1.ActiveFilterCriteria = new BinaryOperator(new BinaryOperator(new OperandProperty("Church_Id"), new OperandValue("%"+txtSearch.Text+"%"),BinaryOperatorType.Like), new BinaryOperator(new OperandProperty("BrethrenName"), new OperandValue("%" + txtSearch.Text + "%"), BinaryOperatorType.Like), BinaryOperatorType.BitwiseOr);
                gridBrethren.Focus();
            }
        }

        private void frmAttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (barButtonItemEndAttendance.Visibility == BarItemVisibility.Always)
            {
                Utilities.ErrorMessage("You must end this batch to close this form");
                e.Cancel = true;
            }
            else
                this.Hide();
        }

        private void barButtonItemTimeIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var row in gridView1.GetSelectedRows())
            {
                if (gridView1.SelectedRowsCount == 0)
                    Utilities.ErrorMessage("No Brethren Selected");
                else if (gridView1.RowCount == 0)
                    Utilities.ErrorMessage("No Brethren Found");
                //else if (dtAttendance.Rows.Contains == "John Kenneth Tolentino")
                   //Utilities.ErrorMessage("Brethren Already Timed In");
                else
                {
                    using (var cmd = new SqlCommand("INSERT_TEMP_ATTENDANCE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tempGathering_ID", GatheringID);
                        //cmd.Parameters.AddWithValue("@tempChurch_ID", gridView2.GetRowCellValue(row, "Church_Id"));
                        cmd.Parameters.AddWithValue("@tempAttendance_Status", Status);
                        cmd.Parameters.AddWithValue("@tempReal_Time", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@is_interlocale", gridView1.GetRowCellValue(row, "is_interlocale").ToString());
                        cmd.Parameters.AddWithValue("@locale", gridView1.GetRowCellValue(row, "locale").ToString());
                        cmd.Parameters.AddWithValue("@temp_brethren_id", gridView1.GetRowCellValue(row, "brethren_id").ToString());
                        cmd.ExecuteNonQuery();

                        if (!string.IsNullOrWhiteSpace(gridView1.GetRowCellValue(row, "Image_Path").ToString()))
                            peMember.Image = Image.FromFile(gridView1.GetRowCellValue(row, "Image_Path").ToString());
                        else
                            peMember.Image = null;

                        MessageBox.Show(gridView1.GetRowCellValue(row, "BrethrenName").ToString() + " SUCCESSFULLY TIMED IN");
                    }
                    drAttendance = dtAttendance.NewRow();
                    drAttendance["temp_brethren_id"] = gridView1.GetRowCellValue(row, "brethren_id").ToString();
                    drAttendance["tempChurch_ID"] = gridView1.GetRowCellValue(row, "Church_Id").ToString();
                    drAttendance["Name"] = gridView1.GetRowCellValue(row, "BrethrenName").ToString();
                    drAttendance["tempReal_Time"] = DateTime.Now.ToShortTimeString();
                    drAttendance["tempAttendance_Status"] = (Status == 1 ? "TIMED IN" : "LATE");
                    drAttendance["is_interlocale"] = (Convert.ToInt16(gridView1.GetRowCellValue(row, "is_interlocale")) == 1 ? "YES" : "NO");
                    drAttendance["locale"] = gridView1.GetRowCellValue(row, "locale").ToString();
                    dtAttendance.Rows.Add(drAttendance);
                    dtAttendance.AcceptChanges();
                }

                txtSearch.ResetText();
            }
            lblChurchID.Text = gridView1.GetFocusedRowCellValue("Church_Id").ToString();
            lblName.Text = gridView1.GetFocusedRowCellValue("BrethrenName").ToString();
            lblLocale.Text = gridView1.GetFocusedRowCellValue("locale").ToString();
        }

        private void barButtonItemNewInterlocale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.Interlocale.ShowDialog();
        }

        private void frmAttendanceForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gridBrethren_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barButtonItemTimeIn.PerformClick();
                txtSearch.Focus();
            }
        }

        private void barButtonItemNewMember_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.NewlyBaptizedForm.ShowDialog();
        }

        private void barButtonItemLateStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Utilities.QuestionMessage("Are you sure you want to Activate Late Status?"))
            {
                Status = 2;
                barButtonItemLateStatus.Caption = "Late Status Activated";
                barButtonItemLateStatus.Enabled = false;
            }
        }

        public void BindAttendeesToList()
        {
            Instances.attendees.gridControlAttendees.DataSource = dtAttendance;
            Instances.attendees.ShowDialog();   
        }

        private void barButtonItemViewAttendees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindAttendeesToList();
            Instances.attendees.ShowDialog();
        }

        private void barButtonItemEndAttendance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Utilities.QuestionMessage("Are you sure you want to End this Attendance?"))
            {
                if (dtAttendance.Rows.Count == 0)
                    Utilities.ErrorMessage("No Brethren Attended in this Batch");
                else
                    Instances.assignees.ShowDialog();

            }
        }
    }
}
