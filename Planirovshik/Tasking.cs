using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planirovshik
{
    public partial class Tasking : Form
    {

        private List<string> Tasks = new List<string>();

        public Tasking()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Tasks = new List<string>();
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            string taskText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(taskText))
            {
                Tasks.Add(taskText);
                UpdateTaskList();
                textBox1.Clear(); 
            }
            else
            {
                MessageBox.Show("Введите название задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxTasks.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTaskName = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(newTaskName))
            {
                Tasks[selectedIndex] = newTaskName;
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Введите новое название задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActiveTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemText = ActiveTasks.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (!ComplitedTasks.Items.Contains(itemText))
                    ComplitedTasks.Items.Add(itemText);
            }
            else
            {
                ComplitedTasks.Items.Remove(itemText);
            }
        }

        private void UpdateTaskList()
        {
            listBoxTasks.DataSource = null;
            ActiveTasks.DataSource = null;
            listBoxTasks.DataSource = Tasks;
            ActiveTasks.DataSource = Tasks;
        }
    }
}
