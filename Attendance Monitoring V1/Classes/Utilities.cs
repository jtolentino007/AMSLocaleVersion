using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Text.RegularExpressions;
using System.IO;

namespace AMS.Classes
{
    class Utilities
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AMSConnection"].ConnectionString);
        public static string FMode;
        public static string SFMode;
        public static int ID;

        public static void GenerateSystemLog(string Activity, string Module, int Status)
        {
            Utilities.SQLConnectionOpen();
            using (var LogsCmd = new SqlCommand("INSERT_LOG", con))
            {
                LogsCmd.CommandType = CommandType.StoredProcedure;
                LogsCmd.Parameters.AddWithValue("@user_id", frmLogin.User_id);
                LogsCmd.Parameters.AddWithValue("@activity", Activity);
                LogsCmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                LogsCmd.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());
                LogsCmd.Parameters.AddWithValue("@module", Module);
                LogsCmd.Parameters.AddWithValue("@activity_status", Status);
                LogsCmd.ExecuteNonQuery();
            }
        }
        
        public static void FillCheckedComboBoxEdit(string query, CheckedComboBoxEdit checkedComboBoxEditControl, string displayMember, string valueMember, DataTable dataTableForCheckedCombo)
        {
            dataTableForCheckedCombo = new DataTable();
            
            using (var adaptChecked = new SqlDataAdapter(query, Utilities.con))
            {
                adaptChecked.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataTableForCheckedCombo.Clear();
                adaptChecked.Fill(dataTableForCheckedCombo);
                checkedComboBoxEditControl.Properties.DataSource = dataTableForCheckedCombo;
                checkedComboBoxEditControl.Properties.DisplayMember = displayMember;
                checkedComboBoxEditControl.Properties.ValueMember = valueMember;
            }
        }

        public static void ToggleDisableAllControls(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextEdit)
                {
                    if (((TextEdit)c).Enabled == true)
                        ((TextEdit)c).Enabled = false;
                    else
                        ((TextEdit)c).Enabled = true;
                }
            }
        }

        public static string SQLConnectionStatus()
        {
            if (con.State == ConnectionState.Open)
                return "Ready";
            else if (con.State == ConnectionState.Broken)
                return "Error on Database/Invalid Connection on Server";
            else if (con.State == ConnectionState.Closed)
                return "Error on Database/Invalid Connection on Server";
            else
                return "Application Connecting to Server";
        }

        public static bool IsImageExists(string ImagePath)
        {
            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        
        public enum FormMode
        {
            AddMode,
            EditMode
        }

        public static void SQLConnectionOpen()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static string SetHeaderMode(string FormName)
        {
            if (FMode == "Add" || FMode == "AddUtility")
                return "NEW " + FormName;
            else
                return "EDIT " + FormName;
        }

        public static string GetID(string Query, string columnName, string sCriteria)
        {
            using (var vsqlCommand = new SqlCommand(Query, con))
            {
                vsqlCommand.CommandType = CommandType.StoredProcedure;
                vsqlCommand.Parameters.AddWithValue("@Search", sCriteria);
                using (var dr = vsqlCommand.ExecuteReader())
                {
                    if (dr.Read())
                        return dr[columnName].ToString();
                    else
                        return null;
                }
            }
        }

        public static bool CheckBrethrenIfAttended(string GatheringID, string BrethrenID)
        {
            using (var AttendanceCommand = new SqlCommand("CHECK_BRETHREN_IF_ATTENDED", Utilities.con))
            {
                AttendanceCommand.CommandType = CommandType.StoredProcedure;
                AttendanceCommand.Parameters.AddWithValue("@GatheringID", GatheringID);
                AttendanceCommand.Parameters.AddWithValue("@temp_brethren_id", BrethrenID);
                Int32 BrethrenCount = (Int32)AttendanceCommand.ExecuteScalar();
                if (BrethrenCount > 0)
                    return true;
                else
                    return false;
            }
        }

        public static string GetLastAlphaNumericColumn(string ColumnName, string TableName)
        {
            using (var cmd = new SqlCommand("SELECT TOP 1 " + ColumnName + " FROM " + TableName + " ORDER BY CAST(SUBSTRING(" + ColumnName + " + '0', PATINDEX('%[0-9]%', "+ ColumnName +" + '0'), LEN("+ColumnName+" + '0')) AS INT) DESC", con))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        return dr[ColumnName].ToString();
                    else
                        return null;
                }
            }
        }

        public static void FillLookUpEdit(LookUpEdit LookUpEditControl, string AdapterCommand, string DisplayMember, string ValueMember)
        {
            SQLConnectionOpen();
            using (SqlDataAdapter adapt = new SqlDataAdapter(AdapterCommand, con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Clear();
                adapt.Fill(dt);
                LookUpEditControl.Properties.DataSource = dt;
                LookUpEditControl.Properties.DisplayMember = DisplayMember;
                LookUpEditControl.Properties.ValueMember = ValueMember;
            }
        }


        public static bool IsUserAuthenticated(string ChurchID, string Password)
        {
            using(SqlCommand cmd = new SqlCommand("AUTHENTICATE_USER",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChurchID", ChurchID);
                cmd.Parameters.AddWithValue("@Password", Password);
                Int32 UserCount = (Int32)cmd.ExecuteScalar();
                if (UserCount > 0)
                    return true;
                else
                    return false;
            }
        }

        public static bool CheckRecordIfExists(string Column, string Criteria, string Table)
        {
            SQLConnectionOpen();
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM " + Table + " WHERE "+Column+" LIKE '%"+ Criteria +"%'",con))
            {
                int RecordCount = (int)cmd.ExecuteScalar();
                if (RecordCount > 0)
                    return true;
                else
                    return false;
            }
        }

        public static string GetLastCodeFromTable(string ColumnName, string TableName)
        {
            SQLConnectionOpen();
            using (var cmd = new SqlCommand("SELECT TOP 1 " + ColumnName + " FROM " + TableName + " ORDER BY " + ColumnName + " DESC", con))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        return dr[ColumnName].ToString();
                    else
                        return null;
                }
            }
        }


        public static void Exit()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Attendance Monitoring System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        public static void Logout(Form Form)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Attendance Monitoring System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Instances.login.Show();
                Form.Hide();
            }
        }

        public static string GetUpperCase(string stringToFetch)
        {
            Regex rgx = new Regex("[^A-Z]");
            return rgx.Replace(stringToFetch, "");
        }

        public static bool QuestionMessage(string Message)
        {
            if (MessageBox.Show(Message, "Attendance Monitoring System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public static void ErrorMessage(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        public static void SuccessMessage(string Message)
        {
            MessageBox.Show(Message, "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
