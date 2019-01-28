using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrackerControlLibrary;

namespace HomeworkTracker.FileIO
{
    /// <summary>
    ///     Used as a means of transferring the contents of the TabControl to and from an xml file.
    /// </summary>
    public class TabControlTransferObject
    {
        #region Data members

        /// <summary>
        ///     A list containing each list of tasks in the TabControl
        /// </summary>
        public List<List<string>> TabTasks;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TabControlTransferObject" /> class.
        /// </summary>
        public TabControlTransferObject()
        {
            this.TabTasks = new List<List<string>>();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Saves the specified tab control.
        /// </summary>
        /// <param name="tabControl">The tab control.</param>
        public void Save(TabControl tabControl)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                var incompleteTasks = tab.Controls.OfType<HomeworkUserControl>().First().GetIncompleteTasks();
                this.TabTasks.Add(incompleteTasks);
            }
        }

        /// <summary>
        ///     Transfers the data in TabTasks to the given TabControl
        /// </summary>
        /// <param name="tabControl">The tab control.</param>
        public void LoadTo(TabControl tabControl)
        {
            for (var i = 0; i < tabControl.TabPages.Count; i++)
            {
                var control = tabControl.TabPages[i].Controls.OfType<HomeworkUserControl>().First();
                control.ClearRows();
                foreach (var task in this.TabTasks[i])
                {
                    control.AddIncompleteTask(task);
                }
            }
        }

        #endregion
    }
}