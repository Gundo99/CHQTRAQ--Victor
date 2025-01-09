
namespace ChequeTrackerDemo
{
    partial class ReallocateAP72120Form
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
            this.pnlReallocateReport = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtDateChange = new System.Windows.Forms.TextBox();
            this.lblDateChange = new System.Windows.Forms.Label();
            this.lbl72120 = new System.Windows.Forms.Label();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lewdevDataSet6 = new ChequeTrackerDemo.lewdevDataSet6();
            this.payrollTableAdapter = new ChequeTrackerDemo.lewdevDataSet6TableAdapters.payrollTableAdapter();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.postingPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHQTRACDEBITSCREDITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lewdevDataSet9 = new ChequeTrackerDemo.lewdevDataSet9();
            this.lewdevDataSet7 = new ChequeTrackerDemo.lewdevDataSet7();
            this.payrollBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.payrollTableAdapter1 = new ChequeTrackerDemo.lewdevDataSet7TableAdapters.payrollTableAdapter();
            this.lewdevDataSet8 = new ChequeTrackerDemo.lewdevDataSet8();
            this.payrollBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.payrollTableAdapter2 = new ChequeTrackerDemo.lewdevDataSet8TableAdapters.payrollTableAdapter();
            this.cHQTRACDEBITSCREDITSTableAdapter = new ChequeTrackerDemo.lewdevDataSet9TableAdapters.CHQTRACDEBITSCREDITSTableAdapter();
            this.pnlReallocateReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACDEBITSCREDITSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReallocateReport
            // 
            this.pnlReallocateReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReallocateReport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlReallocateReport.Controls.Add(this.btnOk);
            this.pnlReallocateReport.Controls.Add(this.btnClose);
            this.pnlReallocateReport.Controls.Add(this.btnSave);
            this.pnlReallocateReport.Controls.Add(this.lblSalary);
            this.pnlReallocateReport.Controls.Add(this.txtDateChange);
            this.pnlReallocateReport.Controls.Add(this.lblDateChange);
            this.pnlReallocateReport.Location = new System.Drawing.Point(3, 13);
            this.pnlReallocateReport.Name = "pnlReallocateReport";
            this.pnlReallocateReport.Size = new System.Drawing.Size(1036, 122);
            this.pnlReallocateReport.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(619, 54);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(48, 30);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(895, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(895, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(737, 54);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(86, 29);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Salary";
            // 
            // txtDateChange
            // 
            this.txtDateChange.Location = new System.Drawing.Point(425, 62);
            this.txtDateChange.Name = "txtDateChange";
            this.txtDateChange.Size = new System.Drawing.Size(160, 22);
            this.txtDateChange.TabIndex = 1;
            this.txtDateChange.TextChanged += new System.EventHandler(this.txtDateChange_TextChanged);
            // 
            // lblDateChange
            // 
            this.lblDateChange.AutoSize = true;
            this.lblDateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateChange.Location = new System.Drawing.Point(9, 10);
            this.lblDateChange.Name = "lblDateChange";
            this.lblDateChange.Size = new System.Drawing.Size(388, 87);
            this.lblDateChange.TabIndex = 0;
            this.lblDateChange.Text = "Enter the date to which you want to \r\n                change the cheque dates\r\n  " +
    "                          dd/mm/yyyy format";
            // 
            // lbl72120
            // 
            this.lbl72120.AutoSize = true;
            this.lbl72120.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl72120.Location = new System.Drawing.Point(339, 158);
            this.lbl72120.Name = "lbl72120";
            this.lbl72120.Size = new System.Drawing.Size(274, 25);
            this.lbl72120.TabIndex = 1;
            this.lbl72120.Text = "72120-Payroll Contra Account";
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "payroll";
            this.payrollBindingSource.DataSource = this.lewdevDataSet6;
            // 
            // lewdevDataSet6
            // 
            this.lewdevDataSet6.DataSetName = "lewdevDataSet6";
            this.lewdevDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AutoGenerateColumns = false;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postingPeriodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.effectiveDateDataGridViewTextBoxColumn});
            this.dgvPayroll.DataSource = this.cHQTRACDEBITSCREDITSBindingSource;
            this.dgvPayroll.Location = new System.Drawing.Point(91, 229);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersWidth = 51;
            this.dgvPayroll.RowTemplate.Height = 24;
            this.dgvPayroll.Size = new System.Drawing.Size(695, 110);
            this.dgvPayroll.TabIndex = 2;
            // 
            // postingPeriodDataGridViewTextBoxColumn
            // 
            this.postingPeriodDataGridViewTextBoxColumn.DataPropertyName = "PostingPeriod";
            this.postingPeriodDataGridViewTextBoxColumn.HeaderText = "PostingPeriod";
            this.postingPeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postingPeriodDataGridViewTextBoxColumn.Name = "postingPeriodDataGridViewTextBoxColumn";
            this.postingPeriodDataGridViewTextBoxColumn.ReadOnly = true;
            this.postingPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // effectiveDateDataGridViewTextBoxColumn
            // 
            this.effectiveDateDataGridViewTextBoxColumn.DataPropertyName = "EffectiveDate";
            this.effectiveDateDataGridViewTextBoxColumn.HeaderText = "EffectiveDate";
            this.effectiveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effectiveDateDataGridViewTextBoxColumn.Name = "effectiveDateDataGridViewTextBoxColumn";
            this.effectiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectiveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHQTRACDEBITSCREDITSBindingSource
            // 
            this.cHQTRACDEBITSCREDITSBindingSource.DataMember = "CHQTRACDEBITSCREDITS";
            this.cHQTRACDEBITSCREDITSBindingSource.DataSource = this.lewdevDataSet9;
            // 
            // lewdevDataSet9
            // 
            this.lewdevDataSet9.DataSetName = "lewdevDataSet9";
            this.lewdevDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lewdevDataSet7
            // 
            this.lewdevDataSet7.DataSetName = "lewdevDataSet7";
            this.lewdevDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollBindingSource1
            // 
            this.payrollBindingSource1.DataMember = "payroll";
            this.payrollBindingSource1.DataSource = this.lewdevDataSet7;
            // 
            // payrollTableAdapter1
            // 
            this.payrollTableAdapter1.ClearBeforeFill = true;
            // 
            // lewdevDataSet8
            // 
            this.lewdevDataSet8.DataSetName = "lewdevDataSet8";
            this.lewdevDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollBindingSource2
            // 
            this.payrollBindingSource2.DataMember = "payroll";
            this.payrollBindingSource2.DataSource = this.lewdevDataSet8;
            // 
            // payrollTableAdapter2
            // 
            this.payrollTableAdapter2.ClearBeforeFill = true;
            // 
            // cHQTRACDEBITSCREDITSTableAdapter
            // 
            this.cHQTRACDEBITSCREDITSTableAdapter.ClearBeforeFill = true;
            // 
            // ReallocateAP72120Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 456);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.lbl72120);
            this.Controls.Add(this.pnlReallocateReport);
            this.Name = "ReallocateAP72120Form";
            this.Text = "ReallocateAP72120Form";
            this.Load += new System.EventHandler(this.ReallocateAP72120Form_Load);
            this.pnlReallocateReport.ResumeLayout(false);
            this.pnlReallocateReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACDEBITSCREDITSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReallocateReport;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtDateChange;
        private System.Windows.Forms.Label lblDateChange;
        private System.Windows.Forms.Label lbl72120;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private lewdevDataSet6 lewdevDataSet6;
        private lewdevDataSet6TableAdapters.payrollTableAdapter payrollTableAdapter;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private lewdevDataSet7 lewdevDataSet7;
        private System.Windows.Forms.BindingSource payrollBindingSource1;
        private lewdevDataSet7TableAdapters.payrollTableAdapter payrollTableAdapter1;
        private lewdevDataSet8 lewdevDataSet8;
        private System.Windows.Forms.BindingSource payrollBindingSource2;
        private lewdevDataSet8TableAdapters.payrollTableAdapter payrollTableAdapter2;
        private lewdevDataSet9 lewdevDataSet9;
        private System.Windows.Forms.BindingSource cHQTRACDEBITSCREDITSBindingSource;
        private lewdevDataSet9TableAdapters.CHQTRACDEBITSCREDITSTableAdapter cHQTRACDEBITSCREDITSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postingPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveDateDataGridViewTextBoxColumn;
    }
}