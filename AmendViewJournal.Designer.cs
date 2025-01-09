
namespace ChequeTrackerDemo
{
    partial class AmendViewJournal
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
            this.grpSelectedItems = new System.Windows.Forms.GroupBox();
            this.txtSelectedCredit = new System.Windows.Forms.TextBox();
            this.txtSelectedDebit = new System.Windows.Forms.TextBox();
            this.txtUnmatchedValue = new System.Windows.Forms.TextBox();
            this.lblUnmatchedValues = new System.Windows.Forms.Label();
            this.lblSelectedCREDITItems = new System.Windows.Forms.Label();
            this.lblSelectedDEBITitems = new System.Windows.Forms.Label();
            this.dgvSummaryReport = new System.Windows.Forms.DataGridView();
            this.dgvSelectedItems = new System.Windows.Forms.DataGridView();
            this.originalChequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchingChequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postingYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHQTRACDEBITSCREDITSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lewdevDataSet12 = new ChequeTrackerDemo.lewdevDataSet12();
            this.cHQTRACDEBITSCREDITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lewdevDataSet10 = new ChequeTrackerDemo.lewdevDataSet10();
            this.grpJournal = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtJournalID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblJournalID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetJrnl = new System.Windows.Forms.Button();
            this.btnUnmatchedJrnl = new System.Windows.Forms.Button();
            this.btnProcessJrnl = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cHQTRACDEBITSCREDITSTableAdapter = new ChequeTrackerDemo.lewdevDataSet10TableAdapters.CHQTRACDEBITSCREDITSTableAdapter();
            this.lewdevDataSet11 = new ChequeTrackerDemo.lewdevDataSet11();
            this.cHQTRACDEBITSCREDITSTableAdapter1 = new ChequeTrackerDemo.lewdevDataSet12TableAdapters.CHQTRACDEBITSCREDITSTableAdapter();
            this.grpSelectedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACDEBITSCREDITSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACDEBITSCREDITSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet10)).BeginInit();
            this.grpJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelectedItems
            // 
            this.grpSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelectedItems.Controls.Add(this.txtSelectedCredit);
            this.grpSelectedItems.Controls.Add(this.txtSelectedDebit);
            this.grpSelectedItems.Controls.Add(this.txtUnmatchedValue);
            this.grpSelectedItems.Controls.Add(this.lblUnmatchedValues);
            this.grpSelectedItems.Controls.Add(this.lblSelectedCREDITItems);
            this.grpSelectedItems.Controls.Add(this.lblSelectedDEBITitems);
            this.grpSelectedItems.Controls.Add(this.dgvSummaryReport);
            this.grpSelectedItems.Controls.Add(this.dgvSelectedItems);
            this.grpSelectedItems.Location = new System.Drawing.Point(12, 13);
            this.grpSelectedItems.Name = "grpSelectedItems";
            this.grpSelectedItems.Size = new System.Drawing.Size(1062, 211);
            this.grpSelectedItems.TabIndex = 0;
            this.grpSelectedItems.TabStop = false;
            this.grpSelectedItems.Text = "Selected Items";
            // 
            // txtSelectedCredit
            // 
            this.txtSelectedCredit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSelectedCredit.Location = new System.Drawing.Point(179, 171);
            this.txtSelectedCredit.Name = "txtSelectedCredit";
            this.txtSelectedCredit.Size = new System.Drawing.Size(115, 22);
            this.txtSelectedCredit.TabIndex = 7;
            this.txtSelectedCredit.TextChanged += new System.EventHandler(this.txtSelectedCredit_TextChanged);
            // 
            // txtSelectedDebit
            // 
            this.txtSelectedDebit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSelectedDebit.Location = new System.Drawing.Point(175, 140);
            this.txtSelectedDebit.Name = "txtSelectedDebit";
            this.txtSelectedDebit.Size = new System.Drawing.Size(119, 22);
            this.txtSelectedDebit.TabIndex = 6;
            this.txtSelectedDebit.TextChanged += new System.EventHandler(this.txtSelectedDebit_TextChanged_1);
            // 
            // txtUnmatchedValue
            // 
            this.txtUnmatchedValue.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtUnmatchedValue.Location = new System.Drawing.Point(554, 154);
            this.txtUnmatchedValue.Name = "txtUnmatchedValue";
            this.txtUnmatchedValue.Size = new System.Drawing.Size(135, 22);
            this.txtUnmatchedValue.TabIndex = 5;
            this.txtUnmatchedValue.TextChanged += new System.EventHandler(this.txtUnmatchedValue_TextChanged);
            // 
            // lblUnmatchedValues
            // 
            this.lblUnmatchedValues.AutoSize = true;
            this.lblUnmatchedValues.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUnmatchedValues.Location = new System.Drawing.Point(391, 154);
            this.lblUnmatchedValues.Name = "lblUnmatchedValues";
            this.lblUnmatchedValues.Size = new System.Drawing.Size(131, 17);
            this.lblUnmatchedValues.TabIndex = 4;
            this.lblUnmatchedValues.Text = "Unmatched Values:";
            // 
            // lblSelectedCREDITItems
            // 
            this.lblSelectedCREDITItems.AutoSize = true;
            this.lblSelectedCREDITItems.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSelectedCREDITItems.Location = new System.Drawing.Point(14, 177);
            this.lblSelectedCREDITItems.Name = "lblSelectedCREDITItems";
            this.lblSelectedCREDITItems.Size = new System.Drawing.Size(158, 17);
            this.lblSelectedCREDITItems.TabIndex = 3;
            this.lblSelectedCREDITItems.Text = "Selected CREDIT Items:";
            // 
            // lblSelectedDEBITitems
            // 
            this.lblSelectedDEBITitems.AutoSize = true;
            this.lblSelectedDEBITitems.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSelectedDEBITitems.Location = new System.Drawing.Point(11, 143);
            this.lblSelectedDEBITitems.Name = "lblSelectedDEBITitems";
            this.lblSelectedDEBITitems.Size = new System.Drawing.Size(148, 17);
            this.lblSelectedDEBITitems.TabIndex = 2;
            this.lblSelectedDEBITitems.Text = "Selected DEBIT Items:";
            // 
            // dgvSummaryReport
            // 
            this.dgvSummaryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSummaryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummaryReport.Location = new System.Drawing.Point(7, 133);
            this.dgvSummaryReport.Name = "dgvSummaryReport";
            this.dgvSummaryReport.RowHeadersWidth = 51;
            this.dgvSummaryReport.RowTemplate.Height = 24;
            this.dgvSummaryReport.Size = new System.Drawing.Size(763, 62);
            this.dgvSummaryReport.TabIndex = 1;
            // 
            // dgvSelectedItems
            // 
            this.dgvSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectedItems.AutoGenerateColumns = false;
            this.dgvSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.originalChequeNoDataGridViewTextBoxColumn,
            this.chequeDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.matchingChequeNoDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.postingYearDataGridViewTextBoxColumn});
            this.dgvSelectedItems.DataSource = this.cHQTRACDEBITSCREDITSBindingSource1;
            this.dgvSelectedItems.Location = new System.Drawing.Point(7, 22);
            this.dgvSelectedItems.Name = "dgvSelectedItems";
            this.dgvSelectedItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSelectedItems.RowHeadersWidth = 51;
            this.dgvSelectedItems.RowTemplate.Height = 24;
            this.dgvSelectedItems.Size = new System.Drawing.Size(1049, 88);
            this.dgvSelectedItems.TabIndex = 0;
            this.dgvSelectedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedItems_CellContentClick);
            // 
            // originalChequeNoDataGridViewTextBoxColumn
            // 
            this.originalChequeNoDataGridViewTextBoxColumn.DataPropertyName = "OriginalChequeNo";
            this.originalChequeNoDataGridViewTextBoxColumn.HeaderText = "OriginalChequeNo";
            this.originalChequeNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.originalChequeNoDataGridViewTextBoxColumn.Name = "originalChequeNoDataGridViewTextBoxColumn";
            this.originalChequeNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // chequeDateDataGridViewTextBoxColumn
            // 
            this.chequeDateDataGridViewTextBoxColumn.DataPropertyName = "ChequeDate";
            this.chequeDateDataGridViewTextBoxColumn.HeaderText = "ChequeDate";
            this.chequeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chequeDateDataGridViewTextBoxColumn.Name = "chequeDateDataGridViewTextBoxColumn";
            this.chequeDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // matchingChequeNoDataGridViewTextBoxColumn
            // 
            this.matchingChequeNoDataGridViewTextBoxColumn.DataPropertyName = "MatchingChequeNo";
            this.matchingChequeNoDataGridViewTextBoxColumn.HeaderText = "MatchingChequeNo";
            this.matchingChequeNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matchingChequeNoDataGridViewTextBoxColumn.Name = "matchingChequeNoDataGridViewTextBoxColumn";
            this.matchingChequeNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Width = 125;
            // 
            // postingYearDataGridViewTextBoxColumn
            // 
            this.postingYearDataGridViewTextBoxColumn.DataPropertyName = "PostingYear";
            this.postingYearDataGridViewTextBoxColumn.HeaderText = "PostingYear";
            this.postingYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postingYearDataGridViewTextBoxColumn.Name = "postingYearDataGridViewTextBoxColumn";
            this.postingYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHQTRACDEBITSCREDITSBindingSource1
            // 
            this.cHQTRACDEBITSCREDITSBindingSource1.DataMember = "CHQTRACDEBITSCREDITS";
            this.cHQTRACDEBITSCREDITSBindingSource1.DataSource = this.lewdevDataSet12;
            // 
            // lewdevDataSet12
            // 
            this.lewdevDataSet12.DataSetName = "lewdevDataSet12";
            this.lewdevDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHQTRACDEBITSCREDITSBindingSource
            // 
            this.cHQTRACDEBITSCREDITSBindingSource.DataMember = "CHQTRACDEBITSCREDITS";
            this.cHQTRACDEBITSCREDITSBindingSource.DataSource = this.lewdevDataSet10;
            // 
            // lewdevDataSet10
            // 
            this.lewdevDataSet10.DataSetName = "lewdevDataSet10";
            this.lewdevDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpJournal
            // 
            this.grpJournal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpJournal.Controls.Add(this.txtAmount);
            this.grpJournal.Controls.Add(this.txtCreationDate);
            this.grpJournal.Controls.Add(this.cmbReason);
            this.grpJournal.Controls.Add(this.txtDescription);
            this.grpJournal.Controls.Add(this.txtUserID);
            this.grpJournal.Controls.Add(this.txtJournalID);
            this.grpJournal.Controls.Add(this.lblAmount);
            this.grpJournal.Controls.Add(this.lblCreationDate);
            this.grpJournal.Controls.Add(this.lblDescription);
            this.grpJournal.Controls.Add(this.lblUserId);
            this.grpJournal.Controls.Add(this.lblReason);
            this.grpJournal.Controls.Add(this.lblJournalID);
            this.grpJournal.Controls.Add(this.dataGridView1);
            this.grpJournal.Location = new System.Drawing.Point(19, 230);
            this.grpJournal.Name = "grpJournal";
            this.grpJournal.Size = new System.Drawing.Size(496, 167);
            this.grpJournal.TabIndex = 1;
            this.grpJournal.TabStop = false;
            this.grpJournal.Text = "Journal";
            this.grpJournal.Enter += new System.EventHandler(this.grpJournal_Enter);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAmount.Location = new System.Drawing.Point(347, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(119, 22);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCreationDate.Location = new System.Drawing.Point(366, 86);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.Size = new System.Drawing.Size(100, 22);
            this.txtCreationDate.TabIndex = 12;
            this.txtCreationDate.TextChanged += new System.EventHandler(this.txtCreationDate_TextChanged);
            // 
            // cmbReason
            // 
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Items.AddRange(new object[] {
            ""});
            this.cmbReason.Location = new System.Drawing.Point(99, 57);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(156, 24);
            this.cmbReason.TabIndex = 10;
            this.cmbReason.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 114);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(274, 35);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtUserID.Location = new System.Drawing.Point(88, 86);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(128, 22);
            this.txtUserID.TabIndex = 8;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtJournalID
            // 
            this.txtJournalID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtJournalID.Location = new System.Drawing.Point(102, 31);
            this.txtJournalID.Name = "txtJournalID";
            this.txtJournalID.Size = new System.Drawing.Size(153, 22);
            this.txtJournalID.TabIndex = 7;
            this.txtJournalID.TextChanged += new System.EventHandler(this.txtJournalID_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAmount.Location = new System.Drawing.Point(276, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCreationDate.Location = new System.Drawing.Point(258, 89);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(95, 17);
            this.lblCreationDate.TabIndex = 5;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescription.Location = new System.Drawing.Point(10, 114);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUserId.Location = new System.Drawing.Point(13, 86);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(59, 17);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "User ID:";
            this.lblUserId.Click += new System.EventHandler(this.lblUserId_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblReason.Location = new System.Drawing.Point(13, 57);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(61, 17);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason:";
            this.lblReason.Click += new System.EventHandler(this.lblReason_Click);
            // 
            // lblJournalID
            // 
            this.lblJournalID.AutoSize = true;
            this.lblJournalID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJournalID.Location = new System.Drawing.Point(10, 31);
            this.lblJournalID.Name = "lblJournalID";
            this.lblJournalID.Size = new System.Drawing.Size(76, 17);
            this.lblJournalID.TabIndex = 1;
            this.lblJournalID.Text = "Journal ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(425, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetJrnl
            // 
            this.btnGetJrnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetJrnl.Location = new System.Drawing.Point(499, 403);
            this.btnGetJrnl.Name = "btnGetJrnl";
            this.btnGetJrnl.Size = new System.Drawing.Size(87, 32);
            this.btnGetJrnl.TabIndex = 3;
            this.btnGetJrnl.Text = "&Get Jrnl";
            this.btnGetJrnl.UseVisualStyleBackColor = true;
            this.btnGetJrnl.Click += new System.EventHandler(this.btnGetJrnl_Click);
            // 
            // btnUnmatchedJrnl
            // 
            this.btnUnmatchedJrnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnmatchedJrnl.Location = new System.Drawing.Point(592, 403);
            this.btnUnmatchedJrnl.Name = "btnUnmatchedJrnl";
            this.btnUnmatchedJrnl.Size = new System.Drawing.Size(119, 32);
            this.btnUnmatchedJrnl.TabIndex = 4;
            this.btnUnmatchedJrnl.Text = "&Unmatched Jrnl";
            this.btnUnmatchedJrnl.UseVisualStyleBackColor = true;
            this.btnUnmatchedJrnl.Click += new System.EventHandler(this.btnUnmatchedJrnl_Click);
            // 
            // btnProcessJrnl
            // 
            this.btnProcessJrnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessJrnl.Location = new System.Drawing.Point(717, 403);
            this.btnProcessJrnl.Name = "btnProcessJrnl";
            this.btnProcessJrnl.Size = new System.Drawing.Size(99, 32);
            this.btnProcessJrnl.TabIndex = 5;
            this.btnProcessJrnl.Text = "&Process Jrnl";
            this.btnProcessJrnl.UseVisualStyleBackColor = true;
            this.btnProcessJrnl.Click += new System.EventHandler(this.btnProcessJrnl_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(822, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(903, 403);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 32);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(984, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cHQTRACDEBITSCREDITSTableAdapter
            // 
            this.cHQTRACDEBITSCREDITSTableAdapter.ClearBeforeFill = true;
            // 
            // lewdevDataSet11
            // 
            this.lewdevDataSet11.DataSetName = "lewdevDataSet11";
            this.lewdevDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHQTRACDEBITSCREDITSTableAdapter1
            // 
            this.cHQTRACDEBITSCREDITSTableAdapter1.ClearBeforeFill = true;
            // 
            // AmendViewJournal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnProcessJrnl);
            this.Controls.Add(this.btnUnmatchedJrnl);
            this.Controls.Add(this.btnGetJrnl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpJournal);
            this.Controls.Add(this.grpSelectedItems);
            this.Name = "AmendViewJournal";
            this.Text = "AmendViewJournal";
            this.Load += new System.EventHandler(this.AmendViewJournal_Load);
            this.grpSelectedItems.ResumeLayout(false);
            this.grpSelectedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACDEBITSCREDITSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACDEBITSCREDITSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet10)).EndInit();
            this.grpJournal.ResumeLayout(false);
            this.grpJournal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectedItems;
        private System.Windows.Forms.DataGridView dgvSelectedItems;
        private System.Windows.Forms.DataGridView dgvSummaryReport;
        private System.Windows.Forms.GroupBox grpJournal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGetJrnl;
        private System.Windows.Forms.Button btnUnmatchedJrnl;
        private System.Windows.Forms.Button btnProcessJrnl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private lewdevDataSet10 lewdevDataSet10;
        private System.Windows.Forms.BindingSource cHQTRACDEBITSCREDITSBindingSource;
        private lewdevDataSet10TableAdapters.CHQTRACDEBITSCREDITSTableAdapter cHQTRACDEBITSCREDITSTableAdapter;
        private System.Windows.Forms.Label lblUnmatchedValues;
        private System.Windows.Forms.Label lblSelectedCREDITItems;
        private System.Windows.Forms.Label lblSelectedDEBITitems;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblJournalID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtJournalID;
        private System.Windows.Forms.TextBox txtSelectedCredit;
        private System.Windows.Forms.TextBox txtSelectedDebit;
        private System.Windows.Forms.TextBox txtUnmatchedValue;
        private System.Windows.Forms.TextBox txtAmount;
        private lewdevDataSet11 lewdevDataSet11;
        private lewdevDataSet12 lewdevDataSet12;
        private System.Windows.Forms.BindingSource cHQTRACDEBITSCREDITSBindingSource1;
        private lewdevDataSet12TableAdapters.CHQTRACDEBITSCREDITSTableAdapter cHQTRACDEBITSCREDITSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalChequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchingChequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postingYearDataGridViewTextBoxColumn;
    }
}