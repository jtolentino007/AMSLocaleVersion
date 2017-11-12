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
    public partial class frmPrivileges : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtPrivileges = new DataTable();

        public frmPrivileges()
        {
            InitializeComponent();
        }

        private void barButtonItemAddPrivilege_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.privilegeAddEdit.dtPrivileges = dtPrivileges;
            Instances.privilegeAddEdit.ShowDialog();
        }

        private void barButtonItemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barButtonItemEditPrivilege_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Privilege");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Privilege Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Privilege");
            else
            {
                Utilities.FMode = "Edit";
                Instances.privilegeAddEdit.drPrivileges = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.privilegeAddEdit.ShowDialog();
            }
        }

        private void GetPrivileges()
        {
            using (var adapt = new SqlDataAdapter("GET_PRIVILEGES", Utilities.con))
            {
                dtPrivileges.Clear();
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtPrivileges);
                gridControlPrivileges.DataSource = dtPrivileges;
            }
        }

        private void frmPrivileges_Load(object sender, EventArgs e)
        {
            GetPrivileges();
        }

        private void barButtonItemDeletePrivilege_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    using (var cmd = new SqlCommand("UPDATE Privileges SET is_deleted=1 WHERE privilege_id = " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["privilege_id"], Utilities.con))
                    {
                        cmd.ExecuteNonQuery();

                        Utilities.SuccessMessage("Privilege " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["privilege_name"].ToString() + ", successfully removed");

                        dtPrivileges.Rows[gridView1.FocusedRowHandle].Delete();
                    }
                }
            }
        }

        private void barButtonItemSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }

        private void barButtonItemPermissions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.permissions.PrivilegeID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["privilege_id"]);
            Instances.permissions.ShowDialog();
        }
    }
}
