namespace AMS
{
    partial class frmModuleAddEdit
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditModule = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonAddModule = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCloseModule = new DevExpress.XtraEditors.SimpleButton();
            this.textEditParentID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditParentID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(401, 54);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 234);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(401, 23);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Module Name:";
            // 
            // textEditModule
            // 
            this.textEditModule.Location = new System.Drawing.Point(22, 93);
            this.textEditModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditModule.MenuManager = this.ribbonControl1;
            this.textEditModule.Name = "textEditModule";
            this.textEditModule.Size = new System.Drawing.Size(350, 20);
            this.textEditModule.TabIndex = 3;
            // 
            // simpleButtonAddModule
            // 
            this.simpleButtonAddModule.Location = new System.Drawing.Point(94, 167);
            this.simpleButtonAddModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButtonAddModule.Name = "simpleButtonAddModule";
            this.simpleButtonAddModule.Size = new System.Drawing.Size(99, 25);
            this.simpleButtonAddModule.TabIndex = 5;
            this.simpleButtonAddModule.Text = "SAVE";
            this.simpleButtonAddModule.Click += new System.EventHandler(this.simpleButtonAddModule_Click);
            // 
            // simpleButtonCloseModule
            // 
            this.simpleButtonCloseModule.Location = new System.Drawing.Point(198, 167);
            this.simpleButtonCloseModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButtonCloseModule.Name = "simpleButtonCloseModule";
            this.simpleButtonCloseModule.Size = new System.Drawing.Size(99, 25);
            this.simpleButtonCloseModule.TabIndex = 6;
            this.simpleButtonCloseModule.Text = "CLOSE";
            this.simpleButtonCloseModule.Click += new System.EventHandler(this.simpleButtonCloseModule_Click);
            // 
            // textEditParentID
            // 
            this.textEditParentID.Location = new System.Drawing.Point(21, 136);
            this.textEditParentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditParentID.MenuManager = this.ribbonControl1;
            this.textEditParentID.Name = "textEditParentID";
            this.textEditParentID.Size = new System.Drawing.Size(350, 20);
            this.textEditParentID.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 118);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Parent Code:";
            // 
            // frmModuleAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 257);
            this.Controls.Add(this.textEditParentID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButtonCloseModule);
            this.Controls.Add(this.simpleButtonAddModule);
            this.Controls.Add(this.textEditModule);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModuleAddEdit";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "MODULES";
            this.Load += new System.EventHandler(this.frmModuleAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditParentID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditModule;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddModule;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCloseModule;
        private DevExpress.XtraEditors.TextEdit textEditParentID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}