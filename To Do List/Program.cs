using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class ToDoListManager
    {
        public BindingList<TaskItem> Tasks { get; private set; }

        public ToDoListManager()
        {
            Tasks = new BindingList<TaskItem>();
        }

        public void AddTask(TaskItem task)
        {
            if (task != null)
            {
                Tasks.Add(task);
            }
        }

        public void DeleteTask(TaskItem task)
        {
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }

        public void EditTask(TaskItem oldTask, TaskItem newTask)
        {
            if (oldTask != null && newTask != null)
            {
                var index = Tasks.IndexOf(oldTask);
                if (index >= 0)
                {
                    Tasks[index] = newTask;
                }
            }
        }
    }
}
