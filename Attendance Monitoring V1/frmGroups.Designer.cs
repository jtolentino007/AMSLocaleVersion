namespace AMS
{
    partial class frmGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroups));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnAddGroup = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnEditGroup = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnDeleteGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridGroups = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mnuBtnClose,
            this.mnuBtnAddGroup,
            this.mnuBtnEditGroup,
            this.mnuBtnDeleteGroup,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(719, 147);
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
            // mnuBtnAddGroup
            // 
            this.mnuBtnAddGroup.Caption = "New Group";
            this.mnuBtnAddGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnAddGroup.Glyph")));
            this.mnuBtnAddGroup.Id = 2;
            this.mnuBtnAddGroup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnAddGroup.LargeGlyph")));
            this.mnuBtnAddGroup.Name = "mnuBtnAddGroup";
            this.mnuBtnAddGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnAddGroup_ItemClick);
            // 
            // mnuBtnEditGroup
            // 
            this.mnuBtnEditGroup.Caption = "Edit Group";
            this.mnuBtnEditGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnEditGroup.Glyph")));
            this.mnuBtnEditGroup.Id = 3;
            this.mnuBtnEditGroup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnEditGroup.LargeGlyph")));
            this.mnuBtnEditGroup.Name = "mnuBtnEditGroup";
            this.mnuBtnEditGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnEditGroup_ItemClick);
            // 
            // mnuBtnDeleteGroup
            // 
            this.mnuBtnDeleteGroup.Caption = "Delete Group";
            this.mnuBtnDeleteGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnDeleteGroup.Glyph")));
            this.mnuBtnDeleteGroup.Id = 4;
            this.mnuBtnDeleteGroup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnDeleteGroup.LargeGlyph")));
            this.mnuBtnDeleteGroup.Name = "mnuBtnDeleteGroup";
            this.mnuBtnDeleteGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnDeleteGroup_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Find Group";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 5;
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
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuBtnAddGroup);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuBtnEditGroup);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuBtnDeleteGroup);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "GROUPS";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 512);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(719, 23);
            // 
            // gridGroups
            // 
            this.gridGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroups.Location = new System.Drawing.Point(0, 147);
            this.gridGroups.MainView = this.gridView1;
            this.gridGroups.MenuManager = this.ribbonControl1;
            this.gridGroups.Name = "gridGroups";
            this.gridGroups.Size = new System.Drawing.Size(719, 365);
            this.gridGroups.TabIndex = 4;
            this.gridGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridGroups;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "Group_Id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Group Code";
            this.gridColumn1.FieldName = "Group_code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 278;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Group Name";
            this.gridColumn2.FieldName = "Group_name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 281;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Group Servant";
            this.gridColumn4.FieldName = "Group_servant";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 317;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Assistant Group Servant";
            this.gridColumn5.FieldName = "Asst_servant";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // frmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 535);
            this.Controls.Add(this.gridGroups);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmGroups";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "GROUPS";
            this.Load += new System.EventHandler(this.frmGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem mnuBtnAddGroup;
        private DevExpress.XtraBars.BarButtonItem mnuBtnEditGroup;
        private DevExpress.XtraBars.BarButtonItem mnuBtnDeleteGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}