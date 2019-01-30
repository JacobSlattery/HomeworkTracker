namespace TrackerControlLibrary
{
    partial class HomeworkUserControl
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.GridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckboxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
            this.radioButtonLow.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.radioButtonMedium.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(7, 22);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(58, 21);
            this.radioButtonHigh.TabIndex = 0;
            this.radioButtonHigh.Tag = "";
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            this.radioButtonHigh.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckboxColumn,
            this.TaskColumn});
            this.DataGridView.ContextMenuStrip = this.GridContextMenuStrip;
            this.DataGridView.Location = new System.Drawing.Point(116, 6);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(545, 339);
            this.DataGridView.TabIndex = 1;
            this.DataGridView.Tag = "";
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.DataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            this.DataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
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
            // CheckboxColumn
            // 
            this.CheckboxColumn.FalseValue = "false";
            this.CheckboxColumn.FillWeight = 50F;
            this.CheckboxColumn.HeaderText = "Done";
            this.CheckboxColumn.IndeterminateValue = "false";
            this.CheckboxColumn.MinimumWidth = 30;
            this.CheckboxColumn.Name = "CheckboxColumn";
            this.CheckboxColumn.TrueValue = "true";
            this.CheckboxColumn.Width = 50;
            // 
            // TaskColumn
            // 
            this.TaskColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskColumn.HeaderText = "Task";
            this.TaskColumn.Name = "TaskColumn";
            // 
            // HomeworkUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.PriorityGroupBox);
            this.Name = "HomeworkUserControl";
            this.Size = new System.Drawing.Size(666, 348);
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.GridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ContextMenuStrip GridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckboxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskColumn;
    }
}
