using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrackerControlLibrary;

namespace HomeworkTracker.View.Summary
{
    /// <summary>
    ///     Formats the output summary page from the TabControl
    /// </summary>
    internal class SummaryOutputFormatter
    {
        #region Data members

        private StringBuilder stringBuilder;
        private readonly ICollection<HomeworkUserControl> userControlCollection;
        private readonly TabControl tabControl;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SummaryOutputFormatter"/> class.
        /// </summary>
        /// <param name="tabControl">The tab control.</param>
        public SummaryOutputFormatter(TabControl tabControl)
        {
            this.tabControl = tabControl;
            this.stringBuilder = new StringBuilder();
            this.userControlCollection = this.getHomeworkTrackerControls();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Builds the summary for the TabControl by organizing based on priority level.
        /// </summary>
        /// <returns>
        ///     The summary
        /// </returns>
        public string BuildSummary()
        {
            var priorityLevels = Enum.GetValues(typeof(HomeworkUserControl.PriorityLevel)).Cast<int>().Reverse();
            this.stringBuilder = new StringBuilder();
            foreach (var value in priorityLevels)
            {
                this.formatSummaryForOnePriorityLevel(value);
            }

            return this.stringBuilder.ToString();
        }

        private ICollection<HomeworkUserControl> getHomeworkTrackerControls()
        {
            var collection = new Collection<HomeworkUserControl>();
            foreach (TabPage tabPage in this.tabControl.TabPages)
            {
                collection.Add(tabPage.Controls.OfType<HomeworkUserControl>().First());
            }

            return collection;
        }

        public string GetNameFor(HomeworkUserControl homeworkUserControl)
        {
            var name = "";
            foreach (TabPage tabControlTabPage in this.tabControl.TabPages)
            {
                if (tabControlTabPage.Contains(homeworkUserControl))
                {
                    name = tabControlTabPage.Text;
                }
            }

            return name;
        }

        private static void addHeader(StringBuilder builder, string priority)
        {
            builder.Append($"{priority} Priority Class(es):" + Environment.NewLine);
            builder.Append("------------------------" + Environment.NewLine);
        }

        private static string formatIncompleteTasks(IEnumerable<string> list)
        {
            var stringBuilder = new StringBuilder();
            foreach (var task in list)
            {
                stringBuilder.AppendLine(task);
            }

            return stringBuilder.ToString();
        }

        private void formatSummaryForOnePriorityLevel(int priorityLevel)
        {
            var controls = this.userControlCollection.Where(x => x.Priority == priorityLevel).ToList();
            if (controls.Any())
            {
                var taskBuilder = new StringBuilder();
                this.buildSingleClassPotentialReport(controls, taskBuilder);
                this.finalizeReportIfNotEmpty(priorityLevel, taskBuilder);
            }
        }

        private void buildSingleClassPotentialReport(IEnumerable<HomeworkUserControl> controls, StringBuilder taskBuilder)
        {
            foreach (var current in controls)
            {
                var className = this.GetNameFor(current);
                var unfinishedTasks = formatIncompleteTasks(current.GetIncompleteTasks());
                if (unfinishedTasks.Length > 0)
                {
                    taskBuilder.Append($"Class: {className}" + Environment.NewLine);
                    taskBuilder.Append(unfinishedTasks);
                    taskBuilder.AppendLine();
                }
            }
        }

        private void finalizeReportIfNotEmpty(int priorityLevel, StringBuilder taskBuilder)
        {
            if (taskBuilder.Length > 0)
            {
                string priority;
                switch (priorityLevel)
                {
                    case (int) HomeworkUserControl.PriorityLevel.High:
                        priority = "High";
                        break;
                    case (int) HomeworkUserControl.PriorityLevel.Medium:
                        priority = "Medium";
                        break;
                    default:
                        priority = "Low";
                        break;
                }

                addHeader(this.stringBuilder, priority);
                this.stringBuilder.Append(taskBuilder);
            }
        }

        #endregion
    }
}