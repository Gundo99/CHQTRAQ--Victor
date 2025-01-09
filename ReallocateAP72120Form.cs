using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace ChequeTrackerDemo
{
    public partial class ReallocateAP72120Form : Form
    {
        private string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True";
        private DataTable originalData;

        public ReallocateAP72120Form()
        {
            InitializeComponent();
            LoadData();
           
        }

        private void DiagnoseColumns(object sender, DataGridViewBindingCompleteEventArgs e)
        {
      
            string columnNames = string.Join(", ",
                dgvPayroll.Columns.Cast<DataGridViewColumn>().Select(col => col.Name));

            MessageBox.Show($"Columns in DataGridView: {columnNames}",
                "Column Diagnostic", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadData()
{
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            PostingPeriod, 
                            Description, 
                            Amount, 
                            EffectiveDate 
                        FROM 
                            CHQTRACDEBITSCREDITS";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    originalData = new DataTable();
                    adapter.Fill(originalData);

                    dgvPayroll.DataSource = originalData;
                    ConfigureDataGridViewColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDataGridViewColumns()
        {
  
            var columnMapping = new Dictionary<string, string>
            {
                {"postingPeriodDataGridViewTextBoxColumn", "PostingPeriod"},
                {"descriptionDataGridViewTextBoxColumn", "Description"},
                {"amountDataGridViewTextBoxColumn", "Amount"},
                {"effectiveDateGridViewTextBoxColumn", "EffectiveDate"}
            };

            foreach (DataGridViewColumn col in dgvPayroll.Columns)
            {
                col.ReadOnly = true;

                if (col.Name == "postingPeriodDataGridViewTextBoxColumn")
                    col.HeaderText = "Posting Period";
                else if (col.Name == "amountDataGridViewTextBoxColumn")
                {
                    col.HeaderText = "Amount";
                    col.DefaultCellStyle.Format = "C2";
                }
                else if (col.Name == "effectiveDateGridViewTextBoxColumn")
                {
                    col.HeaderText = "Effective Date";
                    col.DefaultCellStyle.Format = "d";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvPayroll.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to update.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParse(txtDateChange.Text, out DateTime newDate))
                {
                    MessageBox.Show("Please enter a valid date.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                var postingPeriodColumn = dgvPayroll.Columns["postingPeriodDataGridViewTextBoxColumn"];

                if (postingPeriodColumn == null)
                {
                    MessageBox.Show("PostingPeriod column not found!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            
                var postingPeriod = dgvPayroll.CurrentRow.Cells[postingPeriodColumn.Index].Value?.ToString();

                if (string.IsNullOrEmpty(postingPeriod))
                {
                    MessageBox.Show("Invalid Posting Period.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateEffectiveDate(postingPeriod, newDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Save: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEffectiveDate(string postingPeriod, DateTime newDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        UPDATE CHQTRACDEBITSCREDITS
                        SET EffectiveDate = @NewEffectiveDate
                        WHERE PostingPeriod = @PostingPeriod";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PostingPeriod", postingPeriod);
                        cmd.Parameters.AddWithValue("@NewEffectiveDate", newDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Date updated successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReallocateAP72120Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lewdevDataSet9.CHQTRACDEBITSCREDITS' table. You can move, or remove it, as needed.
            this.cHQTRACDEBITSCREDITSTableAdapter.Fill(this.lewdevDataSet9.CHQTRACDEBITSCREDITS);

        }
        private void dgvPayroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvPayroll.Rows[e.RowIndex];

                   
                    var effectiveDateColumn = dgvPayroll.Columns["effectiveDateGridViewTextBoxColumn"];

                    if (effectiveDateColumn == null)
                    {
                        MessageBox.Show("EffectiveDate column not found!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var effectiveDateValue = selectedRow.Cells[effectiveDateColumn.Index].Value;

                    if (effectiveDateValue != DBNull.Value)
                    {
                        txtDateChange.Text = Convert.ToDateTime(effectiveDateValue).ToShortDateString();
                    }
                    else
                    {
                        txtDateChange.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in CellClick: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void txtDateChange_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
