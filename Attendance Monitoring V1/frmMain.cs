﻿using System;
using AMS.Classes;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using AMS.Properties;
using System.IO;
using DevExpress.XtraReports.UI;

namespace AMS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtStatusCount = new DataTable();
        DataTable dtTempAttendance = new DataTable();
        public static int userPrivilege = 0;
        public static int flag = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.login.ClearLogin();
            Instances.login.InitializeLogin();
            Utilities.Logout(this);
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.Exit();
        }

        private void mnuBtnBrethren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.brethren.ShowDialog();
        }

        private void mnuBtnLocale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Instances.locale.ShowDialog();
            Instances.localeAddEdit.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.committee.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.group.ShowDialog();
        }

        private void mnuBtnAttendance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = 1;
            using (SqlDataAdapter adapter = new SqlDataAdapter("GET_TEMP_ATTENDANCE", Utilities.con))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(frmAttendanceForm.dtAttendance);
                frmAttendanceForm.GatheringID = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["tempGathering_ID"].ToString() : "" );
                Instances.assignees.txtAddpro.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["addpro"].ToString() : "" );
                Instances.assignees.txtOfficers.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["officers"].ToString() : "");
                Instances.assignees.txtWorker.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["workers"].ToString() : "");
                Instances.assignees.txtRemarks.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["remarks"].ToString() : "");
                Instances.attendanceForm.lblGatheringBatch.Caption = "BATCH : " + (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? Convert.ToDateTime(frmAttendanceForm.dtAttendance.Rows[0]["Batch_Time"].ToString()).ToShortTimeString() : "");
                Instances.attendanceForm.lblGatheringDate.Caption = "DATE OF GATHERING : " + (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["DateOfGathering"].ToString() : "");
                Instances.attendanceForm.lblGathering.Text = (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["gathering"].ToString() : "");
                Instances.attendanceForm.GetAttendedBrethrenList(Convert.ToDateTime( (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["DateOfGathering"].ToString() : "")), (frmAttendanceForm.dtAttendance.Rows.Count > 0 ? frmAttendanceForm.dtAttendance.Rows[0]["gathering_code"].ToString() : ""));
                Instances.attendanceForm.Show();
                this.Hide();
            }
        }

        public void AttendanceButtons()
        {
            using (SqlDataAdapter adapt = new SqlDataAdapter("GET_TEMP_ATTENDANCE", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtTempAttendance);
            }

            if (dtTempAttendance.Rows.Count > 0)
            {
                mnuBtnAttendance.Visibility = BarItemVisibility.Always;
                barButtonItem5.Visibility = BarItemVisibility.Never;
                barButtonItem6.Visibility = BarItemVisibility.Never;
            }
            else
            {
                mnuBtnAttendance.Visibility = BarItemVisibility.Never;
                barButtonItem5.Visibility = BarItemVisibility.Always;
                barButtonItem6.Visibility = BarItemVisibility.Always;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, peUserImage.Width - 3, peUserImage.Height - 3);
            //Region rg = new Region(gp);
            //peUserImage.Region = rg;
            Privilege();
            AttendanceButtons();

            if (!string.IsNullOrEmpty(frmLogin.User_Image_Path))
            {
                if (File.Exists(frmLogin.User_Image_Path))
                    peUserImage.Image = Image.FromFile(frmLogin.User_Image_Path);
                else
                    peUserImage.Image = Properties.Resources.default_user_image;
            }
            else
            {
                peUserImage.Image = Properties.Resources.default_user_image;
            }

            lblWelcomeMessage.Text = "Hello! " + frmLogin.Username + "\nLocale of " + frmLogin.Locale;
        }

        private void barBtnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.users.ShowDialog();
        }

        public void Privilege()
        {
            int UserRight = userPrivilege;
            if (UserRight == 1)
            {
                mnuBtnAttendance.Visibility = BarItemVisibility.Always;
                mnuBtnBrethren.Visibility = BarItemVisibility.Always;
                mnuBtnCommittees.Visibility = BarItemVisibility.Always;
                mnuBtnLocale.Visibility = BarItemVisibility.Always;
                barBtnGatheringTypes.Visibility = BarItemVisibility.Always;
                ribbonRef.Visible = true;
                ribbonTransact.Visible = true;
                ribbonReport.Visible = true;
                ribbonAdmin.Visible = true;
                ribbonSystemLogs.Caption = "Users Logs";
            }
            else if (UserRight == 2)
            {
                mnuBtnBrethren.Visibility = BarItemVisibility.Always;
                mnuBtnAttendance.Visibility = BarItemVisibility.Always;
                mnuBtnCommittees.Visibility = BarItemVisibility.Never;
                mnuBtnLocale.Visibility = BarItemVisibility.Never;
                barBtnGatheringTypes.Visibility = BarItemVisibility.Never;
                ribbonRef.Visible = true;
                ribbonTransact.Visible = true;
                ribbonReport.Visible = true;
                ribbonSystemLogs.Caption = "My Logs";
                ribbonAdmin.Visible = false;
            }
        }
        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            if (Instances.main.Visible == true)
                Privilege();
        }

        private void barBtnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.FMode = "Edit";
            Instances.userRegistration.ShowDialog();
        }

        private void barBtnLocale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.locale.ShowDialog();
        }

        private void barBtnBatches_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.Batches.ShowDialog();
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barBtnDashboardSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDashboardDesign dashboard = new frmDashboardDesign();
            dashboard.ShowDialog();
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Instances.SystemLogs.GetSystemLogsByUser();
            Instances.SystemLogs.ShowDialog();
        }

        private void mnuBtnAttendanceReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.attendanceReport.ShowDialog();
        }

        private void barButtonSaveTheme_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            //Settings.Default.Save();
        }

        private void skinRibbonGalleryBarItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnODTReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmODTReport odt = new frmODTReport();
            odt.ShowDialog();
        }

        private void barBtnGatheringTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGatheringTypes gatheringTypes = new frmGatheringTypes();
            gatheringTypes.ShowDialog();
        }

        private void barButtonInterlocaleReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInterlocaleReport interlocaleReport = new frmInterlocaleReport();
            interlocaleReport.ShowDialog();
        }

        private void barButtonCommitteeReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCommitteeReport committeeReport = new frmCommitteeReport();
            committeeReport.ShowDialog();
        }

        private void barButtonGroupingsReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGroupingsReport groupingsReport = new frmGroupingsReport();
            groupingsReport.ShowDialog();
        }

        private void barButtonNewlyBaptizedReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataTable dtNewlyBaptized = new DataTable();
            XtraReportNewlyBaptized newlyBaptizedReport = new XtraReportNewlyBaptized();

            using (var adapt = new SqlDataAdapter("GET_NEWLY_BAPTIZED", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtNewlyBaptized);
                newlyBaptizedReport.DataSource = dtNewlyBaptized;
            }

            if (dtNewlyBaptized.Rows.Count == 0)
                MessageBox.Show("No Newly Baptized Found");
            else
            {
                newlyBaptizedReport.xrLabelAsOfDate.Text = "As of " + DateTime.Now.ToString("MMMM dd, yyyy");
                newlyBaptizedReport.xrLabelUser.Text = "Generated by: " + frmLogin.Username;

                newlyBaptizedReport.xrTableCellChurchID.DataBindings.Add("Text", dtNewlyBaptized, dtNewlyBaptized.Columns["Church_Id"].ToString());
                newlyBaptizedReport.xrTableCellName.DataBindings.Add("Text", dtNewlyBaptized, dtNewlyBaptized.Columns["BrethrenName"].ToString());
                newlyBaptizedReport.xrTableCellBaptismDate.DataBindings.Add("Text", dtNewlyBaptized, dtNewlyBaptized.Columns["Date_Baptism"].ToString());
                newlyBaptizedReport.xrTableCellStatus.DataBindings.Add("Text", dtNewlyBaptized, dtNewlyBaptized.Columns["Status"].ToString());
                newlyBaptizedReport.CreateDocument();

                ReportPrintTool printTool = new ReportPrintTool(newlyBaptizedReport);
                printTool.ShowPreview();
            }
        }

        private void barButtonCelebrantReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataTable dtCelebrants = new DataTable();
            XtraReportCelebrants celebrantsReport = new XtraReportCelebrants();

            using (var adapt = new SqlDataAdapter("GET_CELEBRANTS",Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtCelebrants);
                celebrantsReport.DataSource = dtCelebrants;
            }

            if (dtCelebrants.Rows.Count == 0)
                MessageBox.Show("No celebrants found");
            else
            {
                celebrantsReport.xrLabelMonth.Text = DateTime.Now.ToString("MMMM").ToUpper() + " CELEBRANTS";
                celebrantsReport.xrLabelUser.Text = "Generated by: " + frmLogin.Username;

                celebrantsReport.xrTableCellChurchID.DataBindings.Add("Text", dtCelebrants, dtCelebrants.Columns["Church_Id"].ToString());
                celebrantsReport.xrTableCellName.DataBindings.Add("Text", dtCelebrants, dtCelebrants.Columns["BrethrenName"].ToString());
                celebrantsReport.xrTableCellDateBaptism.DataBindings.Add("Text", dtCelebrants, dtCelebrants.Columns["Date_Baptism"].ToString());
                celebrantsReport.xrTableCellAge.DataBindings.Add("Text", dtCelebrants, dtCelebrants.Columns["Age_Church"].ToString());
                celebrantsReport.xrTableCellStatus.DataBindings.Add("Text", dtCelebrants, dtCelebrants.Columns["Status"].ToString());
                celebrantsReport.CreateDocument();

                ReportPrintTool printTool = new ReportPrintTool(celebrantsReport);
                printTool.ShowPreview();
            }
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Instances.setupGathering.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.viewGatherings.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItemLocaleStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataTable dtLocaleReport = new DataTable();
            XtraReportLocaleStatus localeStatusReport = new XtraReportLocaleStatus();

            using (var adapt = new SqlDataAdapter("GET_LOCALE_REPORT", Utilities.con))
            {
                adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapt.Fill(dtLocaleReport);
                localeStatusReport.DataSource = dtLocaleReport;
            }

            if (dtLocaleReport.Rows.Count == 0)
                MessageBox.Show("No Status found");
            else
            {
                GroupField gfFlag = new GroupField(dtLocaleReport.Columns["flag"].ToString());

                localeStatusReport.GroupHeader.GroupFields.Add(gfFlag);

                localeStatusReport.xrLabelGroup.DataBindings.Add("Text", dtLocaleReport, dtLocaleReport.Columns["flag"].ToString());
                localeStatusReport.xrLabelMonth.Text = "As of " + DateTime.Now.ToString("MMMM").ToUpper();
                localeStatusReport.xrLabelUser.Text = "Generated by: " + frmLogin.Username;

                localeStatusReport.xrTableCellStatus.DataBindings.Add("Text", dtLocaleReport, dtLocaleReport.Columns["Status"].ToString());
                localeStatusReport.xrTableCellTotal.DataBindings.Add("Text", dtLocaleReport, dtLocaleReport.Columns["Total"].ToString());
                localeStatusReport.CreateDocument();

                ReportPrintTool printTool = new ReportPrintTool(localeStatusReport);
                printTool.ShowPreview();
            }
        }

        private void barButtonItemLocales_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.locale.ShowDialog();
        }

        private void barButtonItemPrivileges_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.privileges.ShowDialog();
        }

        private void barButtonItemModule_ItemClick(object sender, ItemClickEventArgs e)
        {
            Instances.modules.ShowDialog();
        }
    }
}
