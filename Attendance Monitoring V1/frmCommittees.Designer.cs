namespace AMS
{
    partial class frmCommittees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommittees));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnAddCommitttee = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnEditCommitttee = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnDeleteCommitttee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridCommittee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCommittee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mnuBtnClose,
            this.barButtonItem2,
            this.mnuBtnAddCommitttee,
            this.mnuBtnEditCommitttee,
            this.mnuBtnDeleteCommitttee,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(771, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // mnuBtnClose
            // 
            this.mnuBtnClose.Caption = "CLOSE";
            this.mnuBtnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnClose.Glyph")));
            this.mnuBtnClose.Id = 1;
            this.mnuBtnClose.LargeGlyph = global::AMS.Properties.Resources.error;
            this.mnuBtnClose.Name = "mnuBtnClose";
            this.mnuBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnClose_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // mnuBtnAddCommitttee
            // 
            this.mnuBtnAddCommitttee.Caption = "New Committee";
            this.mnuBtnAddCommitttee.Id = 3;
            this.mnuBtnAddCommitttee.LargeGlyph = global::AMS.Properties.Resources.committee_add;
            this.mnuBtnAddCommitttee.Name = "mnuBtnAddCommitttee";
            this.mnuBtnAddCommitttee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnAddCommitttee_ItemClick);
            // 
            // mnuBtnEditCommitttee
            // 
            this.mnuBtnEditCommitttee.Caption = "Edit Committee";
            this.mnuBtnEditCommitttee.Glyph = global::AMS.Properties.Resources.edit;
            this.mnuBtnEditCommitttee.Id = 4;
            this.mnuBtnEditCommitttee.LargeGlyph = global::AMS.Properties.Resources.committee_edit;
            this.mnuBtnEditCommitttee.Name = "mnuBtnEditCommitttee";
            this.mnuBtnEditCommitttee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnEditCommitttee_ItemClick);
            // 
            // mnuBtnDeleteCommitttee
            // 
            this.mnuBtnDeleteCommitttee.Caption = "Remove Committee";
            this.mnuBtnDeleteCommitttee.Glyph = global::AMS.Properties.Resources.Delete_96;
            this.mnuBtnDeleteCommitttee.Id = 5;
            this.mnuBtnDeleteCommitttee.LargeGlyph = global::AMS.Properties.Resources.committee_delete;
            this.mnuBtnDeleteCommitttee.Name = "mnuBtnDeleteCommitttee";
            this.mnuBtnDeleteCommitttee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnDeleteCommitttee_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Find Committee";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TASK";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuBtnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuBtnAddCommitttee);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuBtnEditCommitttee);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuBtnDeleteCommitttee);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "COMMITTEES";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 500);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(771, 23);
            // 
            // gridCommittee
            // 
            this.gridCommittee.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCommittee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCommittee.Location = new System.Drawing.Point(0, 147);
            this.gridCommittee.MainView = this.gridView1;
            this.gridCommittee.MenuManager = this.ribbonControl1;
            this.gridCommittee.Name = "gridCommittee";
            this.gridCommittee.Size = new System.Drawing.Size(771, 353);
            this.gridCommittee.TabIndex = 4;
            this.gridCommittee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridCommittee;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "committee_id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Committee Code";
            this.gridColumn1.FieldName = "committee_code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 333;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Committee Name";
            this.gridColumn2.FieldName = "committee_name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 335;
            // 
            // frmCommittees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 523);
            this.Controls.Add(this.gridCommittee);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmCommittees";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "COMMITTEE";
            this.Load += new System.EventHandler(this.frmCommittees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCommittee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem mnuBtnClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem mnuBtnAddCommitttee;
        private DevExpress.XtraBars.BarButtonItem mnuBtnEditCommitttee;
        private DevExpress.XtraBars.BarButtonItem mnuBtnDeleteCommitttee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridCommittee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}