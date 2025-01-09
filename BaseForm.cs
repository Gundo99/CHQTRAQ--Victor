using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChequeTrackerDemo
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void createJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CreateJournalForm createJournalForm = new CreateJournalForm();
            createJournalForm.TopLevel = false;
            createJournalForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(createJournalForm);
            createJournalForm.Show();        
        }

        private void amendViewJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AmendViewJournal amendViewJournal = new AmendViewJournal();
            amendViewJournal.TopLevel = false;
            amendViewJournal.Dock = DockStyle.Fill;
            panel1.Controls.Add(amendViewJournal);
            amendViewJournal.Show();
        }

        private void selectAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SelectAccountMaintain selectAccountMaintain = new SelectAccountMaintain();
            selectAccountMaintain.TopLevel = false;
            selectAccountMaintain.Dock = DockStyle.Fill;
            panel1.Controls.Add(selectAccountMaintain);
            selectAccountMaintain.Show();
        }

        private void maintainAccountCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MaintainAccountCodesForm maintainAccountCodesForm = new MaintainAccountCodesForm();
            maintainAccountCodesForm.TopLevel = false;
            maintainAccountCodesForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(maintainAccountCodesForm);
            maintainAccountCodesForm.Show();
        }

        private void maintainChequeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MaintainChequeNoForm maintainChequeNoForm = new MaintainChequeNoForm();
            maintainChequeNoForm.TopLevel = false;
            maintainChequeNoForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(maintainChequeNoForm);
            maintainChequeNoForm.Show();
        }

        private void insertYearEndEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            InsertYearEndEntriesForm insertYearEndEntriesForm = new InsertYearEndEntriesForm();
            insertYearEndEntriesForm.TopLevel = false;
            insertYearEndEntriesForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(insertYearEndEntriesForm);
            insertYearEndEntriesForm.Show();
        }

        private void smartStreamImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SmartStreamImportForm smartStreamImportForm = new SmartStreamImportForm();
            smartStreamImportForm.TopLevel = false;
            smartStreamImportForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(smartStreamImportForm);
            smartStreamImportForm.Show();
        }

        private void reallocateAgeingPeriodFo72120ChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ReallocateAP72120Form reallocateAP72120Form = new ReallocateAP72120Form();
            reallocateAP72120Form.TopLevel = false;
            reallocateAP72120Form.Dock = DockStyle.Fill;
            panel1.Controls.Add(reallocateAP72120Form);
            reallocateAP72120Form.Show();
        }

        private void manuallyMatchedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManuallyMatchedForm manuallyMatchedForm = new ManuallyMatchedForm();
            manuallyMatchedForm.Show();
            this.Hide();
        }

        private void automaticallyMatchedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomaticallyMatchedForm automaticallyMatchedForm = new AutomaticallyMatchedForm();
            automaticallyMatchedForm.Show();
            this.Hide();
        }

        private void creditsItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditItemsForm creditItemsForm = new CreditItemsForm();
            creditItemsForm.Show();
            this.Hide();
        }

        private void debitItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebitItems debitItems = new DebitItems();
            debitItems.Show();
            this.Hide();
        }

        private void debitsCreditsItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebitsCreditsItemsForm debitsCreditsItemsForm = new DebitsCreditsItemsForm();
            debitsCreditsItemsForm.Show();
            this.Hide();
        }

        private void detailAgeingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailAgeingReportForm detailAgeingReportForm = new DetailAgeingReportForm();
            detailAgeingReportForm.Show();
            this.Hide();
        }

        private void summaryAgeingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryAgeingReportForm summaryAgeingReportForm = new SummaryAgeingReportForm();
            summaryAgeingReportForm.Show();
            this.Hide();
                
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CreateJournalForm createJournalForm = new CreateJournalForm();
            createJournalForm.TopLevel = false;
            createJournalForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(createJournalForm);
            createJournalForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AmendJournalForm amendJournalForm = new AmendJournalForm();
            amendJournalForm.TopLevel = false;
            amendJournalForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(amendJournalForm);
            amendJournalForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tslShortcuts_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
