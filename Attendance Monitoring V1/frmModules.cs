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
    public partial class frmModules : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtModules = new DataTable();

        public frmModules()
        {
            InitializeComponent();
            GetModules();
        }

        private void GetModules()
        {
            using (var adapter = new SqlDataAdapter("GET_MODULES", Utilities.con))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dtModules);
                gridControl1.DataSource = dtModules;
            }
        }

        private void barButtonItemAddModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.moduleAddEdit.dtModules = dtModules;
            Instances.moduleAddEdit.ShowDialog();
        }

        private void barButtonItemEditModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Edit";
            Instances.moduleAddEdit.drModules = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            Instances.moduleAddEdit.ShowDialog();
        }

        private void barButtonItemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barButtonItemDeleteModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Privilege");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Privilege Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Privilege");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to delete this Privilege?"))
                {
                    using (var cmd = new SqlCommand("UPDATE Modules SET is_deleted=1 WHERE module_id = " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["module_id"], Utilities.con))
                    {
                        cmd.ExecuteNonQuery();

                        Utilities.SuccessMessage("Module " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["module_name"].ToString() + ", successfully removed");

                        dtModules.Rows[gridView1.FocusedRowHandle].Delete();
                    }
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
