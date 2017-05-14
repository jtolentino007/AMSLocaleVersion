using System.Data;
using AMS.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmCommittees : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtCommittee;
        public frmCommittees()
        {
            InitializeComponent();
        }

        public void GetCommittee()
        {
            Utilities.SQLConnectionOpen();
            using (var adapt = new SqlDataAdapter("GET_COMMITTEE", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtCommittee = new DataTable();
                dtCommittee.Clear();
                adapt.Fill(dtCommittee);
                gridCommittee.DataSource = dtCommittee;
            }
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void mnuBtnAddCommitttee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.committeeAddEdit.dtCommittee = dtCommittee;
            Instances.committeeAddEdit.ShowDialog();
        }

        private void mnuBtnEditCommitttee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Committee");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Committee(s) Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Committee");
            else
            {
                Utilities.FMode = "Edit";
                Instances.committeeAddEdit.drCommittee = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.committeeAddEdit.ShowDialog();
            }
        }

        private void mnuBtnDeleteCommitttee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Committee(s) Selected");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Record(s) Found");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to Remove Committee(s)?"))
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        using (var cmd = new SqlCommand("DELETE_COMMITTEE", Utilities.con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CommitteeID", gridView1.GetRowCellValue(row, "committee_id").ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Utilities.SuccessMessage("Committee(s) successfully removed");
                    GetCommittee();
                }
            }
        }

        private void frmCommittees_Load(object sender, System.EventArgs e)
        {
            GetCommittee();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }
    }
}
