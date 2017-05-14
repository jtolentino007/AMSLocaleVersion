using AMS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmBatchAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow drBatch;
        public frmBatchAddEdit()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Utilities.FMode == "Add")
            {
                using (var cmd = new SqlCommand("INSERT_BATCH", Utilities.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Batch_Code", "B" + txtBatchNo.Text);
                    cmd.Parameters.AddWithValue("@Gathering_ID", cboGathering.EditValue);
                    cmd.Parameters.AddWithValue("@BatchTime", Convert.ToDateTime(dtTime.Value).ToString("hh:mm tt"));
                    cmd.ExecuteNonQuery();
                    Utilities.SuccessMessage("Batch Successfully Saved");
                    Utilities.GenerateSystemLog("Added " + "B" + txtBatchNo.Text + " on " + cboGathering.EditValue, "Batch Management", 1);
                    Instances.Batches.GetBatches();
                    this.Close();
                }
            }
            else
            {            
                using (var cmd = new SqlCommand("UPDATE_BATCH", Utilities.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BatchID", Utilities.ID);
                    cmd.Parameters.AddWithValue("@Batch_Code", "B" + txtBatchNo.Text);
                    cmd.Parameters.AddWithValue("@Gathering_ID", cboGathering.EditValue);
                    cmd.Parameters.AddWithValue("@Batch_Time", Convert.ToDateTime(dtTime.Value).ToString("hh:mm tt"));
                    cmd.ExecuteNonQuery();
                    Utilities.SuccessMessage("Batch Successfully Updated");
                    Utilities.GenerateSystemLog("Edited " + "B" + txtBatchNo.Text + " on " + cboGathering.EditValue, "Batch Management", 1);
                    Instances.Batches.GetBatches();
                    this.Close();
                }
            }
        }

        private void LoadGatheringTypes()
        {
            Utilities.FillLookUpEdit(cboGathering, "GET_GATHERING_TYPES","gathering","gathering_id");
        }

        private void frmBatchAddEdit_Load(object sender, EventArgs e)
        {
            LoadGatheringTypes();
            cboGathering.EditValue = null;
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.CustomFormat = "HH:mm tt";
            dtTime.Value = DateTime.Now.Date;
            txtBatchNo.Text = null;
            if (Utilities.FMode == "Edit")
            {
                Utilities.ID = Convert.ToInt16(drBatch["Batch_ID"].ToString());
                txtBatchNo.Text = drBatch["Batch_Code"].ToString().Replace("B","");
                cboGathering.EditValue = drBatch["gathering_id"];
                cboGathering.RefreshEditValue();
                dtTime.Value = Convert.ToDateTime(drBatch["Batch_Time"].ToString());
            }
        }
    }
}
