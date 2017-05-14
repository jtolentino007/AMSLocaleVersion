using System;
using System.Data;
using System.Windows.Forms;
using AMS.Classes;
using System.Data.SqlClient;

namespace AMS
{
    public partial class frmLocale : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtLocale;
        public frmLocale()
        {
            InitializeComponent();
        }

        public void GetLocale()
        {
            Utilities.SQLConnectionOpen();
            using (var adapt = new SqlDataAdapter("GET_LOCALE", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtLocale = new DataTable();
                dtLocale.Clear();
                adapt.Fill(dtLocale);
                gridLocale.DataSource = dtLocale;
            }
        }

        private void mnubtnAddLocale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.localeAddEdit.ShowDialog();
        }

        private void mnubtnEditLocale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            { 
                Utilities.FMode = "Edit";
                int selectedRowIndex = gridView1.FocusedRowHandle;
                string LocaleCode = gridView1.GetRowCellValue(selectedRowIndex, "locale_code").ToString();
                Instances.localeAddEdit.drLocale = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.localeAddEdit.ShowDialog();
            }
            else
            {
                Utilities.ErrorMessage("No Locale to Edit");
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void frmLocale_Load(object sender, EventArgs e)
        {
            GetLocale();
            if (gridView1.RowCount > 0)
                mnubtnAddLocale.Enabled = false;
        }

        private void mnubtnDeleteLocale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            { 
                if(MessageBox.Show("Are you sure you want to delete this Locale?", "AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    Utilities.SQLConnectionOpen();
                    Utilities.ID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"locale_id"));
                    using (var cmd = new SqlCommand("DELETE_LOCALE",Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LocaleID", Utilities.ID);
                        cmd.ExecuteNonQuery();
                        Instances.locale.GetLocale();
                        Utilities.SuccessMessage("Locale Successfully Deleted");
                    }
                }
            }
            else
            {
                Utilities.ErrorMessage("No Locale Delete");
            }
        }
    }
}
