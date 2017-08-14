namespace AMS
{
    partial class frmGatheringTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGatheringTypes));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddGatheringType = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditGatheringType = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteGatheringType = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSearchGatheringType = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridGatheringType = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGatheringType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnClose,
            this.barBtnAddGatheringType,
            this.barBtnEditGatheringType,
            this.barBtnDeleteGatheringType,
            this.barBtnSearchGatheringType});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(844, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnClose
            // 
            this.barBtnClose.Caption = "CLOSE";
            this.barBtnClose.Id = 1;
            this.barBtnClose.LargeGlyph = global::AMS.Properties.Resources.error;
            this.barBtnClose.Name = "barBtnClose";
            this.barBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barBtnAddGatheringType
            // 
            this.barBtnAddGatheringType.Caption = "New Gathering";
            this.barBtnAddGatheringType.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddGatheringType.Glyph")));
            this.barBtnAddGatheringType.Id = 2;
            this.barBtnAddGatheringType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddGatheringType.LargeGlyph")));
            this.barBtnAddGatheringType.Name = "barBtnAddGatheringType";
            this.barBtnAddGatheringType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddGatheringType_ItemClick);
            // 
            // barBtnEditGatheringType
            // 
            this.barBtnEditGatheringType.Caption = "Edit Gathering";
            this.barBtnEditGatheringType.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditGatheringType.Glyph")));
            this.barBtnEditGatheringType.Id = 3;
            this.barBtnEditGatheringType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditGatheringType.LargeGlyph")));
            this.barBtnEditGatheringType.Name = "barBtnEditGatheringType";
            this.barBtnEditGatheringType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditGatheringType_ItemClick);
            // 
            // barBtnDeleteGatheringType
            // 
            this.barBtnDeleteGatheringType.Caption = "Delete Gathering";
            this.barBtnDeleteGatheringType.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteGatheringType.Glyph")));
            this.barBtnDeleteGatheringType.Id = 4;
            this.barBtnDeleteGatheringType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteGatheringType.LargeGlyph")));
            this.barBtnDeleteGatheringType.Name = "barBtnDeleteGatheringType";
            this.barBtnDeleteGatheringType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteGatheringType_ItemClick);
            // 
            // barBtnSearchGatheringType
            // 
            this.barBtnSearchGatheringType.Caption = "Search Gathering";
            this.barBtnSearchGatheringType.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSearchGatheringType.Glyph")));
            this.barBtnSearchGatheringType.Id = 5;
            this.barBtnSearchGatheringType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSearchGatheringType.LargeGlyph")));
            this.barBtnSearchGatheringType.Name = "barBtnSearchGatheringType";
            this.barBtnSearchGatheringType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSearchGatheringType_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "FILE";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnAddGatheringType);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnEditGatheringType);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDeleteGatheringType);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSearchGatheringType);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "GATHERING TYPES";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 558);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(844, 23);
            // 
            // gridGatheringType
            // 
            this.gridGatheringType.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridGatheringType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGatheringType.Location = new System.Drawing.Point(0, 147);
            this.gridGatheringType.MainView = this.gridView1;
            this.gridGatheringType.MenuManager = this.ribbonControl1;
            this.gridGatheringType.Name = "gridGatheringType";
            this.gridGatheringType.Size = new System.Drawing.Size(844, 411);
            this.gridGatheringType.TabIndex = 5;
            this.gridGatheringType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridGatheringType;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "gathering_id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Gathering Code";
            this.gridColumn1.FieldName = "gathering_code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 333;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Gathering Code";
            this.gridColumn2.FieldName = "gathering";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 335;
            // 
            // frmGatheringTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 581);
            this.Controls.Add(this.gridGatheringType);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmGatheringTypes";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Gathering Management";
            this.Load += new System.EventHandler(this.frmGatheringTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGatheringType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barBtnAddGatheringType;
        private DevExpress.XtraBars.BarButtonItem barBtnEditGatheringType;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteGatheringType;
        private DevExpress.XtraBars.BarButtonItem barBtnSearchGatheringType;
        private DevExpress.XtraGrid.GridControl gridGatheringType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}