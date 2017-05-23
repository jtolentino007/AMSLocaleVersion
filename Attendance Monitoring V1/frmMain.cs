using System;
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
        public static int userPrivilege = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Instances.login.ClearLogin();
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
            Instances.attendanceMontoring.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, peUserImage.Width - 3, peUserImage.Height - 3);
            //Region rg = new Region(gp);
            //peUserImage.Region = rg;

            if (!string.IsNullOrWhiteSpace(frmLogin.User_Image_Path))
            {   
                if (Directory.Exists(frmLogin.User_Image_Path)) { 
                    peUserImage.Image = Image.FromFile(frmLogin.User_Image_Path);
                }
            }
            else peUserImage.Image = null;
            
            lblWelcomeMessage.Text = "Hi!\n" + frmLogin.Username + "\n" + frmLogin.Locale;
            Privilege();
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
                ribbonRef.Visible = false;
                ribbonTransact.Visible = false;
                ribbonReport.Visible = false;
                ribbonSystemLogs.Caption = "Users Logs";
                ribbonAdmin.Visible = true;
            }
            else if (UserRight == 2)
            {
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
    }
}
