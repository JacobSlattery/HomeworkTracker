using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerControlLibrary;

namespace HomeworkTracker.View
{
    class SummaryOutputFormatter
    {

        private StringBuilder stringBuilder;
        private readonly ICollection<HomeworkUserControl> userControlCollection;
        private readonly TabControl tabControl;

        public SummaryOutputFormatter(TabControl tabControl)
        {
            this.tabControl = tabControl;
            this.stringBuilder = new StringBuilder();
            this.userControlCollection = this.getHomeworkTrackerControls();
        }


        public string BuildSummary()
        {
            var values = Enum.GetValues(typeof(HomeworkUserControl.PriorityLevel)).Cast<int>().Reverse();
            this.stringBuilder = new StringBuilder();
            foreach (var value in values)
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



        private void formatSummaryForOnePriorityLevel(int priorityLevel)
        {
            var controls = this.userControlCollection.Where(x => x.Priority == priorityLevel).ToList();
            if (controls.Any())
            {
                var taskBuilder = new StringBuilder();
                foreach (var current in controls)
                {
                    var className = this.GetNameFor(current);
                    var unfinishedTasks = current.GetUnfinishedTasks();
                    if (unfinishedTasks.Length > 0)
                    {
                        taskBuilder.Append($"Class: {className}" + Environment.NewLine);
                        taskBuilder.Append(unfinishedTasks);
                        taskBuilder.AppendLine();
                    }
                }

                if (taskBuilder.Length > 0)
                {
                    string priority;
                    switch (priorityLevel)
                    {
                        case (int)HomeworkUserControl.PriorityLevel.High:
                            priority = "High";
                            break;
                        case (int)HomeworkUserControl.PriorityLevel.Medium:
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
        }

    }
}
