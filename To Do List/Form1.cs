using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        private ToDoListManager toDoListManager;
        public Form1()
        {
            InitializeComponent();
            toDoListManager = new ToDoListManager();

            // Tắt auto-generate columns trước khi gán DataSource
            ToDoListView.AutoGenerateColumns = false;

            // Gán DataSource sau khi đã tắt auto-generate columns
            ToDoListView.DataSource = toDoListManager.Tasks;

            ToDoListView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title" });
            ToDoListView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Description", DataPropertyName = "Description" });

            ToDoListView.SelectionChanged += ToDoListView_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ToDoListView_SelectionChanged(object sender, EventArgs e)
        {
            if (ToDoListView.CurrentRow != null)
            {
                var selectedTask = ToDoListView.CurrentRow.DataBoundItem as TaskItem;
                if (selectedTask != null)
                {
                    TitleTextbox.Text = selectedTask.Title;
                    DescriptionTextbox.Text = selectedTask.Description;
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleTextbox.Text = string.Empty;
            DescriptionTextbox.Text = string.Empty;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (ToDoListView.CurrentRow != null)
            {
                var selectedTask = ToDoListView.CurrentRow.DataBoundItem as TaskItem;
                if (selectedTask != null)
                {
                    toDoListManager.DeleteTask(selectedTask);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ToDoListView.CurrentRow != null)
            {
                var selectedTask = ToDoListView.CurrentRow.DataBoundItem as TaskItem;
                if (selectedTask != null)
                {
                    var newTask = new TaskItem { Title = TitleTextbox.Text, Description = DescriptionTextbox.Text };
                    toDoListManager.EditTask(selectedTask, newTask);
                    ToDoListView.Refresh(); // Cập nhật hiển thị của DataGridView
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TitleTextbox.Text) && !string.IsNullOrWhiteSpace(DescriptionTextbox.Text))
            {
                var task = new TaskItem { Title = TitleTextbox.Text, Description = DescriptionTextbox.Text };
                toDoListManager.AddTask(task);
                TitleTextbox.Text = string.Empty;
                DescriptionTextbox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please fill in both the Title and Description fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
