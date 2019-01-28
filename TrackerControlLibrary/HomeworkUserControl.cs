using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrackerControlLibrary
{
    /// <inheritdoc />
    /// <summary>
    ///     UserControl which holds a priority box and a data grid of complete and incomplete tasks.
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.UserControl" />
    public partial class HomeworkUserControl : UserControl
    {
        #region Types and Delegates

        /// <summary>
        ///     The Priority Levels.
        /// </summary>
        public enum PriorityLevel
        {
            Low = 0,
            Medium = 1,
            High = 2
        }

        /// <summary>
        ///     The delegate for when visual data has changed.
        /// </summary>
        public delegate void DataChangedHandler();

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the priority.
        /// </summary>
        /// <value>
        ///     The priority.
        /// </value>
        public int Priority => (int) this.PriorityGroupBox.Controls.OfType<RadioButton>().First(x => x.Checked).Tag;

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:TrackerControlLibrary.HomeworkUserControl" /> class.
        /// </summary>
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

        /// <summary>
        ///     Gets the incomplete tasks.
        /// </summary>
        /// <returns>
        ///     A list of tasks as strings.
        /// </returns>
        public List<string> GetIncompleteTasks()
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

        /// <summary>
        ///     Adds an incomplete task as a new row.
        /// </summary>
        /// <param name="task">The task.</param>
        public void AddIncompleteTask(string task)
        {
            this.DataGridView.Rows.Add(false, task);
        }

        /// <summary>
        ///     Clears the rows of all tasks.
        /// </summary>
        public void ClearRows()
        {
            Select();
            this.DataGridView.Rows.Clear();
        }

        private void onDataChanged()
        {
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