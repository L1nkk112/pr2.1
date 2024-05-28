using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ПР2._1_НИКИТА
{
    public partial class Form1 : Form
    {
        private List<(string Engineer, string Task)> tasks = new List<(string Engineer, string Task)>();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EngineerName.Text) || string.IsNullOrWhiteSpace(taskTextBox.Text))
            {
                MessageBox.Show("Введите имя инженера и задачу.");
                return;
            }
            tasks.Add((EngineerName.Text, taskTextBox.Text));
            EngineerName.Text = "";
            taskTextBox.Text = "";
        }
        private void ShowTasksByEngineer()
        {
            foreach (var engineer in tasks.Select(t => t.Engineer).Distinct())
            {
                tasksListBox.Items.Add($"Задачи для инженера {engineer}:");
                var engineerTasks = tasks.Where(t => t.Engineer == engineer).Select(t => t.Task);
                foreach (var task in engineerTasks)
                {
                    tasksListBox.Items.Add(task);
                }
                tasksListBox.Items.Add("");
            }
        }
        private void ShowCommonTasks()
        {
            engineerTasksListBox.Items.Add("Общие задачи для нескольких инженеров:");

            var commonTasks = tasks.GroupBy(t => t.Task)
                                   .Where(g => g.Count() > 1)
                                   .Select(g => g.Key);

            foreach (var task in commonTasks)
            {
                engineerTasksListBox.Items.Add(task);
            }
        }
        private void ShowTasksButton_Click(object sender, EventArgs e)
        {
            ShowTasksByEngineer();
            ShowCommonTasks();
        }
    }
}