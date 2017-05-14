using AMS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmGroups : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dtGroupingMain;
        public frmGroups()
        {
            InitializeComponent();
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void frmGroups_Load(object sender, System.EventArgs e)
        {
            GetGroup();
        }

        private void mnuBtnAddGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.groupAdd.dtGroups = dtGroupingMain;
            Instances.groupAdd.ShowDialog();
        }

        private void mnuBtnEditGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Group");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Group Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Group");
            else
            {
                Utilities.FMode = "Edit";
                Instances.groupAdd.drGroups = gridView1.GetDataRow(gridView1.FocusedRowHandle); 
                Instances.groupAdd.ShowDialog();
            }
        }

        public void GetGroup()
        {
            Utilities.SQLConnectionOpen();
            using (var adapt = new SqlDataAdapter("GET_GROUPINGS", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtGroupingMain = new DataTable();
                dtGroupingMain.Clear();
                adapt.Fill(dtGroupingMain);
                gridGroups.DataSource = dtGroupingMain;
            }
        }

        private void mnuBtnDeleteGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Group(s) Selected");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Record(s) Found");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to Remove Group(s)?"))
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        using (var cmd = new SqlCommand("DELETE_GROUPINGS", Utilities.con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@GroupId", gridView1.GetRowCellValue(row, "Group_Id").ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Utilities.SuccessMessage("Group(s) successfully removed");
                    GetGroup();
                }
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }
    }
}
