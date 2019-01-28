using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HomeworkTracker.FileIO;
using HomeworkTracker.View;
using TrackerControlLibrary;

namespace HomeworkTracker
{
    public partial class Form1 : Form
    {
        private const int SelectedOffset = -2;
        private const int NotSelectedOffset = 1;
        private readonly SummaryOutputFormatter outputFormatter;

        public static readonly Color HighPriorityColor = Color.Red;
        public static readonly Color MediumPriorityColor = Color.Yellow;

        #region Constructors

        public Form1()
        {
            this.InitializeComponent();

            this.homeworkUserControlTab1.DataChanged += this.updateDisplay;
            this.homeworkUserControlTab2.DataChanged += this.updateDisplay;
            this.homeworkUserControlTab3.DataChanged += this.updateDisplay;

            this.homeworkUserControlTab1.AddRow("Get an A maybe.");
            this.homeworkUserControlTab2.AddRow("Avoid this until last semester.");
            this.homeworkUserControlTab3.AddRow("Do not forget online homework.");

            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += this.drawOnTabs;

            this.outputFormatter = new SummaryOutputFormatter(this.tabControl);

            this.updateDisplay();
        }

        private void drawOnTabs(object sender, DrawItemEventArgs e)
        {
            var page = this.tabControl.TabPages[e.Index];
            var col = this.getPageColor(page);
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            var paddedBounds = e.Bounds;
            var yOffset = (e.State == DrawItemState.Selected) ? SelectedOffset : NotSelectedOffset;
            paddedBounds.Offset(1, yOffset);

            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private Color getPageColor(IDisposable tabPage)
        {
            var pageColor = this.tabControl.BackColor;
            foreach (TabPage currentTabPage in this.tabControl.TabPages)
            {
                if (currentTabPage.Equals(tabPage))
                {
                    pageColor = this.colorOfPage(currentTabPage);
                }
            }
            return pageColor;
        }

        private Color colorOfPage(Control tabPage)
        {
            Color pageColor;
            var priority = tabPage.Controls.OfType<HomeworkUserControl>().First().Priority;

            if (priority == (int)HomeworkUserControl.PriorityLevel.High)
            {
                pageColor = HighPriorityColor;
            }
            else if (priority == (int)HomeworkUserControl.PriorityLevel.Medium)
            {
                pageColor = MediumPriorityColor;
            }
            else
            {
                pageColor = this.tabControl.BackColor;
            }

            return pageColor;
        }

        #endregion

        #region Methods

        private void updateDisplay()
        {
            this.tabControl.Invalidate();
            this.summaryDisplayTextBox.Text = this.outputFormatter.BuildSummary();
        }

        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer.Serialize("Test", this.tabControl);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer.Deserialize("Test", this.tabControl);
            this.updateDisplay();
        }
    }
}