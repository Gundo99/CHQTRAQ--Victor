using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChequeTrackerDemo
{
    public partial class AmendViewJournal : Form
    {
        private string currentJournalNumber = null;
        private string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True";

        public AmendViewJournal()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            btnSave.Enabled = true;
            PopulateReasonComboBox();
        }

        private void PopulateReasonComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Reason FROM CHQTRACJOURNAL";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbReason.Items.Add(reader["Reason"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading reasons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateJournalFields(string journalNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE CHQTRACJOURNAL 
                SET 
                    JournalAmount = @JournalAmount, 
                    UserId = @UserId, 
                    Description = @Description 
                WHERE 
                    JournalNumber = @JournalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@JournalAmount", decimal.TryParse(txtAmount.Text, out decimal amount) ? amount : 0);
                        command.Parameters.AddWithValue("@UserId", txtUserID.Text.Trim());
                        command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Journal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No journal found with Journal Number: {journalNumber}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show($"Data format error: {formatEx.Message}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PopulateJournalFields(string journalNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT JournalNumber, JournalAmount, UserId, JournalCreationDate, Description 
                           FROM CHQTRACJOURNAL 
                           WHERE JournalNumber = @JournalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtJournalID.Text = reader["JournalNumber"]?.ToString() ?? string.Empty;

                                if (reader["JournalAmount"] != DBNull.Value)
                                    txtAmount.Text = Convert.ToDecimal(reader["JournalAmount"]).ToString("0.00");
                                else
                                    txtAmount.Text = "0.00";

                                txtUserID.Text = reader["UserId"]?.ToString() ?? string.Empty;

                                if (reader["JournalCreationDate"] != DBNull.Value)
                                    txtCreationDate.Text = Convert.ToDateTime(reader["JournalCreationDate"]).ToShortDateString();
                                else
                                    txtCreationDate.Text = string.Empty;

                                txtDescription.Text = reader["Description"]?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                MessageBox.Show($"No data found for Journal Number: {journalNumber}",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

               
                CalculateAndDisplayAmounts(journalNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AmendViewJournal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lewdevDataSet12.CHQTRACDEBITSCREDITS' table. You can move, or remove it, as needed.
            this.cHQTRACDEBITSCREDITSTableAdapter1.Fill(this.lewdevDataSet12.CHQTRACDEBITSCREDITS);
            // Load default data or skip calling the method if journalNumber is null
            if (!string.IsNullOrEmpty(currentJournalNumber))
            {
                //UpdateCHQTRACJOURNALData(currentJournalNumber);
            }
            else
            {
                // Optionally show a message or load default data
                MessageBox.Show("No journal selected. Please select a journal to view details.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void lblReason_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateJournalForm createJournalForm = new CreateJournalForm();
            createJournalForm.Show();
        }

        private void btnGetJrnl_Click(object sender, EventArgs e)
        {
            SelectJournal selectJournal = new SelectJournal();

            selectJournal.JournalNumberSelected += (s, journalNumber) =>
            {
                currentJournalNumber = journalNumber;
                PopulateJournalFields(journalNumber);
                btnSave.Enabled = true;
            };

            selectJournal.ShowDialog();
        }
        private void btnUnmatchedJrnl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentJournalNumber))
            {
                MessageBox.Show("Please select a journal first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Journal Number {currentJournalNumber}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM CHQTRACJOURNAL WHERE JournalNumber = @JournalNumber";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@JournalNumber", currentJournalNumber);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Journal Number {currentJournalNumber} deleted successfully.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Reset form and refresh data
                                ResetForm();
                            }
                            else
                            {
                                MessageBox.Show("No journal found with the specified number.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the journal: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetForm()
        {
          
            txtJournalID.Clear();
            txtAmount.Clear();
            txtUserID.Clear();
            txtCreationDate.Clear();
            txtDescription.Clear();
            
            currentJournalNumber = null;
            btnSave.Enabled = true;
        }
        private void btnProcessJrnl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentJournalNumber))
            {
                MessageBox.Show("Please select a journal first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal journalAmount;
            if (!decimal.TryParse(txtAmount.Text, out journalAmount) || journalAmount != 0)
            {
                MessageBox.Show("Only journals with zero amount can be processed.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = @"UPDATE CHQTRACJOURNAL 
                                           SET JournalAmount = 0.00, 
                                               Processed = 'Y' 
                                           WHERE JournalNumber = @JournalNumber";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@JournalNumber", currentJournalNumber);
                        command.ExecuteNonQuery();
                    }
                   
                    PopulateJournalFields(currentJournalNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the journal: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string journalNumber = txtJournalID.Text.Trim();

            if (!string.IsNullOrEmpty(journalNumber))
            {
                UpdateJournalFields(journalNumber);
            }
            else
            {
                MessageBox.Show("Please enter a valid Journal Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtJournalID.Clear();
            txtAmount.Clear();
            txtUserID.Clear();
            txtCreationDate.Clear();
            txtDescription.Clear();
            txtSelectedDebit.Clear();
            txtUnmatchedValue.Clear();
            txtSelectedCredit.Clear();
            btnProcessJrnl.Refresh();
            btnUnmatchedJrnl.Refresh();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grpJournal_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataGridView DgvSelectedItems => dgvSelectedItems;
        private void txtJournalID_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCreationDate_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvSelectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalculateAndDisplayAmounts(string journalNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT JournalAmount 
                           FROM CHQTRACJOURNAL 
                           WHERE JournalNumber = @JournalNumber";

                    decimal totalDebit = 0;
                    decimal totalCredit = 0;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal journalAmount = Convert.ToDecimal(reader["JournalAmount"]);

                                if (journalAmount > 0)
                                {
                                    totalDebit += journalAmount;
                                }
                                else
                                {
                                    totalCredit += journalAmount;
                                }
                            }
                        }
                    }

                    txtSelectedDebit.Text = totalDebit.ToString("N2");
                    txtSelectedCredit.Text = totalCredit.ToString("N2");
                    txtUnmatchedValue.Text = (totalDebit + totalCredit).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating amounts: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSelectedDebit_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSelectedCredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnmatchedValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}