using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HomeworkTracker.FileIO;
using HomeworkTracker.View.Summary;
using TrackerControlLibrary;

namespace HomeworkTracker
{
    /// <inheritdoc />
    /// <summary>
    ///     Holds multiple tabs of HomeworkUserControls in order to keep track of multiple classes and their tasks.
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Form" />
    public partial class HomeworkTrackerForm : Form
    {
        #region Data members

        /// <summary>
        ///     The color used to signal high priority.
        /// </summary>
        public static readonly Color HighPriorityColor = Color.Red;

        /// <summary>
        ///     The color used to signal medium priority.
        /// </summary>
        public static readonly Color MediumPriorityColor = Color.Yellow;

        private const int SelectedOffset = -2;
        private const int NotSelectedOffset = 1;
        private readonly SummaryOutputFormatter outputFormatter;
        private const string XmlFilename = "Temp";

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:HomeworkTracker.HomeworkTrackerForm" /> class.
        /// </summary>
        public HomeworkTrackerForm()
        {

            this.InitializeComponent();

            this.homeworkUserControlTab1.DataChanged += this.updateDisplay;
            this.homeworkUserControlTab2.DataChanged += this.updateDisplay;
            this.homeworkUserControlTab3.DataChanged += this.updateDisplay;

            this.homeworkUserControlTab1.AddIncompleteTask("Get an A maybe.");
            this.homeworkUserControlTab2.AddIncompleteTask("Avoid this until last semester.");
            this.homeworkUserControlTab3.AddIncompleteTask("Do not forget online homework.");

            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += this.drawOnTabs;

            this.outputFormatter = new SummaryOutputFormatter(this.tabControl);

            this.updateDisplay();
        }

        #endregion

        #region Methods

        private void drawOnTabs(object sender, DrawItemEventArgs e)
        {
            var page = this.tabControl.TabPages[e.Index];
            var col = this.getPageColor(page);
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            var paddedBounds = e.Bounds;
            var yOffset = e.State == DrawItemState.Selected ? SelectedOffset : NotSelectedOffset;
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

            if (priority == (int) HomeworkUserControl.PriorityLevel.High)
            {
                pageColor = HighPriorityColor;
            }
            else if (priority == (int) HomeworkUserControl.PriorityLevel.Medium)
            {
                pageColor = MediumPriorityColor;
            }
            else
            {
                pageColor = this.tabControl.BackColor;
            }

            return pageColor;
        }

        private void updateDisplay()
        {
            this.tabControl.Invalidate();
            this.summaryDisplayTextBox.Text = this.outputFormatter.BuildSummary();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlSerializer.SerializeTabControlToXml(XmlFilename, this.tabControl);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlSerializer.DeserializeXmlFileToTabControl(XmlFilename, this.tabControl);
            this.updateDisplay();
        }

        #endregion
    }
}