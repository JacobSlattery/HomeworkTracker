using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerControlLibrary
{
    public partial class UserControl1: UserControl
    {
        private bool high;
        public bool High
        {
            get => this.high;
            set
            {
                this.high = value;
            }
        }

        public enum Priority {Low, Medium, High}

        public UserControl1()
        {
            InitializeComponent();
            this.radioButtonHigh.Checked = this.High;
            var checkedPriority = Controls.OfType<RadioButton>().First(n => n.Checked);
            Debug.Write(checkedPriority.Tag);

        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                this.ContextMenuStrip = new ContextMenuStrip();
                this.ContextMenuStrip.Show();
            }
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                var cell = (DataGridViewCheckBoxCell)row.Cells[0];
                if (cell.Value  == cell.TrueValue || cell.Value == null)
                {
                    cell.Value = cell.FalseValue;
                }
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                var cell = (DataGridViewCheckBoxCell)row.Cells[0];
                if (cell.Value  == cell.FalseValue || cell.Value == null)
                {
                    cell.Value = cell.TrueValue;
                }
            }
            
        }

    }
}
