﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void saveReportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich text files|*.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox_Report.SaveFile(saveFileDialog.FileName);
                }
            }
        }
    }
}
