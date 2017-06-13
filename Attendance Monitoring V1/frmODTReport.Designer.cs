namespace AMS
{
    partial class frmODTReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmODTReport));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGenerate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.numericAbsence = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAddress = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAddress.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(396, 147);
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 376);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(396, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 278);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Address :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 172);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "From";
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = new System.DateTime(2017, 5, 9, 22, 39, 53, 472);
            this.dateFrom.Location = new System.Drawing.Point(33, 191);
            this.dateFrom.MenuManager = this.ribbonControl1;
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(151, 20);
            this.dateFrom.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(190, 172);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(10, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "to";
            // 
            // dateTo
            // 
            this.dateTo.EditValue = new System.DateTime(2017, 5, 9, 22, 40, 4, 852);
            this.dateTo.Location = new System.Drawing.Point(190, 191);
            this.dateTo.MenuManager = this.ribbonControl1;
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(152, 20);
            this.dateTo.TabIndex = 9;
            // 
            // numericAbsence
            // 
            this.numericAbsence.Location = new System.Drawing.Point(33, 243);
            this.numericAbsence.Name = "numericAbsence";
            this.numericAbsence.Size = new System.Drawing.Size(309, 21);
            this.numericAbsence.TabIndex = 10;
            this.numericAbsence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 224);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Number of Absences :";
            // 
            // cmbAddress
            // 
            this.cmbAddress.Location = new System.Drawing.Point(33, 297);
            this.cmbAddress.MenuManager = this.ribbonControl1;
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAddress.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "Address")});
            this.cmbAddress.Properties.NullText = "";
            this.cmbAddress.Properties.NullValuePrompt = "SELECT ADDRESS";
            this.cmbAddress.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbAddress.Properties.PopupSizeable = false;
            this.cmbAddress.Size = new System.Drawing.Size(309, 20);
            this.cmbAddress.TabIndex = 4;
            // 
            // frmODTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 399);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.numericAbsence);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "frmODTReport";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ODT Report";
            this.Load += new System.EventHandler(this.frmAttendanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAddress.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private System.Windows.Forms.NumericUpDown numericAbsence;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmbAddress;
    }
}