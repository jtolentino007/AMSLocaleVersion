namespace AMS
{
    partial class frmCommitteeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommitteeReport));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGenerate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueCommitteeReport = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCommitteeReport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonGenerate,
            this.barButtonCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(371, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonGenerate
            // 
            this.barButtonGenerate.Caption = "Print Preview";
            this.barButtonGenerate.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonGenerate.Glyph")));
            this.barButtonGenerate.Id = 1;
            this.barButtonGenerate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonGenerate.LargeGlyph")));
            this.barButtonGenerate.Name = "barButtonGenerate";
            this.barButtonGenerate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonGenerate_ItemClick);
            // 
            // barButtonCancel
            // 
            this.barButtonCancel.Caption = "Cancel";
            this.barButtonCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonCancel.Glyph")));
            this.barButtonCancel.Id = 2;
            this.barButtonCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonCancel.LargeGlyph")));
            this.barButtonCancel.Name = "barButtonCancel";
            this.barButtonCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCancel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TASK";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGenerate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 290);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(371, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 182);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Committee :";
            // 
            // lueCommitteeReport
            // 
            this.lueCommitteeReport.Location = new System.Drawing.Point(38, 200);
            this.lueCommitteeReport.MenuManager = this.ribbonControl1;
            this.lueCommitteeReport.Name = "lueCommitteeReport";
            this.lueCommitteeReport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCommitteeReport.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("committee_name", "Committee")});
            this.lueCommitteeReport.Properties.NullText = "";
            this.lueCommitteeReport.Properties.NullValuePrompt = "SELECT COMMITTEE";
            this.lueCommitteeReport.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueCommitteeReport.Properties.PopupSizeable = false;
            this.lueCommitteeReport.Size = new System.Drawing.Size(291, 20);
            this.lueCommitteeReport.TabIndex = 4;
            // 
            // frmCommitteeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 313);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.lueCommitteeReport);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "frmCommitteeReport";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Generate Committee Report";
            this.Load += new System.EventHandler(this.frmcommitteeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCommitteeReport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonGenerate;
        private DevExpress.XtraBars.BarButtonItem barButtonCancel;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueCommitteeReport;
    }
}