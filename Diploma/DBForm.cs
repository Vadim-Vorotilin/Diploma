using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void exportToXMDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toXmdlForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private SqlCeDataAdapter depotsAdapter;
        private DataTable depotsTable;

        private void dataGridView_Depots_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_Depots.CommitEdit(DataGridViewDataErrorContexts.Commit);
            try
            {
                depotsAdapter.Update(vRP_Accounting_DB_DataSet.DEPOT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            FillData();
        }
        void FillData()
        {
            // 1
            // Open connection
            using (SqlCeConnection c = new SqlCeConnection(
                Properties.Settings.Default.VRP_Accounting_DB_ConnectionString))
            {
                c.Open();

                // 2
                // Create new DataAdapter
                depotsAdapter = new SqlCeDataAdapter("SELECT * FROM DEPOT", c);
                
                // 3
                // Use DataAdapter to fill DataTable
                //depotsTable = new DataTable();
                depotsAdapter.Fill(vRP_Accounting_DB_DataSet);

                // 4
                //// Render data onto the screen
                //dEPOTBindingSource.DataSource = depotsTable;
                //dataGridView_Depots.DataSource = dEPOTBindingSource;
            }
        }
    }
}
