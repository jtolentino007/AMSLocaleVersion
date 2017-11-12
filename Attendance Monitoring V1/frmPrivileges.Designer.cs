namespace AMS
{
    partial class frmPrivileges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrivileges));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddPrivilege = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditPrivilege = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeletePrivilege = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPermissions = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlPrivileges = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemClose,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItemAddPrivilege,
            this.barButtonItemEditPrivilege,
            this.barButtonItemDeletePrivilege,
            this.barButtonItemSearch,
            this.barButtonItemPermissions});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(773, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItemClose
            // 
            this.barButtonItemClose.Caption = "CLOSE";
            this.barButtonItemClose.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemClose.Glyph")));
            this.barButtonItemClose.Id = 1;
            this.barButtonItemClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemClose.LargeGlyph")));
            this.barButtonItemClose.Name = "barButtonItemClose";
            this.barButtonItemClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClose_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItemAddPrivilege
            // 
            this.barButtonItemAddPrivilege.Caption = "ADD PRIVILEGE";
            this.barButtonItemAddPrivilege.Id = 4;
            this.barButtonItemAddPrivilege.LargeGlyph = global::AMS.Properties.Resources.icons8_Member_48_add;
            this.barButtonItemAddPrivilege.Name = "barButtonItemAddPrivilege";
            this.barButtonItemAddPrivilege.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddPrivilege_ItemClick);
            // 
            // barButtonItemEditPrivilege
            // 
            this.barButtonItemEditPrivilege.Caption = "EDIT PRIVILEGE";
            this.barButtonItemEditPrivilege.Id = 5;
            this.barButtonItemEditPrivilege.LargeGlyph = global::AMS.Properties.Resources.icons8_Member_48_edit;
            this.barButtonItemEditPrivilege.Name = "barButtonItemEditPrivilege";
            this.barButtonItemEditPrivilege.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditPrivilege_ItemClick);
            // 
            // barButtonItemDeletePrivilege
            // 
            this.barButtonItemDeletePrivilege.Caption = "DELETE PRIVILEGE";
            this.barButtonItemDeletePrivilege.Id = 6;
            this.barButtonItemDeletePrivilege.LargeGlyph = global::AMS.Properties.Resources.icons8_Member_48_delete;
            this.barButtonItemDeletePrivilege.Name = "barButtonItemDeletePrivilege";
            this.barButtonItemDeletePrivilege.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeletePrivilege_ItemClick);
            // 
            // barButtonItemSearch
            // 
            this.barButtonItemSearch.Caption = "SEARCH PRIVILEGE";
            this.barButtonItemSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSearch.Glyph")));
            this.barButtonItemSearch.Id = 7;
            this.barButtonItemSearch.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSearch.LargeGlyph")));
            this.barButtonItemSearch.Name = "barButtonItemSearch";
            this.barButtonItemSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSearch_ItemClick);
            // 
            // barButtonItemPermissions
            // 
            this.barButtonItemPermissions.Caption = "PRIVILEGE PERMISSIONS";
            this.barButtonItemPermissions.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemPermissions.Glyph")));
            this.barButtonItemPermissions.Id = 8;
            this.barButtonItemPermissions.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemPermissions.LargeGlyph")));
            this.barButtonItemPermissions.Name = "barButtonItemPermissions";
            this.barButtonItemPermissions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPermissions_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAddPrivilege);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemEditPrivilege);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDeletePrivilege);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemSearch);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemPermissions);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 508);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(773, 23);
            // 
            // gridControlPrivileges
            // 
            this.gridControlPrivileges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrivileges.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPrivileges.Location = new System.Drawing.Point(0, 147);
            this.gridControlPrivileges.MainView = this.gridView1;
            this.gridControlPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPrivileges.MenuManager = this.ribbonControl1;
            this.gridControlPrivileges.Name = "gridControlPrivileges";
            this.gridControlPrivileges.Size = new System.Drawing.Size(773, 361);
            this.gridControlPrivileges.TabIndex = 2;
            this.gridControlPrivileges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControlPrivileges;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Privilege code";
            this.gridColumn1.FieldName = "privilege_id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Privilege";
            this.gridColumn2.FieldName = "privilege_name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 531);
            this.Controls.Add(this.gridControlPrivileges);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrivileges";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PRIVILEGES";
            this.Load += new System.EventHandler(this.frmPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddPrivilege;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditPrivilege;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeletePrivilege;
        private DevExpress.XtraGrid.GridControl gridControlPrivileges;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPermissions;
    }
}