using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerControlLibrary;

namespace HomeworkTracker.FileIO
{
    public class DataTransferObject
    {
        public List<List<string>> TabTasks;

        public DataTransferObject()
        {
            this.TabTasks = new List<List<string>>();
        }

        public void Contain(TabControl tabControl)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                var incompleteTasks = tab.Controls.OfType<HomeworkUserControl>().First().IncompleteTasks;
                this.TabTasks.Add(incompleteTasks);
            }
        }

        public void Update(TabControl tabControl)
        {
            for (var i = 0; i < tabControl.TabPages.Count; i++)
            {
                var control = tabControl.TabPages[i].Controls.OfType<HomeworkUserControl>().First();
                control.ClearRows();
                foreach (var task in this.TabTasks[i])
                {
                    control.AddRow(task);
                }
            }
        }
    }
}
