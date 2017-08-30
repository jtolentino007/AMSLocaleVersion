using AMS.Classes;
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
    public partial class frmGatheringTypeAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dtGatheringType { get; set; }
        public DataRow drGatheringType { get; set; }
        public frmGatheringTypeAddEdit()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtGathering.Text = string.Empty;
            txtGatheringCode.Text = string.Empty;
            txtGatheringCode.Focus();
        }

        private void SetDetails()
        {
            Utilities.ID = Convert.ToInt32(drGatheringType["gathering_id"].ToString());
            txtGatheringCode.Text = drGatheringType["gathering_code"].ToString();
            txtGathering.Text = drGatheringType["gathering"].ToString();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtGatheringCode.Text))
            {
                txtGatheringCode.Focus();
                Utilities.ErrorMessage("Gathering code is required");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtGathering.Text))
            {
                txtGathering.Focus();
                Utilities.ErrorMessage("Gathering is required");
                return false;
            }
            else
                return true;
        }

        private void AddRefreshGatheringType()
        {
            var dr = dtGatheringType.NewRow();
            dr["gathering_id"] = Utilities.GetLastCodeFromTable("gathering_id","Gathering_types");
            dr["gathering_code"] = txtGatheringCode.Text;
            dr["gathering"] = txtGathering.Text;

            dtGatheringType.Rows.Add(dr);
            dtGatheringType.AcceptChanges();
        }

        private void UpdateRefreshGatheringType()
        {
            drGatheringType["gathering_code"] = txtGatheringCode.Text;
            drGatheringType["gathering"] = txtGathering.Text;

            drGatheringType.AcceptChanges();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsValid())
            {
                if (Utilities.FMode == "New")
                {
                    using (var cmd = new SqlCommand("INSERT_GATHERING_TYPE",Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@GatheringCode", txtGatheringCode.Text);
                        cmd.Parameters.AddWithValue("@Gathering", txtGathering.Text);
                        cmd.ExecuteNonQuery();

                        Utilities.SuccessMessage("Gathering Type Successfully Saved");
                        AddRefreshGatheringType();

                        Clear();
                        this.Hide();
                    }
                }
                else
                {
                    using (var cmd = new SqlCommand("UPDATE_GATHERING_TYPE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Gathering_Type_ID", Utilities.ID);
                        cmd.Parameters.AddWithValue("@Gathering_Code", txtGatheringCode.Text);
                        cmd.Parameters.AddWithValue("@Gathering", txtGathering.Text);
                        cmd.ExecuteNonQuery();

                        Utilities.SuccessMessage("Gathering Type Successfully Updated");

                        UpdateRefreshGatheringType();

                        Clear();
                        this.Hide();
                    }
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void frmGatheringTypeAddEdit_Load(object sender, EventArgs e)
        {
            if (Utilities.FMode == "Edit")
                SetDetails();
            else
                Clear();
        }
    }
}
