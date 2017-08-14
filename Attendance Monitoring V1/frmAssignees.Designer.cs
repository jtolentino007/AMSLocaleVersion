namespace AMS
{
    partial class frmAssignee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignee));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemInsertAssignee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkedComboBoxEditAddPro = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkedComboBoxEditOfficers = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lueWorker = new DevExpress.XtraEditors.LookUpEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.txtOfficers = new System.Windows.Forms.TextBox();
            this.txtAddpro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditAddPro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditOfficers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueWorker.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemInsertAssignee,
            this.barButtonItemCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(443, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItemInsertAssignee
            // 
            this.barButtonItemInsertAssignee.Caption = "ACCEPT";
            this.barButtonItemInsertAssignee.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemInsertAssignee.Glyph")));
            this.barButtonItemInsertAssignee.Id = 1;
            this.barButtonItemInsertAssignee.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemInsertAssignee.LargeGlyph")));
            this.barButtonItemInsertAssignee.Name = "barButtonItemInsertAssignee";
            this.barButtonItemInsertAssignee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "CANCEL";
            this.barButtonItemCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.Glyph")));
            this.barButtonItemCancel.Id = 3;
            this.barButtonItemCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.LargeGlyph")));
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemInsertAssignee);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 465);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(443, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(32, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "WORKER :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(32, 225);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "OFFICER(S) :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(32, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "ADDPRO :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(32, 346);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(357, 71);
            this.txtRemarks.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(32, 327);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "REMARKS :";
            // 
            // checkedComboBoxEditAddPro
            // 
            this.checkedComboBoxEditAddPro.Location = new System.Drawing.Point(32, 294);
            this.checkedComboBoxEditAddPro.MenuManager = this.ribbonControl1;
            this.checkedComboBoxEditAddPro.Name = "checkedComboBoxEditAddPro";
            this.checkedComboBoxEditAddPro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditAddPro.Properties.NullValuePrompt = "Please Select Addpro(s)";
            this.checkedComboBoxEditAddPro.Properties.NullValuePromptShowForEmptyValue = true;
            this.checkedComboBoxEditAddPro.Size = new System.Drawing.Size(358, 20);
            this.checkedComboBoxEditAddPro.TabIndex = 10;
            this.checkedComboBoxEditAddPro.Visible = false;
            // 
            // checkedComboBoxEditOfficers
            // 
            this.checkedComboBoxEditOfficers.Location = new System.Drawing.Point(32, 244);
            this.checkedComboBoxEditOfficers.MenuManager = this.ribbonControl1;
            this.checkedComboBoxEditOfficers.Name = "checkedComboBoxEditOfficers";
            this.checkedComboBoxEditOfficers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditOfficers.Properties.NullValuePrompt = "Please Select Officer(s)";
            this.checkedComboBoxEditOfficers.Properties.NullValuePromptShowForEmptyValue = true;
            this.checkedComboBoxEditOfficers.Size = new System.Drawing.Size(358, 20);
            this.checkedComboBoxEditOfficers.TabIndex = 5;
            this.checkedComboBoxEditOfficers.Visible = false;
            // 
            // lueWorker
            // 
            this.lueWorker.Location = new System.Drawing.Point(32, 193);
            this.lueWorker.MenuManager = this.ribbonControl1;
            this.lueWorker.Name = "lueWorker";
            this.lueWorker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueWorker.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("brethren_id", "BrethrenID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrethrenName", "Brethren Name")});
            this.lueWorker.Properties.NullText = "";
            this.lueWorker.Properties.NullValuePrompt = "Please Select Worker";
            this.lueWorker.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueWorker.Size = new System.Drawing.Size(358, 20);
            this.lueWorker.TabIndex = 3;
            this.lueWorker.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtWorker
            // 
            this.txtWorker.Location = new System.Drawing.Point(32, 193);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(357, 21);
            this.txtWorker.TabIndex = 1;
            // 
            // txtOfficers
            // 
            this.txtOfficers.Location = new System.Drawing.Point(32, 243);
            this.txtOfficers.Name = "txtOfficers";
            this.txtOfficers.Size = new System.Drawing.Size(357, 21);
            this.txtOfficers.TabIndex = 2;
            // 
            // txtAddpro
            // 
            this.txtAddpro.Location = new System.Drawing.Point(32, 294);
            this.txtAddpro.Name = "txtAddpro";
            this.txtAddpro.Size = new System.Drawing.Size(357, 21);
            this.txtAddpro.TabIndex = 3;
            // 
            // frmAssignee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 488);
            this.Controls.Add(this.txtAddpro);
            this.Controls.Add(this.txtOfficers);
            this.Controls.Add(this.txtWorker);
            this.Controls.Add(this.checkedComboBoxEditAddPro);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.checkedComboBoxEditOfficers);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lueWorker);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmAssignee";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Destino";
            this.Load += new System.EventHandler(this.frmAssignee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditAddPro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditOfficers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueWorker.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemInsertAssignee;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public System.Windows.Forms.TextBox txtRemarks;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        public DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEditAddPro;
        public DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEditOfficers;
        public DevExpress.XtraEditors.LookUpEdit lueWorker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txtWorker;
        public System.Windows.Forms.TextBox txtOfficers;
        public System.Windows.Forms.TextBox txtAddpro;
    }
}