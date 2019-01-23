namespace TrackerControlLibrary
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckboxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriorityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GridContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.Controls.Add(this.radioButtonLow);
            this.PriorityGroupBox.Controls.Add(this.radioButtonMedium);
            this.PriorityGroupBox.Controls.Add(this.radioButtonHigh);
            this.PriorityGroupBox.Location = new System.Drawing.Point(7, 6);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Size = new System.Drawing.Size(103, 118);
            this.PriorityGroupBox.TabIndex = 0;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Tag = "PriorityTag";
            this.PriorityGroupBox.Text = "Priority";
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Location = new System.Drawing.Point(7, 78);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(54, 21);
            this.radioButtonLow.TabIndex = 2;
            this.radioButtonLow.Tag = "\"Low\"";
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Checked = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(7, 50);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(78, 21);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Tag = "\"Medium\"";
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(7, 22);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(58, 21);
            this.radioButtonHigh.TabIndex = 0;
            this.radioButtonHigh.Tag = "\"High\"";
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckboxColumn,
            this.TaskColumn});
            this.dataGridView1.ContextMenuStrip = this.GridContextMenuStrip;
            this.dataGridView1.Location = new System.Drawing.Point(116, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 293);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Tag = "";
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // CheckboxColumn
            // 
            this.CheckboxColumn.FalseValue = "False";
            this.CheckboxColumn.FillWeight = 50F;
            this.CheckboxColumn.HeaderText = "Done";
            this.CheckboxColumn.IndeterminateValue = "False";
            this.CheckboxColumn.MinimumWidth = 30;
            this.CheckboxColumn.Name = "CheckboxColumn";
            this.CheckboxColumn.TrueValue = "True";
            this.CheckboxColumn.Width = 50;
            // 
            // TaskColumn
            // 
            this.TaskColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskColumn.HeaderText = "Task";
            this.TaskColumn.Name = "TaskColumn";
            // 
            // GridContextMenuStrip
            // 
            this.GridContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem});
            this.GridContextMenuStrip.Name = "GridContextMenuStrip";
            this.GridContextMenuStrip.Size = new System.Drawing.Size(156, 52);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck All";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PriorityGroupBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(668, 305);
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckboxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskColumn;
        private System.Windows.Forms.ContextMenuStrip GridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
    }
}
