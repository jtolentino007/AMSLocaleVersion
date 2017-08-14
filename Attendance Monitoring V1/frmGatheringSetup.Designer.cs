namespace AMS
{
    partial class frmGatheringSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGatheringSetup));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbViewingType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtDateGathering = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lueBatch = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbGatheringType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSet = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBatch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbViewingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGatheringType.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(369, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // mnuBtnSave
            // 
            this.mnuBtnSave.Caption = "ACCEPT";
            this.mnuBtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnSave.Glyph")));
            this.mnuBtnSave.Id = 1;
            this.mnuBtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuBtnSave.LargeGlyph")));
            this.mnuBtnSave.Name = "mnuBtnSave";
            this.mnuBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBtnSave_ItemClick);
            // 
            // mnuBtnClose
            // 
            this.mnuBtnClose.Caption = "CANCEL";
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
            this.ribbonPage1.Text = "TASKS";
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 408);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(369, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 230);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "GATHERING TYPE";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 275);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "GATHERING BATCH";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 324);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "VIEWING TYPE";
            // 
            // cmbViewingType
            // 
            this.cmbViewingType.Location = new System.Drawing.Point(32, 343);
            this.cmbViewingType.MenuManager = this.ribbonControl1;
            this.cmbViewingType.Name = "cmbViewingType";
            this.cmbViewingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbViewingType.Properties.Items.AddRange(new object[] {
            "LIVE VIDEO",
            "VIDEO TAPE"});
            this.cmbViewingType.Properties.NullValuePrompt = "SELECT VIEWING TYPE";
            this.cmbViewingType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbViewingType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbViewingType.Size = new System.Drawing.Size(278, 20);
            this.cmbViewingType.TabIndex = 3;
            // 
            // dtDateGathering
            // 
            this.dtDateGathering.EditValue = null;
            this.dtDateGathering.Enabled = false;
            this.dtDateGathering.Location = new System.Drawing.Point(32, 198);
            this.dtDateGathering.MenuManager = this.ribbonControl1;
            this.dtDateGathering.Name = "dtDateGathering";
            this.dtDateGathering.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateGathering.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateGathering.Size = new System.Drawing.Size(250, 20);
            this.dtDateGathering.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "DATE";
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEdit.Image = global::AMS.Properties.Resources.Edit_18;
            this.btnEdit.Location = new System.Drawing.Point(285, 198);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 20);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "simpleButton1";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lueBatch
            // 
            this.lueBatch.Location = new System.Drawing.Point(32, 294);
            this.lueBatch.MenuManager = this.ribbonControl1;
            this.lueBatch.Name = "lueBatch";
            this.lueBatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBatch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Batch_ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Batch_Time", "Time", 20, DevExpress.Utils.FormatType.DateTime, "t", true, DevExpress.Utils.HorzAlignment.Default)});
            this.lueBatch.Properties.DisplayFormat.FormatString = "t";
            this.lueBatch.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.lueBatch.Properties.NullText = "";
            this.lueBatch.Properties.NullValuePrompt = "[SELECT BATCH]";
            this.lueBatch.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueBatch.Properties.ShowFooter = false;
            this.lueBatch.Properties.ShowHeader = false;
            this.lueBatch.Size = new System.Drawing.Size(278, 20);
            this.lueBatch.TabIndex = 25;
            // 
            // cmbGatheringType
            // 
            this.cmbGatheringType.Location = new System.Drawing.Point(32, 249);
            this.cmbGatheringType.MenuManager = this.ribbonControl1;
            this.cmbGatheringType.Name = "cmbGatheringType";
            this.cmbGatheringType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGatheringType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering_id", "Gathering Type ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering_code", "Gathering Code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gathering", "Gathering")});
            this.cmbGatheringType.Properties.NullText = "";
            this.cmbGatheringType.Properties.NullValuePrompt = "SELECT GATHERING";
            this.cmbGatheringType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbGatheringType.Properties.PopupSizeable = false;
            this.cmbGatheringType.Size = new System.Drawing.Size(278, 20);
            this.cmbGatheringType.TabIndex = 1;
            this.cmbGatheringType.TextChanged += new System.EventHandler(this.cmbGatheringyType_TextChanged);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(285, 197);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(25, 21);
            this.btnSet.TabIndex = 28;
            this.btnSet.Text = "SET";
            this.btnSet.Visible = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBatch.Image")));
            this.btnAddBatch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddBatch.Location = new System.Drawing.Point(315, 294);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(22, 20);
            this.btnAddBatch.TabIndex = 30;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // frmGatheringSetup
            // 
            this.ActiveGlowColor = System.Drawing.Color.DodgerBlue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 431);
            this.Controls.Add(this.btnAddBatch);
            this.Controls.Add(this.lueBatch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dtDateGathering);
            this.Controls.Add(this.cmbViewingType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.cmbGatheringType);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGatheringSetup";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "GATHERING SETUP";
            this.Load += new System.EventHandler(this.frmGatheringSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbViewingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateGathering.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGatheringType.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cmbViewingType;
        private DevExpress.XtraEditors.DateEdit dtDateGathering;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSet;
        private DevExpress.XtraEditors.SimpleButton btnAddBatch;
        public DevExpress.XtraEditors.LookUpEdit cmbGatheringType;
        public DevExpress.XtraEditors.LookUpEdit lueBatch;
    }
}