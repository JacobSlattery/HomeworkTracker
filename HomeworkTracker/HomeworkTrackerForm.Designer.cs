namespace HomeworkTracker
{
    partial class HomeworkTrackerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.homeworkUserControlTab1 = new TrackerControlLibrary.HomeworkUserControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.homeworkUserControlTab2 = new TrackerControlLibrary.HomeworkUserControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.homeworkUserControlTab3 = new TrackerControlLibrary.HomeworkUserControl();
            this.summaryDisplayTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(684, 388);
            this.tabControl.TabIndex = 1;
            this.tabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.homeworkUserControlTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
            this.tabPage1.Text = "CS 3202";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // homeworkUserControlTab1
            // 
            this.homeworkUserControlTab1.Location = new System.Drawing.Point(6, 6);
            this.homeworkUserControlTab1.Name = "homeworkUserControlTab1";
            this.homeworkUserControlTab1.Size = new System.Drawing.Size(668, 352);
            this.homeworkUserControlTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.homeworkUserControlTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "";
            this.tabPage2.Text = "Engl 3405";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // homeworkUserControlTab2
            // 
            this.homeworkUserControlTab2.Location = new System.Drawing.Point(6, 6);
            this.homeworkUserControlTab2.Name = "homeworkUserControlTab2";
            this.homeworkUserControlTab2.Size = new System.Drawing.Size(666, 348);
            this.homeworkUserControlTab2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.homeworkUserControlTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(676, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hist 2100";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // homeworkUserControlTab3
            // 
            this.homeworkUserControlTab3.Location = new System.Drawing.Point(6, 6);
            this.homeworkUserControlTab3.Name = "homeworkUserControlTab3";
            this.homeworkUserControlTab3.Size = new System.Drawing.Size(666, 348);
            this.homeworkUserControlTab3.TabIndex = 1;
            // 
            // summaryDisplayTextBox
            // 
            this.summaryDisplayTextBox.Location = new System.Drawing.Point(12, 442);
            this.summaryDisplayTextBox.Multiline = true;
            this.summaryDisplayTextBox.Name = "summaryDisplayTextBox";
            this.summaryDisplayTextBox.ReadOnly = true;
            this.summaryDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.summaryDisplayTextBox.Size = new System.Drawing.Size(684, 304);
            this.summaryDisplayTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.fileToolStripMenuItem.Text = "&Tasks";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tasks to complete:";
            // 
            // HomeworkTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summaryDisplayTextBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeworkTrackerForm";
            this.Text = "Homework Tracker by Jacob Slattery";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrackerControlLibrary.HomeworkUserControl homeworkUserControlTab1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox summaryDisplayTextBox;
        private TrackerControlLibrary.HomeworkUserControl homeworkUserControlTab2;
        private System.Windows.Forms.TabPage tabPage3;
        private TrackerControlLibrary.HomeworkUserControl homeworkUserControlTab3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

