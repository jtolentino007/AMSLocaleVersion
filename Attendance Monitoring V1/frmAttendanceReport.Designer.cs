namespace AMS
{
    partial class frmAttendanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendanceReport));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGenerate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDateGathering = new DevExpress.XtraEditors.DateEdit();
            this.cmbGatheringType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnViewGatheringList = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGatheringType.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(376, 147);
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 330);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(376, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 163);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Gathering Type :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Date :";
            // 
            // dtDateGathering
            // 
            this.dtDateGathering.EditValue = null;
            this.dtDateGathering.Location = new System.Drawing.Point(33, 227);
            this.dtDateGathering.MenuManager = this.ribbonControl1;
            this.dtDateGathering.Name = "dtDateGathering";
            this.dtDateGathering.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateGathering.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateGathering.Size = new System.Drawing.Size(291, 20);
            this.dtDateGathering.TabIndex = 5;
            // 
            // cmbGatheringType
            // 
            this.cmbGatheringType.Location = new System.Drawing.Point(33, 182);
            this.cmbGatheringType.MenuManager = this.ribbonControl1;
            this.cmbGatheringType.Name = "cmbGatheringType";
            this.cmbGatheringType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGatheringType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering_id", "Gathering ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering_code", "Gathering Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering", "Gathering Type")});
            this.cmbGatheringType.Properties.NullText = "";
            this.cmbGatheringType.Properties.NullValuePrompt = "SELECT GATHERING";
            this.cmbGatheringType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbGatheringType.Properties.PopupSizeable = false;
            this.cmbGatheringType.Size = new System.Drawing.Size(291, 20);
            this.cmbGatheringType.TabIndex = 4;
            // 
            // btnViewGatheringList
            // 
            this.btnViewGatheringList.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnViewGatheringList.Appearance.Options.UseBackColor = true;
            this.btnViewGatheringList.Location = new System.Drawing.Point(33, 264);
            this.btnViewGatheringList.Name = "btnViewGatheringList";
            this.btnViewGatheringList.Size = new System.Drawing.Size(291, 23);
            this.btnViewGatheringList.TabIndex = 8;
            this.btnViewGatheringList.Text = "Choose among the list";
            this.btnViewGatheringList.Click += new System.EventHandler(this.btnViewGatheringList_Click);
            // 
            // frmAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 353);
            this.Controls.Add(this.btnViewGatheringList);
            this.Controls.Add(this.dtDateGathering);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.cmbGatheringType);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "frmAttendanceReport";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Gathering Report";
            this.Load += new System.EventHandler(this.frmAttendanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGatheringType.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dtDateGathering;
        private DevExpress.XtraEditors.LookUpEdit cmbGatheringType;
        private DevExpress.XtraEditors.SimpleButton btnViewGatheringList;
    }
}