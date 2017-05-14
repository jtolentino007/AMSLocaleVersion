namespace AMS
{
    partial class frmLocale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocale));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.mnubtnAddLocale = new DevExpress.XtraBars.BarButtonItem();
            this.mnubtnEditLocale = new DevExpress.XtraBars.BarButtonItem();
            this.mnubtnDeleteLocale = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridLocale = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnClose,
            this.mnubtnAddLocale,
            this.mnubtnEditLocale,
            this.mnubtnDeleteLocale,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(784, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "CLOSE";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 1;
            this.btnClose.LargeGlyph = global::AMS.Properties.Resources.error;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // mnubtnAddLocale
            // 
            this.mnubtnAddLocale.Caption = "New Locale";
            this.mnubtnAddLocale.Glyph = global::AMS.Properties.Resources.add_1;
            this.mnubtnAddLocale.Id = 2;
            this.mnubtnAddLocale.LargeGlyph = global::AMS.Properties.Resources.locale_add;
            this.mnubtnAddLocale.Name = "mnubtnAddLocale";
            this.mnubtnAddLocale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnubtnAddLocale_ItemClick);
            // 
            // mnubtnEditLocale
            // 
            this.mnubtnEditLocale.Caption = "Edit Locale";
            this.mnubtnEditLocale.Glyph = global::AMS.Properties.Resources.edit;
            this.mnubtnEditLocale.Id = 3;
            this.mnubtnEditLocale.LargeGlyph = global::AMS.Properties.Resources.locale_edit;
            this.mnubtnEditLocale.Name = "mnubtnEditLocale";
            this.mnubtnEditLocale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnubtnEditLocale_ItemClick);
            // 
            // mnubtnDeleteLocale
            // 
            this.mnubtnDeleteLocale.Caption = "Delete Locale";
            this.mnubtnDeleteLocale.Glyph = global::AMS.Properties.Resources.Delete_96;
            this.mnubtnDeleteLocale.Id = 4;
            this.mnubtnDeleteLocale.LargeGlyph = global::AMS.Properties.Resources.locale_delete;
            this.mnubtnDeleteLocale.Name = "mnubtnDeleteLocale";
            this.mnubtnDeleteLocale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnubtnDeleteLocale_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "FIN";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mnubtnAddLocale);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnubtnEditLocale);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnubtnDeleteLocale);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 545);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(784, 23);
            // 
            // gridLocale
            // 
            this.gridLocale.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridLocale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLocale.Location = new System.Drawing.Point(0, 147);
            this.gridLocale.MainView = this.gridView1;
            this.gridLocale.MenuManager = this.ribbonControl1;
            this.gridLocale.Name = "gridLocale";
            this.gridLocale.Size = new System.Drawing.Size(784, 398);
            this.gridLocale.TabIndex = 4;
            this.gridLocale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridLocale;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Reference Code";
            this.gridColumn5.FieldName = "locale_code";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Locale";
            this.gridColumn1.FieldName = "locale";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Locale Address";
            this.gridColumn2.FieldName = "address";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "District";
            this.gridColumn3.FieldName = "dist";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Division";
            this.gridColumn4.FieldName = "div";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // frmLocale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 568);
            this.Controls.Add(this.gridLocale);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmLocale";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "LOCALE";
            this.Load += new System.EventHandler(this.frmLocale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem mnubtnAddLocale;
        private DevExpress.XtraBars.BarButtonItem mnubtnEditLocale;
        private DevExpress.XtraBars.BarButtonItem mnubtnDeleteLocale;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridLocale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}