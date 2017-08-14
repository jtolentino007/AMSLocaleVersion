namespace AMS
{
    partial class frmInterlocaleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterlocaleReport));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dtDateGathering = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lueGatheringType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueLocale = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGatheringType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocale.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonPreview,
            this.barButtonCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(387, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonPreview
            // 
            this.barButtonPreview.Caption = "Print Preview";
            this.barButtonPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonPreview.Glyph")));
            this.barButtonPreview.Id = 1;
            this.barButtonPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonPreview.LargeGlyph")));
            this.barButtonPreview.Name = "barButtonPreview";
            this.barButtonPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.ribbonPage1.Text = "TASKS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonPreview);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 347);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.ShowSizeGrip = false;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(387, 23);
            // 
            // dtDateGathering
            // 
            this.dtDateGathering.EditValue = null;
            this.dtDateGathering.Location = new System.Drawing.Point(43, 227);
            this.dtDateGathering.MenuManager = this.ribbonControl1;
            this.dtDateGathering.Name = "dtDateGathering";
            this.dtDateGathering.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateGathering.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateGathering.Size = new System.Drawing.Size(291, 20);
            this.dtDateGathering.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 208);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Date :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Gathering Type :";
            // 
            // lueGatheringType
            // 
            this.lueGatheringType.Location = new System.Drawing.Point(43, 182);
            this.lueGatheringType.MenuManager = this.ribbonControl1;
            this.lueGatheringType.Name = "lueGatheringType";
            this.lueGatheringType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGatheringType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering_id", "Gathering ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering_code", "Gathering Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering", "Gathering Type")});
            this.lueGatheringType.Properties.NullText = "";
            this.lueGatheringType.Properties.NullValuePrompt = "SELECT GATHERING";
            this.lueGatheringType.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueGatheringType.Properties.PopupSizeable = false;
            this.lueGatheringType.Size = new System.Drawing.Size(291, 20);
            this.lueGatheringType.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 253);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Locale :";
            // 
            // lueLocale
            // 
            this.lueLocale.Location = new System.Drawing.Point(43, 272);
            this.lueLocale.MenuManager = this.ribbonControl1;
            this.lueLocale.Name = "lueLocale";
            this.lueLocale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLocale.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Locale", "Locale")});
            this.lueLocale.Properties.NullText = "";
            this.lueLocale.Properties.NullValuePrompt = "SELECT LOCALE";
            this.lueLocale.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueLocale.Properties.PopupSizeable = false;
            this.lueLocale.Size = new System.Drawing.Size(291, 20);
            this.lueLocale.TabIndex = 11;
            // 
            // frmInterlocaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 370);
            this.Controls.Add(this.lueLocale);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtDateGathering);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lueGatheringType);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "frmInterlocaleReport";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Generate Interlocale Report";
            this.Load += new System.EventHandler(this.frmInterlocaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGatheringType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocale.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonPreview;
        private DevExpress.XtraBars.BarButtonItem barButtonCancel;
        private DevExpress.XtraEditors.DateEdit dtDateGathering;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lueGatheringType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueLocale;
    }
}