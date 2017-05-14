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
    public partial class frmSystemLogs : Form
    {
        DataTable dtLogs = new DataTable();
        public frmSystemLogs()
        {
            InitializeComponent();
        }

        private void GetSystemLogs(int user_id, DateTime dateStart, DateTime dateEnd)
        {
            using (var adapter = new SqlDataAdapter("GET_SYSTEM_LOGS", Utilities.con))
            {
                dtLogs.Clear();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@User_Priv", frmMain.userPrivilege);
                adapter.SelectCommand.Parameters.AddWithValue("@User_id", user_id);
                adapter.SelectCommand.Parameters.AddWithValue("@StartDate", dateStart);
                adapter.SelectCommand.Parameters.AddWithValue("@EndDate", dateEnd);
                adapter.Fill(dtLogs);
                gridLogs.DataSource = dtLogs;
            }
        }

        public void GetSystemLogsByUser()
        {
            Utilities.FillLookUpEdit(lueUsers, "GET_USERS", "fullname", "user_id");
            dateStart.EditValue = DateTime.Now.ToShortDateString();
            dateEnd.EditValue = DateTime.Now.ToShortDateString();

            if (frmMain.userPrivilege == 1)
            {
                lblUser.Visible = true;
                lueUsers.Visible = true;
                lueUsers.EditValue = "";
                btnFilter.Location = new Point(920, 73);
                gridView1.Columns["Username"].Visible = true;
            }
            else
            {
                lblUser.Visible = false;
                lueUsers.Visible = false;
                lueUsers.EditValue = frmLogin.User_id;
                btnFilter.Location = new Point(599, 73);
                gridView1.Columns["Username"].Visible = false;
            }
            GetSystemLogs(frmLogin.User_id, Convert.ToDateTime(dateStart.EditValue), Convert.ToDateTime(dateEnd.EditValue));
        }

        private void frmSystemLogs_Load(object sender, EventArgs e)
        {
            GetSystemLogsByUser();
        }

        private void dateStart_EditValueChanged(object sender, EventArgs e)
        {
            //GetSystemLogs();
        }

        private void dateEnd_EditValueChanged(object sender, EventArgs e)
        {
            //GetSystemLogs();
        }

        private void lueUsers_EditValueChanged(object sender, EventArgs e)
        {
            //GetSystemLogs();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (frmMain.userPrivilege == 1)
            {
                if (lueUsers.Text == "")
                    lueUsers.EditValue = frmLogin.User_id;
                else 
                    GetSystemLogs(Convert.ToInt32(lueUsers.EditValue), Convert.ToDateTime(dateStart.EditValue), Convert.ToDateTime(dateEnd.EditValue));
            }
            else
                GetSystemLogs(frmLogin.User_id, Convert.ToDateTime(dateStart.EditValue), Convert.ToDateTime(dateEnd.EditValue));

            if (Convert.ToDateTime(dateEnd.EditValue) < Convert.ToDateTime(dateStart.EditValue))
                Utilities.ErrorMessage("Invalid Date Range");
        }
    }
}
