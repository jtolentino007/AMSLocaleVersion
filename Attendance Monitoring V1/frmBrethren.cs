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
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraReports.UI;

namespace AMS
{
    public partial class frmBrethren : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtBrethren = new DataTable();
        XtraReportBrethren reportBrethren = new XtraReportBrethren();

        public frmBrethren()
        {
            InitializeComponent();
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void FillBrethren()
        {
            using (var brethrenAdapter = new SqlDataAdapter("GET_BRETHREN", Utilities.con))
            {
                dtBrethren.Clear();
                brethrenAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                brethrenAdapter.Fill(dtBrethren);
                gridBrethren.DataSource = dtBrethren;
            }
        }

        private void mBtnAddBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.brethrenAddEdit.dtBrethren = dtBrethren;
            Instances.brethrenAddEdit.ShowDialog();
        }

        private void mnuBtnEditBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Selected Brethren");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Brethren Found");
            else if (gridView1.SelectedRowsCount > 1)
                Utilities.ErrorMessage("Please Select only 1 Brethren");
            else
            {
                Utilities.FMode = "Edit";
                Instances.brethrenAddEdit.drBrethren = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Instances.brethrenAddEdit.ShowDialog();
            }
        }

        private void frmBrethren_Load(object sender, EventArgs e)
        {
            FillBrethren();
        }

        private void mnuBtnRemoveBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                Utilities.ErrorMessage("No Brethren(s) Selected");
            else if (gridView1.RowCount == 0)
                Utilities.ErrorMessage("No Record(s) Found");
            else
            {
                if (Utilities.QuestionMessage("Are you sure you want to Remove Brethren(s)?"))
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        using (var cmd = new SqlCommand("DELETE_BRETHREN", Utilities.con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BrethrenID", gridView1.GetRowCellValue(row, "brethren_id").ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Utilities.SuccessMessage("Brethren(s) successfully removed");
                    FillBrethren();
                }
            }

        }

        private void mnuBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }

        public void ToggleDetailsView()
        {
            if (Utilities.FMode == "Add" || Utilities.FMode == "Edit")
            {
                Instances.brethrenAddEdit.mnuBtnSave.Visibility = BarItemVisibility.Always;
                Instances.brethrenAddEdit.mnuBtnPrintPreview.Visibility = BarItemVisibility.Never;
                Utilities.ToggleDisableAllControls(Instances.brethrenAddEdit);
               
            }
            else
            {
                Instances.brethrenAddEdit.mnuBtnSave.Visibility = BarItemVisibility.Never;
                Instances.brethrenAddEdit.mnuBtnPrintPreview.Visibility = BarItemVisibility.Always;
                Utilities.ToggleDisableAllControls(Instances.brethrenAddEdit);
                foreach (var ctrl in Instances.brethrenAddEdit.Controls)
                {
                    if (ctrl is SimpleButton)
                    {
                        ((SimpleButton)ctrl).Hide();
                    }
                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "btnView")
            {
                string brethren_id = gridView1.GetFocusedRowCellValue("brethren_id").ToString();

                using (var cmd = new SqlCommand("GET_BRETHREN_BY_ID",Utilities.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brethren_id", brethren_id);
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        if (Utilities.IsImageExists(rd["Image_Path"].ToString()))
                            reportBrethren.xrPictureBoxBrethren.Image = Image.FromFile(rd["Image_Path"].ToString());
                        else
                            reportBrethren.xrPictureBoxBrethren.Image = Properties.Resources.default_user_image;

                        if (Utilities.IsImageExists(rd["Sketch_Path"].ToString()))
                            reportBrethren.xrPictureBoxSketch.Image = Image.FromFile(rd["Sketch_Path"].ToString());
                        else
                            reportBrethren.xrPictureBoxSketch.Image = Properties.Resources.default_sketch;

                        switch (rd["Status"].ToString())
                        {
                            case "Active":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#56b65a");
                                break;
                            case "Inactive":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#9e9e9e");
                                break;
                            case "Suspended Active":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#ffc107");
                                break;
                            case "Suspended Inactive ":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#2196f3");
                                break;
                            case "Abroad ":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#8bc34a");
                                break;
                            case "RFA":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#ff5722");
                                break;
                            case "Cannot be Located":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#e5ce00");
                                break;
                            case "Archive":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#673ab7");
                                break;
                            case "Deceased ":
                                reportBrethren.xrLabelStatus.BackColor = ColorTranslator.FromHtml("#1f1f1f");
                                break;
                        }


                        reportBrethren.xrLabelFullname.Text = rd["BrethrenName"].ToString().ToUpper();
                        reportBrethren.xrLabelStatus.Text = rd["Status"].ToString().ToUpper();
                        reportBrethren.xrLabelChurchID.Text = rd["Church_Id"].ToString().ToUpper();
                        reportBrethren.xrLabelCommittees.Text = rd["Committee_Names"].ToString().ToUpper();
                        reportBrethren.xrLabelCivilStatus.Text = rd["Civil_Status"].ToString().ToUpper();
                        reportBrethren.xrLabelAddress.Text = rd["Address"].ToString().ToUpper();
                        reportBrethren.xrLabelContactNo.Text = rd["Phone_no"].ToString().ToUpper();
                        reportBrethren.xrLabelContactNo2.Text = rd["Contact_Person_no"].ToString().ToUpper();
                        reportBrethren.xrLabelContactPerson.Text = rd["Contact_Person"].ToString().ToUpper();
                        reportBrethren.xrLabelDateOfBaptism.Text = rd["Date_Baptism"].ToString().ToUpper();
                        reportBrethren.xrLabelDateOfBirth.Text = rd["Date_Birth"].ToString().ToUpper();
                        reportBrethren.xrLabelGender.Text = rd["Gender"].ToString().ToUpper();
                        reportBrethren.xrLabelGroup.Text = rd["Group_name"].ToString().ToUpper();
                        reportBrethren.xrLabelLocale.Text = rd["locale"].ToString().ToUpper();
                        reportBrethren.xrLabelEmployment.Text = rd["Employment"].ToString().ToUpper();
                    }

                    reportBrethren.CreateDocument();

                    ReportPrintTool printTool = new ReportPrintTool(reportBrethren);
                    printTool.ShowPreview();
                    this.Close();
                }
            }
        }
    }
}
