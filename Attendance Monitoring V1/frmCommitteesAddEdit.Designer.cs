namespace AMS
{
    partial class frmCommitteesAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommitteesAddEdit));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCommittee = new DevExpress.XtraEditors.TextEdit();
            this.txtCommitteeCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommittee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommitteeCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mnuBtnSave,
            this.mnuBtnClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(360, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // mnuBtnSave
            // 
            this.mnuBtnSave.Caption = "SAVE";
            this.mnuBtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnSave.Glyph")));
            this.mnuBtnSave.Id = 1;
            this.mnuBtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnSave.LargeGlyph")));
            this.mnuBtnSave.Name = "mnuBtnSave";
            this.mnuBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnSave_ItemClick);
            // 
            // mnuBtnClose
            // 
            this.mnuBtnClose.Caption = "CLOSE";
            this.mnuBtnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnClose.Glyph")));
            this.mnuBtnClose.Id = 2;
            this.mnuBtnClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnClose.LargeGlyph")));
            this.mnuBtnClose.Name = "mnuBtnClose";
            this.mnuBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuBtnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuBtnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 332);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(360, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 227);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "COMMITTEE :";
            // 
            // txtCommittee
            // 
            this.txtCommittee.Location = new System.Drawing.Point(35, 247);
            this.txtCommittee.MenuManager = this.ribbonControl1;
            this.txtCommittee.Name = "txtCommittee";
            this.txtCommittee.Size = new System.Drawing.Size(267, 20);
            this.txtCommittee.TabIndex = 4;
            // 
            // txtCommitteeCode
            // 
            this.txtCommitteeCode.Enabled = false;
            this.txtCommitteeCode.Location = new System.Drawing.Point(35, 201);
            this.txtCommitteeCode.MenuManager = this.ribbonControl1;
            this.txtCommitteeCode.Name = "txtCommitteeCode";
            this.txtCommitteeCode.Size = new System.Drawing.Size(267, 20);
            this.txtCommitteeCode.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "COMMITTEE CODE :";
            // 
            // frmCommitteesAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 355);
            this.Controls.Add(this.txtCommitteeCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCommittee);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmCommitteesAddEdit";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "COMMITTEE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCommitteesAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommittee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommitteeCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem mnuBtnSave;
        private DevExpress.XtraBars.BarButtonItem mnuBtnClose;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCommittee;
        private DevExpress.XtraEditors.TextEdit txtCommitteeCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}