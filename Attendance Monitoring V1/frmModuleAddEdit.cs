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
using AMS.Classes;

namespace AMS
{
    public partial class frmModuleAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dtModules { get; set; }
        public DataRow drModules { get; set; }
        public frmModuleAddEdit()
        {
            InitializeComponent();
        }

        private void simpleButtonAddModule_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textEditModule.Text) || !string.IsNullOrWhiteSpace(textEditParentID.Text))
            {
                if (Utilities.FMode == "Add")
                {
                    using (var cmd = new SqlCommand("INSERT_MODULE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@parent_id", textEditParentID.Text);
                        cmd.Parameters.AddWithValue("@module_name", textEditModule.Text);
                        cmd.ExecuteNonQuery();

                        var drModules = dtModules.NewRow();
                        drModules["parent_id"] = textEditParentID.Text;
                        drModules["module_name"] = textEditModule.Text;
                        dtModules.Rows.Add(drModules);
                        dtModules.AcceptChanges();

                        Utilities.SuccessMessage("Module successfully saved.");
                        Utilities.GenerateSystemLog("Added Module", "Module Management", 1);
                        textEditParentID.Text = string.Empty;
                        textEditModule.Text = string.Empty;
                        this.Hide();
                    }
                }
                else
                {
                    using (var cmd = new SqlCommand("UPDATE_MODULE", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@module_id", Convert.ToInt32(drModules["module_id"]));
                        cmd.Parameters.AddWithValue("@parent_id", textEditParentID.Text);
                        cmd.Parameters.AddWithValue("@module_name", textEditModule.Text);
                        cmd.ExecuteNonQuery();

                        drModules["parent_id"] = textEditParentID.Text;
                        drModules["module_name"] = textEditModule.Text;
                        drModules.AcceptChanges();

                        Utilities.SuccessMessage("Module successfully updated.");
                        Utilities.GenerateSystemLog("Updated Module", "Module Management", 1);
                        textEditParentID.Text = string.Empty;
                        textEditModule.Text = string.Empty;
                        this.Hide();
                    }
                }
            }
            else
            {
                Utilities.ErrorMessage("Please fill in the required field(s)");
            }
            
        }

        private void simpleButtonCloseModule_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmModuleAddEdit_Load(object sender, EventArgs e)
        {
            if (Utilities.FMode == "Edit")
            {
                textEditParentID.Text = drModules["parent_id"].ToString();
                textEditModule.Text = drModules["module_name"].ToString();
            }
            else
            {
                textEditParentID.Text = string.Empty;
                textEditModule.Text = string.Empty;
            }
        }
    }
}
