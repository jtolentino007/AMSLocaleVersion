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
    public partial class frmPrivilegeAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dtPrivileges { get; set; }
        public DataRow drPrivileges { get; set; }
        public frmPrivilegeAddEdit()
        {
            InitializeComponent();
        }

        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textEditPrivilege.Text))
            {
                if (Utilities.FMode == "Add")
                {
                    using (var cmd = new SqlCommand("INSERT_PRIVILEGE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Privilege", textEditPrivilege.Text);
                        cmd.ExecuteNonQuery();

                        Utilities.SuccessMessage("Privilege successfully saved");

                        var drow = dtPrivileges.NewRow();

                        drow["privilege_id"] = Utilities.GetLastCodeFromTable("privilege_id", "Privileges");
                        drow["privilege_name"] = textEditPrivilege.Text;

                        dtPrivileges.Rows.Add(drow);
                        dtPrivileges.AcceptChanges();

                        Utilities.GenerateSystemLog("Created Prvilege " + textEditPrivilege.Text, "Privilege Management", 1);
                    }
                }
                else
                {
                    using (var cmd = new SqlCommand("UPDATE_PRIVILEGE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@privilege_id", Convert.ToInt64(drPrivileges["privilege_id"]));
                        cmd.Parameters.AddWithValue("@privilege_name", textEditPrivilege.Text);
                        cmd.ExecuteNonQuery();

                        Utilities.SuccessMessage("Privilege successfully updated");

                        drPrivileges["privilege_name"] = textEditPrivilege.Text;

                        drPrivileges.AcceptChanges();

                        Utilities.GenerateSystemLog("Updated Prvilege " + textEditPrivilege.Text, "Privilege Management", 1);
                    }
                }

                textEditPrivilege.Text = "";
                this.Hide();
            }
            else
            {
                Utilities.ErrorMessage("Please fill the blank field(s)");
            }
        }

        private void frmPrivilegeAddEdit_Load(object sender, EventArgs e)
        {
            textEditPrivilege.Text = string.Empty;

            if (Utilities.FMode == "Edit")
                textEditPrivilege.Text = drPrivileges["privilege_name"].ToString();

        }
    }
}
