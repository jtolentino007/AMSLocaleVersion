using System;
using AMS.Classes;
using System.Data.SqlClient;
using System.Data;

namespace AMS
{
    public partial class frmCommitteesAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dtCommittee { get; set; }
        public DataRow drCommittee { get; set; }
        public frmCommitteesAddEdit()
        {
            InitializeComponent();
        }

        private void GenerateDeptCode()
        {
            string CommitteeCode = Utilities.GetLastCodeFromTable("committee_code", "Committee");
            if (CommitteeCode == null)
                txtCommitteeCode.Text = "DEPT-1000";
            else
                txtCommitteeCode.Text = "DEPT-" + (Convert.ToInt16(CommitteeCode.Replace("DEPT-", "")) + 1);
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private bool CommitteeUpdate()
        {
            Utilities.SQLConnectionOpen();
            using (var cmd = new SqlCommand("UPDATE_COMMITTEE", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CommitteeCode", txtCommitteeCode.Text);
                cmd.Parameters.AddWithValue("@Committee", txtCommittee.Text);
                Int32 result = (Int32)cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }

        private bool CommitteeInsert()
        {
            Utilities.SQLConnectionOpen();
            using (var cmd = new SqlCommand("INSERT_COMMITTEE", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CommitteCode", txtCommitteeCode.Text);
                cmd.Parameters.AddWithValue("@Committee", txtCommittee.Text);
                Int32 result = (Int32)cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }

        private void SetCommitteeDetails()
        {
            Utilities.ID = Convert.ToInt32(drCommittee["committee_id"].ToString());
            txtCommitteeCode.Text = drCommittee["committee_code"].ToString();
            txtCommittee.Text = drCommittee["committee_name"].ToString();
        }

        private void ClearControls()
        {
            txtCommitteeCode.Text = string.Empty;
            txtCommittee.Text = string.Empty;
            txtCommittee.Focus();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtCommittee.Text))
            {
                txtCommittee.Focus();
                Utilities.ErrorMessage("Committee is required");
                return false;
            }

            return true;
        }

        private void frmCommitteesAddEdit_Load(object sender, EventArgs e)
        {
            if (Utilities.FMode == "Add")
            {
                ClearControls();
                GenerateDeptCode();
            }
            else if (Utilities.FMode == "Edit")
                SetCommitteeDetails();
            txtCommittee.Select();
        }

        private void mnuBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsValid())
            {
                if(Utilities.FMode == "Add")
                {
                    if (CommitteeInsert())
                    {
                        Utilities.SuccessMessage("Committee Successfully saved");
                        Utilities.GenerateSystemLog("Added " + txtCommittee.Text, "Committee Management", 1);
                        ClearControls();
                        GenerateDeptCode();
                        Instances.committee.GetCommittee();
                        Instances.brethrenAddEdit.FillCommittee();
                        this.Close();
                    }
                }
                else if (Utilities.FMode == "Edit")
                {
                    if (CommitteeUpdate())
                    {
                        Utilities.SuccessMessage("Committee Successfully updated");
                        Utilities.GenerateSystemLog("Edited " + txtCommittee.Text, "Committee Management", 1);
                        Instances.brethrenAddEdit.FillGroup();
                        Instances.committee.GetCommittee();
                        this.Close();
                    }
                }
            }
        }
    }
}
