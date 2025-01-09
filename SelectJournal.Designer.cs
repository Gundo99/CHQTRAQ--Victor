
namespace ChequeTrackerDemo
{
    partial class SelectJournal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSelectJournal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lewdevDataSet1 = new ChequeTrackerDemo.lewdevDataSet1();
            this.cHQTRACJOURNALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHQTRACJOURNALTableAdapter = new ChequeTrackerDemo.lewdevDataSet1TableAdapters.CHQTRACJOURNALTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACJOURNALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(276, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 210);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(384, 74);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.lblSelectJournal);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 100);
            this.panel2.TabIndex = 0;
            // 
            // lblSelectJournal
            // 
            this.lblSelectJournal.AutoSize = true;
            this.lblSelectJournal.Location = new System.Drawing.Point(13, 18);
            this.lblSelectJournal.Name = "lblSelectJournal";
            this.lblSelectJournal.Size = new System.Drawing.Size(206, 17);
            this.lblSelectJournal.TabIndex = 1;
            this.lblSelectJournal.Text = "Select the Journal Number:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // lewdevDataSet1
            // 
            this.lewdevDataSet1.DataSetName = "lewdevDataSet1";
            this.lewdevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHQTRACJOURNALBindingSource
            // 
            this.cHQTRACJOURNALBindingSource.DataMember = "CHQTRACJOURNAL";
            this.cHQTRACJOURNALBindingSource.DataSource = this.lewdevDataSet1;
            // 
            // cHQTRACJOURNALTableAdapter
            // 
            this.cHQTRACJOURNALTableAdapter.ClearBeforeFill = true;
            // 
            // SelectJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 533);
            this.Controls.Add(this.panel1);
            this.Name = "SelectJournal";
            this.Text = "SelectJournal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lewdevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHQTRACJOURNALBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectJournal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancel;
        private lewdevDataSet1 lewdevDataSet1;
        private System.Windows.Forms.BindingSource cHQTRACJOURNALBindingSource;
        private lewdevDataSet1TableAdapters.CHQTRACJOURNALTableAdapter cHQTRACJOURNALTableAdapter;
    }
}