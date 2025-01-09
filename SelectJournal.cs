using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChequeTrackerDemo
{
    public partial class SelectJournal : Form
    {
        public event EventHandler<string> JournalNumberSelected;
        public ComboBox comboBox;
        private string SelectedJournalNumber;

        private string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True";

        public SelectJournal()
        {
            InitializeComponent();
            comboBox = comboBox1;
            LoadJournalNumbers();
        }

        private void LoadJournalNumbers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT JournalNumber FROM CHQTRACJOURNAL ORDER BY JournalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader["JournalNumber"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading journal numbers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                SelectedJournalNumber = comboBox1.SelectedItem.ToString();
                JournalNumberSelected?.Invoke(this, SelectedJournalNumber); 

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a journal number before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectJournal_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=VHUTALI;Initial Catalog=lewdev;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT JournalNumber FROM CHQTRACJOURNAL";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["JournalNumber"]);
                    }

                    reader.Close();
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading journal numbers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a journal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedJournalNumber = comboBox.SelectedItem.ToString();

            JournalNumberSelected?.Invoke(this, SelectedJournalNumber);
            this.Close();
        }

    }
}