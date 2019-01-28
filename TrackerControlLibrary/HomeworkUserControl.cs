using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrackerControlLibrary
{
    public partial class HomeworkUserControl : UserControl
    {
        #region Types and Delegates


        public List<string> IncompleteTasks
        {
            get
            {
                var list = new List<string>();
                for (var i = 0; i < this.DataGridView.Rows.Count - 1; i++)
                {
                    var textCell = (DataGridViewTextBoxCell)this.DataGridView.Rows[i].Cells[1];
                    var checkCell = (DataGridViewCheckBoxCell)this.DataGridView.Rows[i].Cells[0];
                    if (textCell.Value != null && checkCell.Value != checkCell.TrueValue)
                    {
                        list.Add(textCell.Value.ToString());
                    }
                }

                return list;
            }
        }
        public enum PriorityLevel
        {
            Low = 0,
            Medium = 1,
            High = 2
        }

        public delegate void DataChangedHandler();

        #endregion

        #region Data members


        #endregion

        #region Properties

        public int Priority => (int)this.PriorityGroupBox.Controls.OfType<RadioButton>().First(x => x.Checked).Tag;

        #endregion

        #region Constructors

        public HomeworkUserControl()
        {
            this.InitializeComponent();

            this.radioButtonHigh.Checked = false;
            this.radioButtonMedium.Checked = false;
            this.radioButtonLow.Checked = true;

            this.radioButtonHigh.Tag = PriorityLevel.High;
            this.radioButtonMedium.Tag = PriorityLevel.Medium;
            this.radioButtonLow.Tag = PriorityLevel.Low;
        }

        #endregion

        #region Methods

        public event DataChangedHandler DataChanged;

        public string GetUnfinishedTasks()
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < this.DataGridView.Rows.Count - 1; i++)
            {
                var textCell = (DataGridViewTextBoxCell) this.DataGridView.Rows[i].Cells[1];
                var checkCell = (DataGridViewCheckBoxCell) this.DataGridView.Rows[i].Cells[0];
                if (textCell.Value != null && checkCell.Value != checkCell.TrueValue)
                {
                    stringBuilder.AppendLine(textCell.Value.ToString());
                }
            }

            return stringBuilder.ToString();
        }

        public void AddRow(string task)
        {
            this.DataGridView.Rows.Add(false, task);
        }

        public void ClearRows()
        {
            this.DataGridView.Rows.Clear();
        }

        private void onDataChanged()
        {
            var updatedData = this.GetUnfinishedTasks();
            this.DataChanged?.Invoke();
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                ContextMenuStrip = new ContextMenuStrip();
                ContextMenuStrip.Show();
            }
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.DataGridView.Rows)
            {
                var cell = (DataGridViewCheckBoxCell) row.Cells[0];
                if (cell.Value == null || cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                }
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.DataGridView.Rows)
            {
                var cell = (DataGridViewCheckBoxCell) row.Cells[0];
                if (cell.Value == null || cell.Value == cell.FalseValue)
                {
                    cell.Value = cell.TrueValue;
                }
            }
        }

        private void removeAnyEmptyCells()
        {
            for (var i = 0; i < this.DataGridView.Rows.Count - 1; i++)
            {
                var textCell = (DataGridViewTextBoxCell) this.DataGridView.Rows[i].Cells[1];
                if (textCell.Value == null || textCell.Value.ToString().Equals(string.Empty))
                {
                    this.DataGridView.Rows.RemoveAt(i);
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton button && button.Checked)
            {
                this.onDataChanged();
            }
            
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.removeAnyEmptyCells();
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.onDataChanged();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.onDataChanged();
        }

        #endregion
    }
}