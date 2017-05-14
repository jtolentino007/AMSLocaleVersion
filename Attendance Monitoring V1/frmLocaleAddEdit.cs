using System;
using System.Data;
using AMS.Classes;
using System.Data.SqlClient;

namespace AMS
{
    public partial class frmLocaleAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dtLocale { get; set; }
        public DataRow drLocale { get; set; }
        public frmLocaleAddEdit()
        {
            InitializeComponent();
        }

        private void GetLocale()
        {
            using (var adapt = new SqlDataAdapter("GET_LOCALE", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtLocale = new DataTable();
                dtLocale.Clear();
                adapt.Fill(dtLocale);
            }
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void SetDetails()   
        {
            txtLocaleCode.Text = dtLocale.Rows[0]["locale_code"].ToString();
            txtLocale.Text = dtLocale.Rows[0]["locale"].ToString();
            txtDistrict.Text = dtLocale.Rows[0]["dist"].ToString();
            txtDivision.Text = dtLocale.Rows[0]["div"].ToString();
            txtLocaleAddress.Text = dtLocale.Rows[0]["address"].ToString();
        }

        private void GenerateLocaleCode()
        {
            string CategoryCode = Utilities.GetLastCodeFromTable("locale_code", "Locale");
            if (CategoryCode == null)
                txtLocaleCode.Text = "LOCALE-1000";
            else
                txtLocaleCode.Text = "LOCALE-" + (Convert.ToInt16(CategoryCode.Replace("LOCALE-", "")) + 1);
        }

        private bool LocaleUpdate()
        {
            Utilities.SQLConnectionOpen();
            using (var cmd = new SqlCommand("UPDATE_LOCALE", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LocalCode", txtLocaleCode.Text);
                cmd.Parameters.AddWithValue("@Locale", txtLocale.Text);
                cmd.Parameters.AddWithValue("@District", txtDistrict.Text);
                cmd.Parameters.AddWithValue("@Division", txtDivision.Text);
                cmd.Parameters.AddWithValue("@Address", txtLocaleAddress.Text);
                Int32 result = (Int32)cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }

        private bool LocaleInsert()
        {
            Utilities.SQLConnectionOpen();
            using (var cmd = new SqlCommand("INSERT_LOCALE", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LocalCode", txtLocaleCode.Text);
                cmd.Parameters.AddWithValue("@Locale", txtLocale.Text);
                cmd.Parameters.AddWithValue("@District", txtDistrict.Text);
                cmd.Parameters.AddWithValue("@Division", txtDivision.Text);
                cmd.Parameters.AddWithValue("@Address", txtLocaleAddress.Text);
                Int32 result = (Int32)cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }

        private void ClearControls()
        {
            txtLocale.Text = string.Empty;
            txtLocaleAddress.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtDivision.Text = string.Empty;
            txtLocaleCode.Text = string.Empty;
            txtLocale.Focus();
        }

        private void mnuBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsValid())
            {
                if (LocaleUpdate())
                {
                    Utilities.SuccessMessage("Locale Information Successfully Updated");
                    Utilities.GenerateSystemLog("Edited Locale, " + txtLocale.Text, "Locale Management", 1);
                    this.Hide();
                    Instances.locale.GetLocale();
                }
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtLocale.Text))
            {
                txtLocale.Focus();
                Utilities.ErrorMessage("Locale is Required");
                return false;
            }

            return true;
        }

        private void frmLocaleAddEdit_Load(object sender, EventArgs e)
        {
            //if (Utilities.FMode == "Add")
            //{
            //    ClearControls();
            //    //GenerateLocaleCode();
            //}   
            GetLocale();
            SetDetails();
        }
    }
}
