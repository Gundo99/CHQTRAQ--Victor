using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChequeTrackerDemo
{
    public partial class AmendJournalForm : Form
    {
        private string currentJournalNumber = null;
        private string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True"; 

        public AmendJournalForm()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            btnSave.Enabled = false;
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
        private void AmendJournalForm_Load(object sender, EventArgs e)
        {
            UpdateCHQTRACJOURNALData(null);
        }
        private void UpdateCHQTRACJOURNALData(string journalNumber)
        {
            try
            {
                string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string storedProcedure = "TracJournal2";

                    SqlCommand command = new SqlCommand(storedProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (journalNumber != null)
                    {
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the CHQTRACJOURNAL grid views
                    this.cHQTRACDEBITSCREDITSTableAdapter1.Fill(this.lewdevDataSet5.CHQTRACDEBITSCREDITS);
             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading CHQTRACDEBITSCREDITS data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void PopulateJournalFields(string journalNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT JournalID, Amount, Reason, UserID, CreationDate, Description 
                        FROM CHQTRACJOURNAL 
                        WHERE JournalNumber = @JournalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtJrnlId.Text = reader["JournalID"].ToString();
                                txtAmount.Text = Convert.ToDecimal(reader["Amount"]).ToString("C2");
                                cmbReason.Text = reader["Reason"].ToString();
                                txtUserId.Text = reader["UserID"].ToString();
                                txtCreation.Text = Convert.ToDateTime(reader["CreationDate"]).ToShortDateString();
                                txtDescription.Text = reader["Description"].ToString();
                            }
                        }
                    }
                }

                PopulateDebitCreditFields(journalNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating journal fields: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void PopulateDebitCreditFields(string journalNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DebitItems", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                        object debitResult = command.ExecuteScalar();
                        txtDebit.Text = debitResult != DBNull.Value ? Convert.ToDecimal(debitResult).ToString("C2") : "0.00";
                    }

                    using (SqlCommand command = new SqlCommand("CreditItems", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                        object creditResult = command.ExecuteScalar();
                        txtCredit.Text = creditResult != DBNull.Value ? Convert.ToDecimal(creditResult).ToString("C2") : "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving debit/credit items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateJournalForm createJournalForm = new CreateJournalForm();
            createJournalForm.Show();
        }
        private void grpSelectedItems_Enter(object sender, EventArgs e)
        {

        }
        private void lblCreationDate_Click(object sender, EventArgs e)
        {

        }
        public TextBox txtAMount => txtAmount;
        private void txtJrnlId_TextChanged(object sender, EventArgs e)
        {

        }
        public void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public TextBox txtUserID => txtUserId;
        public void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }
        public TextBox txtCReation => txtCreation;
        public void txtCreation_TextChanged(object sender, EventArgs e)
        {

        }
        public TextBox txtDEscription => txtDescription;
        public void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool isUpdatingText = false;
        private void txtDebit_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingText) return;

            try
            {
                SelectJournal selectJournalForm = Application.OpenForms.OfType<SelectJournal>().FirstOrDefault();
                if (selectJournalForm != null && selectJournalForm.comboBox.SelectedItem != null)
                {
                    string journalNumber = selectJournalForm.comboBox.SelectedItem.ToString();
                    string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True";

                    txtDebit.Visible = true;
                    txtDebit.Enabled = true;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DebitItems", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@JournalNumber", journalNumber);

                            object result = command.ExecuteScalar();
                            if (result != DBNull.Value && result != null)
                            {
                                decimal debitAmount = Convert.ToDecimal(result);
                                isUpdatingText = true;
                                txtDebit.Text = debitAmount.ToString("C2");
                                isUpdatingText = false;
                            }
                            else
                            {
                                isUpdatingText = true;
                                txtDebit.Text = "0.00";
                                isUpdatingText = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No journal selected or form not open.");
                    txtDebit.Text = "No journal selected";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving debit items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDebit.Text = "Error";
            }
        }

        private void txtUnmatchedValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnmatchedJrnl_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessJrnl_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateInputFields()
        {
            if (!decimal.TryParse(txtAmount.Text.Replace("$", "").Replace(",", ""), out _))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbReason.Text))
            {
                MessageBox.Show("Please select a reason.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbReason.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Please enter a User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserId.Focus();
                return false;
            }

            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentJournalNumber))
            {
                MessageBox.Show("Please select a journal first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateInputFields())
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE CHQTRACJOURNAL 
                        SET Amount = @Amount, 
                            Reason = @Reason, 
                            UserID = @UserID, 
                            Description = @Description
                        WHERE JournalNumber = @JournalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JournalNumber", currentJournalNumber);
                        command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text.Replace("$", "").Replace(",", "")));
                        command.Parameters.AddWithValue("@Reason", cmbReason.Text);
                        command.Parameters.AddWithValue("@UserID", txtUserId.Text);
                        command.Parameters.AddWithValue("@Description", txtDescription.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Journal updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateCHQTRACJOURNALData(currentJournalNumber);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving journal data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void dgvSelectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataGridView DgvSelectedItems => dgvSelectedItems;

        private void grpJournal_Enter(object sender, EventArgs e)
        {

        }

        public GroupBox GrpJournal => grpJournal;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
