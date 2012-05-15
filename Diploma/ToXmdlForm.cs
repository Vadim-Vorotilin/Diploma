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
    public partial class ToXmdlForm : Form
    {
        public ToXmdlForm()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ToXmdlForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.vRP_Accounting_DB_DataSet.VEHICLE);
            // TODO: This line of code loads data into the 'vRP_Accounting_DB_DataSet.DEPOT' table. You can move, or remove it, as needed.
            this.dEPOTTableAdapter.Fill(this.vRP_Accounting_DB_DataSet.DEPOT);

        }
    }
}
