namespace AMS
{
    partial class frmLocaleAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocaleAddEdit));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLocale = new DevExpress.XtraEditors.TextEdit();
            this.txtLocaleAddress = new System.Windows.Forms.TextBox();
            this.txtDistrict = new DevExpress.XtraEditors.TextEdit();
            this.txtDivision = new DevExpress.XtraEditors.TextEdit();
            this.txtLocaleCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocaleCode.Properties)).BeginInit();
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
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(472, 187);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
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
            this.ribbonStatusBar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 604);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(472, 29);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 265);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "LOCALE :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 322);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ADDRESS :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 414);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "DISTRICT :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 469);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "DIVISION :";
            // 
            // txtLocale
            // 
            this.txtLocale.Location = new System.Drawing.Point(37, 288);
            this.txtLocale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocale.MenuManager = this.ribbonControl1;
            this.txtLocale.Name = "txtLocale";
            this.txtLocale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLocale.Size = new System.Drawing.Size(356, 22);
            this.txtLocale.TabIndex = 6;
            // 
            // txtLocaleAddress
            // 
            this.txtLocaleAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocaleAddress.Location = new System.Drawing.Point(37, 346);
            this.txtLocaleAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocaleAddress.Multiline = true;
            this.txtLocaleAddress.Name = "txtLocaleAddress";
            this.txtLocaleAddress.Size = new System.Drawing.Size(355, 60);
            this.txtLocaleAddress.TabIndex = 7;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(37, 437);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistrict.MenuManager = this.ribbonControl1;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDistrict.Size = new System.Drawing.Size(356, 22);
            this.txtDistrict.TabIndex = 8;
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(37, 492);
            this.txtDivision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDivision.MenuManager = this.ribbonControl1;
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDivision.Size = new System.Drawing.Size(356, 22);
            this.txtDivision.TabIndex = 9;
            // 
            // txtLocaleCode
            // 
            this.txtLocaleCode.Enabled = false;
            this.txtLocaleCode.Location = new System.Drawing.Point(37, 229);
            this.txtLocaleCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocaleCode.MenuManager = this.ribbonControl1;
            this.txtLocaleCode.Name = "txtLocaleCode";
            this.txtLocaleCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLocaleCode.Size = new System.Drawing.Size(356, 22);
            this.txtLocaleCode.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 206);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "REFERENCE CODE : ";
            // 
            // frmLocaleAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 633);
            this.Controls.Add(this.txtLocaleCode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtLocaleAddress);
            this.Controls.Add(this.txtLocale);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLocaleAddEdit";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "LOCALE";
            this.Load += new System.EventHandler(this.frmLocaleAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocaleCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem mnuBtnSave;
        private DevExpress.XtraBars.BarButtonItem mnuBtnClose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLocale;
        private System.Windows.Forms.TextBox txtLocaleAddress;
        private DevExpress.XtraEditors.TextEdit txtDistrict;
        private DevExpress.XtraEditors.TextEdit txtDivision;
        private DevExpress.XtraEditors.TextEdit txtLocaleCode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}