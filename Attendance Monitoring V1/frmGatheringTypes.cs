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
    public partial class frmGatheringTypes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtGatheringTypes;
        public frmGatheringTypes()
        {
            InitializeComponent();
        }

        public void GetGatheringTypes()
        {
            using (var adapt = new SqlDataAdapter("GET_GATHERING_TYPES", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtGatheringTypes = new DataTable();
                dtGatheringTypes.Clear();
                adapt.Fill(dtGatheringTypes);
                gridGatheringType.DataSource = dtGatheringTypes;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barBtnAddGatheringType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "New";
            Instances.gatheringTypeaddEdit.dtGatheringType = this.dtGatheringTypes;
            Instances.gatheringTypeaddEdit.ShowDialog();
        }

        private void frmGatheringTypes_Load(object sender, EventArgs e)
        {
            GetGatheringTypes();
        }

        private void barBtnEditGatheringType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Gathering Type");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Gathering Type Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Gathering Type");
            else
            {
                Utilities.FMode = "Edit";
                Instances.gatheringTypeaddEdit.drGatheringType = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.gatheringTypeaddEdit.ShowDialog();
            }
        }

        private void barBtnDeleteGatheringType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Gathering Type(s) Selected");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Record(s) Found");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to Remove Gathering Type(s)?"))
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        using (var cmd = new SqlCommand("DELETE_GATHERING_TYPE", Utilities.con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Gathering_ID", gridView1.GetRowCellValue(row, "gathering_id").ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Utilities.SuccessMessage("Gathering Type(s) successfully removed");
                    GetGatheringTypes();
                }
            }
        }

        private void barBtnSearchGatheringType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }
    }
}
