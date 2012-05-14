using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void dataGridView_Depots_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_Depots.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
