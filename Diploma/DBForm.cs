using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Diploma
{
    public partial class DBForm : Form
    {
        private ToXmdlForm toXmdlForm;

        public DBForm()
        {
            InitializeComponent();

            toXmdlForm = new ToXmdlForm {Visible = false};

            if ((new LoginForm()).ShowDialog() == DialogResult.OK)
            {
                CloseMe = false;
            }
            else
            {
                CloseMe = true;
            }
        }

        public bool CloseMe { get; private set; }

        private void exportToXMDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toXmdlForm.ShowDialog() == DialogResult.OK)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Model|*.xmdl";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_Depots_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_Depots.CommitEdit(DataGridViewDataErrorContexts.Commit);
            this.dISTANCE_DEPOT_CONSUMERTableAdapter.Update(this.vRP_Accounting_DB_DataSet.DISTANCE_DEPOT_CONSUMER);
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.DISTANCE_DEPOT_CONSUMER' table. You can move, or remove it, as needed.
            this.dISTANCE_DEPOT_CONSUMERTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.DISTANCE_DEPOT_CONSUMER);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.DISTANCE_CONSUMERS' table. You can move, or remove it, as needed.
            this.dISTANCE_CONSUMERSTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.DISTANCE_CONSUMERS);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.vRP_Accounting_DB_DataSet.VEHICLE);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.CONSUMER' table. You can move, or remove it, as needed.
            this.cONSUMERTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.CONSUMER);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.DEPOT' table. You can move, or remove it, as needed.
            this.dEPOTTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.DEPOT);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.DEPOT' table. You can move, or remove it, as needed.
            this.dEPOTTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.DEPOT);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.DEPOT' table. You can move, or remove it, as needed.
            this.dEPOTTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.DEPOT);

        }

        private void solveTheProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toXmdlForm.ShowDialog() == DialogResult.OK)
            {
                (new GraphForm()).ShowDialog();
            }
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(DBForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void UncheckLanguages()
        {
            englishToolStripMenuItem.Checked = false;
            ukrainianToolStripMenuItem.Checked = false;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckLanguages();
            englishToolStripMenuItem.Checked = true;

            ChangeLanguage("en");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckLanguages();
            ukrainianToolStripMenuItem.Checked = true;

            ChangeLanguage("uk");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk");
        }
    }
}
