using System.Data;
using AMS.Classes;
using System.Data.SqlClient;
using System;

namespace AMS
{
    public partial class frmAddGroup : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtBrethren = new DataTable();
        public DataTable dtGroups { get; set; }
        public DataRow drGroups { get; set; }
        public frmAddGroup()
        {
            InitializeComponent();
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void SetDetails()
        {
            Utilities.ID = Convert.ToInt32(drGroups[0].ToString());
            txtGroupName.Text = drGroups[1].ToString();
            lueGroupServant.EditValue = drGroups[2].ToString();
            lueAsstGroupServant.EditValue = drGroups[3].ToString();
        }

        private void mnuBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
            {
                Utilities.ErrorMessage("Group name is required");
                txtGroupName.Focus();
            }
            else
            {
                if (Utilities.FMode == "Add" || Utilities.SFMode == "Add")
                {
                    if (GroupInsert())
                    {
                        Utilities.SuccessMessage("Group successfully saved");
                        Utilities.GenerateSystemLog("Added Group " + txtGroupName.Text, "Group Management", 1);

                        Instances.group.GetGroup();
                        Instances.brethrenAddEdit.FillGroup();
                        ClearControls();

                        this.Close();
                    }
                    else
                    {
                        Utilities.ErrorMessage("Save Failed");
                        Utilities.GenerateSystemLog("Group Save Failed", "Group Management", 3);
                    }
                }
                else if (Utilities.FMode == "Edit")
                {
                    if (GroupUpdate())
                    {
                        Utilities.SuccessMessage("Group successfully updated");
                        Utilities.GenerateSystemLog("Edit " + txtGroupName.Text, "Group Management", 1);
                        drGroups["Group_Id"] = Convert.ToInt32(Utilities.ID);
                        drGroups["Group_name"] = txtGroupName.Text;
                        drGroups["servant_id"] = lueGroupServant.EditValue;
                        drGroups["Group_servant"] = lueGroupServant.Text;
                        drGroups["asst_servant_id"] = lueAsstGroupServant.EditValue;
                        drGroups["Asst_servant"] = lueAsstGroupServant.Text;

                        drGroups.AcceptChanges();

                        ClearControls();
                        this.Close();
                    }
                    else
                    {
                        Utilities.ErrorMessage("Update Failed");
                        Utilities.GenerateSystemLog("Group Update Failed", "Group Management", 3);
                    }
                        
                }
            }
        }

        private void ClearControls()
        {
            txtGroupName.Text = string.Empty;
            lueAsstGroupServant.Text = string.Empty;
            lueAsstGroupServant.EditValue = null;
            lueGroupServant.Text = string.Empty;
            lueGroupServant.EditValue = null;
            txtGroupName.Focus();
        }

        private bool GroupInsert()
        {
            Utilities.SQLConnectionOpen();
            using (SqlCommand cmd = new SqlCommand("INSERT_GROUP", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Groupname", txtGroupName.Text);
                cmd.Parameters.AddWithValue("@Servant_Id", lueGroupServant.EditValue);
                cmd.Parameters.AddWithValue("@Asst_servant_Id", lueAsstGroupServant.EditValue);
                Int32 result = (Int32)cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }

        private bool GroupUpdate()
        {
            Utilities.SQLConnectionOpen();
            using (var cmd = new SqlCommand("UPDATE_GROUP", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GroupId", Utilities.ID);
                cmd.Parameters.AddWithValue("@Groupname", txtGroupName.Text);
                cmd.Parameters.AddWithValue("@Servant_Id", lueGroupServant.EditValue);
                cmd.Parameters.AddWithValue("@Asst_servant_Id", lueAsstGroupServant.EditValue);
                Int32 result = (Int32)cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }

        private void frmAddGroup_Load(object sender, System.EventArgs e)
        {
            Utilities.FillLookUpEdit(lueGroupServant, "GET_BRETHREN", "BrethrenName", "brethren_id");
            Utilities.FillLookUpEdit(lueAsstGroupServant, "GET_BRETHREN", "BrethrenName", "brethren_id");
            if (Utilities.FMode == "Add" || Utilities.SFMode == "Add")
            {
                ClearControls();
            }
            else if (Utilities.FMode == "Edit")
                SetDetails();
        }
    }
}
