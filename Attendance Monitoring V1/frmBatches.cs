using AMS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AMS
{
    public partial class frmBatches : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtBatches = new DataTable();
        public frmBatches()
        {
            InitializeComponent();
        }
        
        private void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.BatchAddEdit.ShowDialog();
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void GetBatches()
        {
            using (var adapt = new SqlDataAdapter("GET_BATCHES",Utilities.con))
            {
                dtBatches.Clear();
                adapt.Fill(dtBatches);
                gridBatches.DataSource = dtBatches;
            }
        }

        private void frmBatches_Load(object sender, EventArgs e)
        {
            
            GetBatches();
        }

        private void barBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Batch");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Batche(s) Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Batch");
            else
            {
                Utilities.FMode = "Edit";
                Instances.BatchAddEdit.drBatch = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.BatchAddEdit.ShowDialog();
            }
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Batche(s) Selected");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Record(s) Found");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to Remove Batche(s)?"))
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        using (var cmd = new SqlCommand("DELETE_BATCH", Utilities.con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BatchID", gridView1.GetRowCellValue(row, "Batch_ID").ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Utilities.SuccessMessage("Batche(s) successfully removed");
                    GetBatches();
                }
            }
        }
    }
}
