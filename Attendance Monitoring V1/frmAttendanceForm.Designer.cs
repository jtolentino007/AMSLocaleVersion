namespace AMS
{
    partial class frmAttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendanceForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemTimeIn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLateStatus = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemViewAttendees = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEndAttendance = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewInterlocale = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewMember = new DevExpress.XtraBars.BarButtonItem();
            this.lblGatheringBatch = new DevExpress.XtraBars.BarStaticItem();
            this.lblGatheringDate = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tlp_Row2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Col2 = new System.Windows.Forms.TableLayoutPanel();
            this.tpl_SearchGrid = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.gridBrethren = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpl_IDContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tpl_ImageDetails = new System.Windows.Forms.TableLayoutPanel();
            this.tpl_ImageContainer = new System.Windows.Forms.TableLayoutPanel();
            this.peMember = new DevExpress.XtraEditors.PictureEdit();
            this.tpl_MemberDetails = new System.Windows.Forms.TableLayoutPanel();
            this.Label2 = new DevExpress.XtraEditors.LabelControl();
            this.lblChurchID = new DevExpress.XtraEditors.LabelControl();
            this.Label1 = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblLocale = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblGathering = new DevExpress.XtraEditors.LabelControl();
            this.barButtonTest = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.tlp_Row2.SuspendLayout();
            this.tlp_Col2.SuspendLayout();
            this.tpl_SearchGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrethren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tpl_IDContainer.SuspendLayout();
            this.tpl_ImageDetails.SuspendLayout();
            this.tpl_ImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peMember.Properties)).BeginInit();
            this.tpl_MemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemTimeIn,
            this.barButtonItemLateStatus,
            this.barButtonItemViewAttendees,
            this.barButtonItemEndAttendance,
            this.barButtonItemNewInterlocale,
            this.barButtonItemNewMember,
            this.lblGatheringBatch,
            this.lblGatheringDate,
            this.barButtonTest});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1242, 187);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItemTimeIn
            // 
            this.barButtonItemTimeIn.Caption = "TIME IN";
            this.barButtonItemTimeIn.Id = 1;
            this.barButtonItemTimeIn.LargeGlyph = global::AMS.Properties.Resources.Time_Card_Filled_50;
            this.barButtonItemTimeIn.Name = "barButtonItemTimeIn";
            this.barButtonItemTimeIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTimeIn_ItemClick);
            // 
            // barButtonItemLateStatus
            // 
            this.barButtonItemLateStatus.Caption = "ACTIVATE LATE STATUS";
            this.barButtonItemLateStatus.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemLateStatus.Glyph")));
            this.barButtonItemLateStatus.Id = 2;
            this.barButtonItemLateStatus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemLateStatus.LargeGlyph")));
            this.barButtonItemLateStatus.Name = "barButtonItemLateStatus";
            this.barButtonItemLateStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLateStatus_ItemClick);
            // 
            // barButtonItemViewAttendees
            // 
            this.barButtonItemViewAttendees.Caption = "VIEW\r\nATTENDEES";
            this.barButtonItemViewAttendees.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemViewAttendees.Glyph")));
            this.barButtonItemViewAttendees.Id = 3;
            this.barButtonItemViewAttendees.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemViewAttendees.LargeGlyph")));
            this.barButtonItemViewAttendees.Name = "barButtonItemViewAttendees";
            this.barButtonItemViewAttendees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemViewAttendees_ItemClick);
            // 
            // barButtonItemEndAttendance
            // 
            this.barButtonItemEndAttendance.Caption = "END\r\nATTENDANCE";
            this.barButtonItemEndAttendance.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemEndAttendance.Glyph")));
            this.barButtonItemEndAttendance.Id = 4;
            this.barButtonItemEndAttendance.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemEndAttendance.LargeGlyph")));
            this.barButtonItemEndAttendance.Name = "barButtonItemEndAttendance";
            this.barButtonItemEndAttendance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEndAttendance_ItemClick);
            // 
            // barButtonItemNewInterlocale
            // 
            this.barButtonItemNewInterlocale.Caption = "NEW\r\nINTERLOCALE";
            this.barButtonItemNewInterlocale.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewInterlocale.Glyph")));
            this.barButtonItemNewInterlocale.Id = 5;
            this.barButtonItemNewInterlocale.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewInterlocale.LargeGlyph")));
            this.barButtonItemNewInterlocale.Name = "barButtonItemNewInterlocale";
            this.barButtonItemNewInterlocale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewInterlocale_ItemClick);
            // 
            // barButtonItemNewMember
            // 
            this.barButtonItemNewMember.Caption = "NEW\r\nMEMBER";
            this.barButtonItemNewMember.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewMember.Glyph")));
            this.barButtonItemNewMember.Id = 6;
            this.barButtonItemNewMember.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewMember.LargeGlyph")));
            this.barButtonItemNewMember.Name = "barButtonItemNewMember";
            this.barButtonItemNewMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewMember_ItemClick);
            // 
            // lblGatheringBatch
            // 
            this.lblGatheringBatch.Caption = "BATCH : 4:30 PM";
            this.lblGatheringBatch.Id = 7;
            this.lblGatheringBatch.Name = "lblGatheringBatch";
            this.lblGatheringBatch.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblGatheringDate
            // 
            this.lblGatheringDate.Caption = "DATE OF GATHERING : 08/21/2017";
            this.lblGatheringDate.Id = 8;
            this.lblGatheringDate.Name = "lblGatheringDate";
            this.lblGatheringDate.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TASKS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemTimeIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemLateStatus);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemViewAttendees);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEndAttendance);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemNewInterlocale);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemNewMember);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonTest);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblGatheringBatch);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblGatheringDate);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 769);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1242, 29);
            // 
            // tlp_Row2
            // 
            this.tlp_Row2.ColumnCount = 1;
            this.tlp_Row2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Row2.Controls.Add(this.tlp_Col2, 0, 1);
            this.tlp_Row2.Controls.Add(this.lblGathering, 0, 0);
            this.tlp_Row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Row2.Location = new System.Drawing.Point(0, 187);
            this.tlp_Row2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Row2.Name = "tlp_Row2";
            this.tlp_Row2.RowCount = 2;
            this.tlp_Row2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp_Row2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tlp_Row2.Size = new System.Drawing.Size(1242, 582);
            this.tlp_Row2.TabIndex = 2;
            // 
            // tlp_Col2
            // 
            this.tlp_Col2.ColumnCount = 2;
            this.tlp_Col2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Col2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Col2.Controls.Add(this.tpl_SearchGrid, 0, 0);
            this.tlp_Col2.Controls.Add(this.tpl_IDContainer, 1, 0);
            this.tlp_Col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Col2.Location = new System.Drawing.Point(0, 40);
            this.tlp_Col2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Col2.Name = "tlp_Col2";
            this.tlp_Col2.RowCount = 1;
            this.tlp_Col2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Col2.Size = new System.Drawing.Size(1242, 542);
            this.tlp_Col2.TabIndex = 0;
            // 
            // tpl_SearchGrid
            // 
            this.tpl_SearchGrid.ColumnCount = 1;
            this.tpl_SearchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_SearchGrid.Controls.Add(this.txtSearch, 0, 0);
            this.tpl_SearchGrid.Controls.Add(this.gridBrethren, 0, 1);
            this.tpl_SearchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_SearchGrid.Location = new System.Drawing.Point(0, 0);
            this.tpl_SearchGrid.Margin = new System.Windows.Forms.Padding(0);
            this.tpl_SearchGrid.Name = "tpl_SearchGrid";
            this.tpl_SearchGrid.RowCount = 2;
            this.tpl_SearchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpl_SearchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tpl_SearchGrid.Size = new System.Drawing.Size(621, 542);
            this.tpl_SearchGrid.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(3, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.txtSearch.MenuManager = this.ribbonControl1;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSearch.Properties.NullValuePrompt = "ENTER CHURCH ID OR NAME";
            this.txtSearch.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearch.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtSearch.Size = new System.Drawing.Size(615, 50);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // gridBrethren
            // 
            this.gridBrethren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBrethren.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridBrethren.Location = new System.Drawing.Point(3, 58);
            this.gridBrethren.MainView = this.gridView1;
            this.gridBrethren.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridBrethren.MenuManager = this.ribbonControl1;
            this.gridBrethren.Name = "gridBrethren";
            this.gridBrethren.Size = new System.Drawing.Size(615, 480);
            this.gridBrethren.TabIndex = 1;
            this.gridBrethren.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridBrethren.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridBrethren_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridBrethren;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Brethren ID";
            this.gridColumn1.FieldName = "brethren_id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Church ID";
            this.gridColumn2.FieldName = "Church_Id";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "BrethrenName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Locale";
            this.gridColumn4.FieldName = "locale";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Image Path";
            this.gridColumn5.FieldName = "Image_Path";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Interlocale";
            this.gridColumn6.FieldName = "is_interlocale";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // tpl_IDContainer
            // 
            this.tpl_IDContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpl_IDContainer.ColumnCount = 3;
            this.tpl_IDContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpl_IDContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tpl_IDContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpl_IDContainer.Controls.Add(this.tpl_ImageDetails, 1, 1);
            this.tpl_IDContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_IDContainer.Location = new System.Drawing.Point(621, 0);
            this.tpl_IDContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tpl_IDContainer.Name = "tpl_IDContainer";
            this.tpl_IDContainer.RowCount = 3;
            this.tpl_IDContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tpl_IDContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tpl_IDContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tpl_IDContainer.Size = new System.Drawing.Size(621, 542);
            this.tpl_IDContainer.TabIndex = 1;
            // 
            // tpl_ImageDetails
            // 
            this.tpl_ImageDetails.ColumnCount = 1;
            this.tpl_ImageDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_ImageDetails.Controls.Add(this.tpl_ImageContainer, 0, 0);
            this.tpl_ImageDetails.Controls.Add(this.tpl_MemberDetails, 0, 1);
            this.tpl_ImageDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_ImageDetails.Location = new System.Drawing.Point(124, 27);
            this.tpl_ImageDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tpl_ImageDetails.Name = "tpl_ImageDetails";
            this.tpl_ImageDetails.RowCount = 2;
            this.tpl_ImageDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpl_ImageDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tpl_ImageDetails.Size = new System.Drawing.Size(372, 487);
            this.tpl_ImageDetails.TabIndex = 0;
            // 
            // tpl_ImageContainer
            // 
            this.tpl_ImageContainer.BackColor = System.Drawing.Color.White;
            this.tpl_ImageContainer.ColumnCount = 3;
            this.tpl_ImageContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpl_ImageContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl_ImageContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpl_ImageContainer.Controls.Add(this.peMember, 1, 0);
            this.tpl_ImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_ImageContainer.Location = new System.Drawing.Point(0, 0);
            this.tpl_ImageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tpl_ImageContainer.Name = "tpl_ImageContainer";
            this.tpl_ImageContainer.RowCount = 1;
            this.tpl_ImageContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_ImageContainer.Size = new System.Drawing.Size(372, 194);
            this.tpl_ImageContainer.TabIndex = 0;
            // 
            // peMember
            // 
            this.peMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peMember.EditValue = global::AMS.Properties.Resources.default_user_image;
            this.peMember.Location = new System.Drawing.Point(110, 18);
            this.peMember.Margin = new System.Windows.Forms.Padding(17, 18, 17, 18);
            this.peMember.MenuManager = this.ribbonControl1;
            this.peMember.Name = "peMember";
            this.peMember.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.peMember.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peMember.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peMember.Size = new System.Drawing.Size(152, 158);
            this.peMember.TabIndex = 0;
            // 
            // tpl_MemberDetails
            // 
            this.tpl_MemberDetails.BackColor = System.Drawing.Color.MidnightBlue;
            this.tpl_MemberDetails.ColumnCount = 1;
            this.tpl_MemberDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_MemberDetails.Controls.Add(this.Label2, 0, 3);
            this.tpl_MemberDetails.Controls.Add(this.lblChurchID, 0, 2);
            this.tpl_MemberDetails.Controls.Add(this.Label1, 0, 1);
            this.tpl_MemberDetails.Controls.Add(this.lblName, 0, 0);
            this.tpl_MemberDetails.Controls.Add(this.lblLocale, 0, 4);
            this.tpl_MemberDetails.Controls.Add(this.labelControl2, 0, 5);
            this.tpl_MemberDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_MemberDetails.Location = new System.Drawing.Point(0, 194);
            this.tpl_MemberDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tpl_MemberDetails.Name = "tpl_MemberDetails";
            this.tpl_MemberDetails.RowCount = 7;
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpl_MemberDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpl_MemberDetails.Size = new System.Drawing.Size(372, 293);
            this.tpl_MemberDetails.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Label2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Location = new System.Drawing.Point(3, 119);
            this.Label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(366, 21);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "CHURCH ID";
            // 
            // lblChurchID
            // 
            this.lblChurchID.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChurchID.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblChurchID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblChurchID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblChurchID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblChurchID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChurchID.Location = new System.Drawing.Point(3, 76);
            this.lblChurchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblChurchID.Name = "lblChurchID";
            this.lblChurchID.Size = new System.Drawing.Size(366, 35);
            this.lblChurchID.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Label1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Location = new System.Drawing.Point(3, 47);
            this.Label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(366, 21);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "NAME";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(366, 35);
            this.lblName.TabIndex = 0;
            // 
            // lblLocale
            // 
            this.lblLocale.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocale.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblLocale.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLocale.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblLocale.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLocale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocale.Location = new System.Drawing.Point(3, 148);
            this.lblLocale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLocale.Name = "lblLocale";
            this.lblLocale.Size = new System.Drawing.Size(366, 35);
            this.lblLocale.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 191);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(366, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "LOCALE";
            // 
            // lblGathering
            // 
            this.lblGathering.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblGathering.Appearance.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGathering.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblGathering.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblGathering.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGathering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGathering.Location = new System.Drawing.Point(0, 0);
            this.lblGathering.Margin = new System.Windows.Forms.Padding(0);
            this.lblGathering.Name = "lblGathering";
            this.lblGathering.Size = new System.Drawing.Size(1242, 40);
            this.lblGathering.TabIndex = 1;
            this.lblGathering.Text = "SPECIAL PRAYER MEETING";
            // 
            // barButtonTest
            // 
            this.barButtonTest.Caption = "Test";
            this.barButtonTest.Id = 9;
            this.barButtonTest.Name = "barButtonTest";
            this.barButtonTest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTest_ItemClick);
            // 
            // frmAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 798);
            this.Controls.Add(this.tlp_Row2);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAttendanceForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ATTENDANCE FORM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAttendanceForm_FormClosing);
            this.Load += new System.EventHandler(this.frmAttendanceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAttendanceForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.tlp_Row2.ResumeLayout(false);
            this.tlp_Col2.ResumeLayout(false);
            this.tpl_SearchGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrethren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tpl_IDContainer.ResumeLayout(false);
            this.tpl_ImageDetails.ResumeLayout(false);
            this.tpl_ImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peMember.Properties)).EndInit();
            this.tpl_MemberDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.TableLayoutPanel tlp_Row2;
        private System.Windows.Forms.TableLayoutPanel tlp_Col2;
        private System.Windows.Forms.TableLayoutPanel tpl_SearchGrid;
        private System.Windows.Forms.TableLayoutPanel tpl_IDContainer;
        private System.Windows.Forms.TableLayoutPanel tpl_ImageDetails;
        private System.Windows.Forms.TableLayoutPanel tpl_ImageContainer;
        private System.Windows.Forms.TableLayoutPanel tpl_MemberDetails;
        private DevExpress.XtraEditors.PictureEdit peMember;
        private DevExpress.XtraEditors.LabelControl Label2;
        private DevExpress.XtraEditors.LabelControl Label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraGrid.GridControl gridBrethren;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        public DevExpress.XtraBars.BarButtonItem barButtonItemTimeIn;
        public DevExpress.XtraBars.BarButtonItem barButtonItemLateStatus;
        public DevExpress.XtraBars.BarButtonItem barButtonItemViewAttendees;
        public DevExpress.XtraBars.BarButtonItem barButtonItemEndAttendance;
        public DevExpress.XtraBars.BarButtonItem barButtonItemNewInterlocale;
        public DevExpress.XtraBars.BarButtonItem barButtonItemNewMember;
        public DevExpress.XtraEditors.LabelControl lblGathering;
        public DevExpress.XtraBars.BarStaticItem lblGatheringBatch;
        public DevExpress.XtraBars.BarStaticItem lblGatheringDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        public DevExpress.XtraEditors.LabelControl lblChurchID;
        public DevExpress.XtraEditors.LabelControl lblName;
        public DevExpress.XtraEditors.LabelControl lblLocale;
        private DevExpress.XtraBars.BarButtonItem barButtonTest;
    }
}