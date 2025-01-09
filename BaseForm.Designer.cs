
namespace ChequeTrackerDemo
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendViewJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainAccountCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.maintainChequeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.insertYearEndEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.smartStreamImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reallocateAgeingPeriodFo71250ChequesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconciledItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuallyMatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticallyMatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unreconciledItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitsCreditsItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailAgeingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryAgeingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslShortcuts = new System.Windows.Forms.ToolStrip();
            this.tlsCreateJournal = new System.Windows.Forms.ToolStripButton();
            this.tlsAmendJournal = new System.Windows.Forms.ToolStripButton();
            this.tlsPrint = new System.Windows.Forms.ToolStripButton();
            this.tlsExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tslShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createJournalToolStripMenuItem,
            this.amendViewJournalToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectAccountToolStripMenuItem,
            this.maintainAccountCodesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.maintainChequeNumberToolStripMenuItem,
            this.toolStripMenuItem3,
            this.insertYearEndEntriesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.smartStreamImportToolStripMenuItem,
            this.toolStripMenuItem5,
            this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem,
            this.reallocateAgeingPeriodFo71250ChequesToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // createJournalToolStripMenuItem
            // 
            this.createJournalToolStripMenuItem.Name = "createJournalToolStripMenuItem";
            this.createJournalToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.createJournalToolStripMenuItem.Text = "Create Journal";
            this.createJournalToolStripMenuItem.Click += new System.EventHandler(this.createJournalToolStripMenuItem_Click);
            // 
            // amendViewJournalToolStripMenuItem
            // 
            this.amendViewJournalToolStripMenuItem.Name = "amendViewJournalToolStripMenuItem";
            this.amendViewJournalToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.amendViewJournalToolStripMenuItem.Text = "Amend/View Journal";
            this.amendViewJournalToolStripMenuItem.Click += new System.EventHandler(this.amendViewJournalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(379, 6);
            // 
            // selectAccountToolStripMenuItem
            // 
            this.selectAccountToolStripMenuItem.Name = "selectAccountToolStripMenuItem";
            this.selectAccountToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.selectAccountToolStripMenuItem.Text = "Select Account";
            this.selectAccountToolStripMenuItem.Click += new System.EventHandler(this.selectAccountToolStripMenuItem_Click);
            // 
            // maintainAccountCodesToolStripMenuItem
            // 
            this.maintainAccountCodesToolStripMenuItem.Name = "maintainAccountCodesToolStripMenuItem";
            this.maintainAccountCodesToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.maintainAccountCodesToolStripMenuItem.Text = "Maintain Account Codes";
            this.maintainAccountCodesToolStripMenuItem.Click += new System.EventHandler(this.maintainAccountCodesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(379, 6);
            // 
            // maintainChequeNumberToolStripMenuItem
            // 
            this.maintainChequeNumberToolStripMenuItem.Name = "maintainChequeNumberToolStripMenuItem";
            this.maintainChequeNumberToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.maintainChequeNumberToolStripMenuItem.Text = "Maintain Cheque Number";
            this.maintainChequeNumberToolStripMenuItem.Click += new System.EventHandler(this.maintainChequeNumberToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(379, 6);
            // 
            // insertYearEndEntriesToolStripMenuItem
            // 
            this.insertYearEndEntriesToolStripMenuItem.Name = "insertYearEndEntriesToolStripMenuItem";
            this.insertYearEndEntriesToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.insertYearEndEntriesToolStripMenuItem.Text = "&Insert Year-End Entries";
            this.insertYearEndEntriesToolStripMenuItem.Click += new System.EventHandler(this.insertYearEndEntriesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(379, 6);
            // 
            // smartStreamImportToolStripMenuItem
            // 
            this.smartStreamImportToolStripMenuItem.Name = "smartStreamImportToolStripMenuItem";
            this.smartStreamImportToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.smartStreamImportToolStripMenuItem.Text = "SmartStream Import";
            this.smartStreamImportToolStripMenuItem.Click += new System.EventHandler(this.smartStreamImportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(379, 6);
            // 
            // reallocateAgeingPeriodFo72120ChequesToolStripMenuItem
            // 
            this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem.Name = "reallocateAgeingPeriodFo72120ChequesToolStripMenuItem";
            this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem.Text = "Reallocate Ageing Period fo 72120 Cheques";
            this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem.Click += new System.EventHandler(this.reallocateAgeingPeriodFo72120ChequesToolStripMenuItem_Click);
            // 
            // reallocateAgeingPeriodFo71250ChequesToolStripMenuItem
            // 
            this.reallocateAgeingPeriodFo71250ChequesToolStripMenuItem.Enabled = false;
            this.reallocateAgeingPeriodFo71250ChequesToolStripMenuItem.Name = "reallocateAgeingPeriodFo71250ChequesToolStripMenuItem";
            this.reallocateAgeingPeriodFo71250ChequesToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.reallocateAgeingPeriodFo71250ChequesToolStripMenuItem.Text = "Reallocate Ageing Period fo 71250 Cheques";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconciledItemsToolStripMenuItem,
            this.unreconciledItemsToolStripMenuItem,
            this.ageingReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // reconciledItemsToolStripMenuItem
            // 
            this.reconciledItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuallyMatchedToolStripMenuItem,
            this.automaticallyMatchedToolStripMenuItem});
            this.reconciledItemsToolStripMenuItem.Name = "reconciledItemsToolStripMenuItem";
            this.reconciledItemsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.reconciledItemsToolStripMenuItem.Text = "Reconciled Items";
            // 
            // manuallyMatchedToolStripMenuItem
            // 
            this.manuallyMatchedToolStripMenuItem.Name = "manuallyMatchedToolStripMenuItem";
            this.manuallyMatchedToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.manuallyMatchedToolStripMenuItem.Text = "Manually Matched";
            this.manuallyMatchedToolStripMenuItem.Click += new System.EventHandler(this.manuallyMatchedToolStripMenuItem_Click);
            // 
            // automaticallyMatchedToolStripMenuItem
            // 
            this.automaticallyMatchedToolStripMenuItem.Name = "automaticallyMatchedToolStripMenuItem";
            this.automaticallyMatchedToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.automaticallyMatchedToolStripMenuItem.Text = "Automatically Matched";
            this.automaticallyMatchedToolStripMenuItem.Click += new System.EventHandler(this.automaticallyMatchedToolStripMenuItem_Click);
            // 
            // unreconciledItemsToolStripMenuItem
            // 
            this.unreconciledItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsItemsToolStripMenuItem,
            this.debitItemsToolStripMenuItem,
            this.debitsCreditsItemsToolStripMenuItem});
            this.unreconciledItemsToolStripMenuItem.Name = "unreconciledItemsToolStripMenuItem";
            this.unreconciledItemsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.unreconciledItemsToolStripMenuItem.Text = "Unreconciled Items";
            // 
            // creditsItemsToolStripMenuItem
            // 
            this.creditsItemsToolStripMenuItem.Name = "creditsItemsToolStripMenuItem";
            this.creditsItemsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.creditsItemsToolStripMenuItem.Text = "Credits Items";
            this.creditsItemsToolStripMenuItem.Click += new System.EventHandler(this.creditsItemsToolStripMenuItem_Click);
            // 
            // debitItemsToolStripMenuItem
            // 
            this.debitItemsToolStripMenuItem.Name = "debitItemsToolStripMenuItem";
            this.debitItemsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.debitItemsToolStripMenuItem.Text = "Debit Items";
            this.debitItemsToolStripMenuItem.Click += new System.EventHandler(this.debitItemsToolStripMenuItem_Click);
            // 
            // debitsCreditsItemsToolStripMenuItem
            // 
            this.debitsCreditsItemsToolStripMenuItem.Name = "debitsCreditsItemsToolStripMenuItem";
            this.debitsCreditsItemsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.debitsCreditsItemsToolStripMenuItem.Text = "Debits && Credits Items";
            this.debitsCreditsItemsToolStripMenuItem.Click += new System.EventHandler(this.debitsCreditsItemsToolStripMenuItem_Click);
            // 
            // ageingReportToolStripMenuItem
            // 
            this.ageingReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailAgeingReportToolStripMenuItem,
            this.summaryAgeingReportToolStripMenuItem});
            this.ageingReportToolStripMenuItem.Name = "ageingReportToolStripMenuItem";
            this.ageingReportToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ageingReportToolStripMenuItem.Text = "Ageing Report";
            // 
            // detailAgeingReportToolStripMenuItem
            // 
            this.detailAgeingReportToolStripMenuItem.Name = "detailAgeingReportToolStripMenuItem";
            this.detailAgeingReportToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.detailAgeingReportToolStripMenuItem.Text = "Detail Ageing Report";
            this.detailAgeingReportToolStripMenuItem.Click += new System.EventHandler(this.detailAgeingReportToolStripMenuItem_Click);
            // 
            // summaryAgeingReportToolStripMenuItem
            // 
            this.summaryAgeingReportToolStripMenuItem.Name = "summaryAgeingReportToolStripMenuItem";
            this.summaryAgeingReportToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.summaryAgeingReportToolStripMenuItem.Text = "Summary Ageing Report";
            this.summaryAgeingReportToolStripMenuItem.Click += new System.EventHandler(this.summaryAgeingReportToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Enabled = false;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tslShortcuts
            // 
            this.tslShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tslShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCreateJournal,
            this.tlsAmendJournal,
            this.tlsPrint,
            this.tlsExit});
            this.tslShortcuts.Location = new System.Drawing.Point(0, 28);
            this.tslShortcuts.Name = "tslShortcuts";
            this.tslShortcuts.Size = new System.Drawing.Size(1016, 31);
            this.tslShortcuts.TabIndex = 2;
            this.tslShortcuts.Text = "toolStrip1";
            this.tslShortcuts.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tslShortcuts_ItemClicked);
            // 
            // tlsCreateJournal
            // 
            this.tlsCreateJournal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsCreateJournal.Image = ((System.Drawing.Image)(resources.GetObject("tlsCreateJournal.Image")));
            this.tlsCreateJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsCreateJournal.Name = "tlsCreateJournal";
            this.tlsCreateJournal.Size = new System.Drawing.Size(29, 28);
            this.tlsCreateJournal.Text = "Create Journal";
            this.tlsCreateJournal.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tlsAmendJournal
            // 
            this.tlsAmendJournal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsAmendJournal.Image = ((System.Drawing.Image)(resources.GetObject("tlsAmendJournal.Image")));
            this.tlsAmendJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsAmendJournal.Name = "tlsAmendJournal";
            this.tlsAmendJournal.Size = new System.Drawing.Size(29, 28);
            this.tlsAmendJournal.Text = "Amend Journal";
            this.tlsAmendJournal.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tlsPrint
            // 
            this.tlsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsPrint.Enabled = false;
            this.tlsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tlsPrint.Image")));
            this.tlsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsPrint.Name = "tlsPrint";
            this.tlsPrint.Size = new System.Drawing.Size(29, 28);
            this.tlsPrint.Text = "Print";
            // 
            // tlsExit
            // 
            this.tlsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsExit.Image")));
            this.tlsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsExit.Name = "tlsExit";
            this.tlsExit.Size = new System.Drawing.Size(29, 28);
            this.tlsExit.Text = "Exit";
            this.tlsExit.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(1, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 398);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tslShortcuts);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BaseForm";
            this.Text = "Lewis Cheque Tracker System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tslShortcuts.ResumeLayout(false);
            this.tslShortcuts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendViewJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainAccountCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maintainChequeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem insertYearEndEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem smartStreamImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem reallocateAgeingPeriodFo72120ChequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reallocateAgeingPeriodFo71250ChequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconciledItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuallyMatchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticallyMatchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unreconciledItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitsCreditsItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailAgeingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryAgeingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tslShortcuts;
        private System.Windows.Forms.ToolStripButton tlsCreateJournal;
        private System.Windows.Forms.ToolStripButton tlsAmendJournal;
        private System.Windows.Forms.ToolStripButton tlsPrint;
        private System.Windows.Forms.ToolStripButton tlsExit;
        private System.Windows.Forms.Panel panel1;
    }
}