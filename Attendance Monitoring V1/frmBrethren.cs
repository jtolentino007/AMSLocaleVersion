using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS.Classes;
using System.Data.SqlClient;

namespace AMS
{
    public partial class frmBrethren : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtBrethren = new DataTable();
        public frmBrethren()
        {
            InitializeComponent();
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void FillBrethren()
        {
            using (var brethrenAdapter = new SqlDataAdapter("GET_BRETHREN", Utilities.con))
            {
                dtBrethren.Clear();
                brethrenAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                brethrenAdapter.Fill(dtBrethren);
                gridBrethren.DataSource = dtBrethren;
            }
        }

        private void mBtnAddBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.brethrenAddEdit.dtBrethren = dtBrethren;
            Instances.brethrenAddEdit.ShowDialog();
        }

        private void mnuBtnEditBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Brethren");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Brethren Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Brethren");
            else
            {
                Utilities.FMode = "Edit";
                Instances.brethrenAddEdit.drBrethren = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.brethrenAddEdit.ShowDialog();
            }
        }

        private void frmBrethren_Load(object sender, EventArgs e)
        {
            FillBrethren();
        }

        private void mnuBtnRemoveBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Brethren(s) Selected");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Record(s) Found");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to Remove Brethren(s)?"))
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        using (var cmd = new SqlCommand("DELETE_BRETHREN", Utilities.con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BrethrenID", gridView1.GetRowCellValue(row, "brethren_id").ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Utilities.SuccessMessage("Brethren(s) successfully removed");
                    FillBrethren();
                }
            }

        }

        private void mnuBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }
    }
}
