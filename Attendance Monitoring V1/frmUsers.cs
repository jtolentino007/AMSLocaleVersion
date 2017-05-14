using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using AMS.Classes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmUsers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtUsers = new DataTable();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void GetUsers()
        {
            using (var userAdapt = new SqlDataAdapter("GET_USERS", Utilities.con))
            {
                dtUsers.Clear();
                userAdapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                userAdapt.Fill(dtUsers);
                gridUsers.DataSource = dtUsers;
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void barBtnActivateUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var checkedRow in gridView1.GetSelectedRows())
            {
                using (var cmd = new SqlCommand("UPDATE Users SET is_approve = 1 WHERE user_id=" + gridView1.GetRowCellValue(checkedRow, "user_id"), Utilities.con))
                {
                    cmd.ExecuteNonQuery();
                    Utilities.SuccessMessage("Selected Users successfully approved");
                    GetUsers();
                }
            }
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barBtnDeactivate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var checkedRow in gridView1.GetSelectedRows())
            {
                using (var cmd = new SqlCommand("UPDATE Users SET is_approve = 0 WHERE user_id=" + gridView1.GetRowCellValue(checkedRow, "user_id"), Utilities.con))
                {
                    cmd.ExecuteNonQuery();
                    Utilities.SuccessMessage("Selected Users successfully deactivated");
                    GetUsers();
                }
            }
        }
    }
}
