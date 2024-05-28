namespace ПР2._1_НИКИТА
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.ShowTasksButton = new System.Windows.Forms.Button();
            this.EngineerName = new System.Windows.Forms.TextBox();
            this.engineerTasksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(100, 356);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(75, 23);
            this.AddTaskButton.TabIndex = 0;
            this.AddTaskButton.Text = "button1";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(34, 156);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(100, 20);
            this.taskTextBox.TabIndex = 1;
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(162, 100);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(276, 95);
            this.tasksListBox.TabIndex = 2;
            // 
            // ShowTasksButton
            // 
            this.ShowTasksButton.Location = new System.Drawing.Point(242, 356);
            this.ShowTasksButton.Name = "ShowTasksButton";
            this.ShowTasksButton.Size = new System.Drawing.Size(75, 23);
            this.ShowTasksButton.TabIndex = 3;
            this.ShowTasksButton.Text = "button1";
            this.ShowTasksButton.UseVisualStyleBackColor = true;
            this.ShowTasksButton.Click += new System.EventHandler(this.ShowTasksButton_Click);
            // 
            // EngineerName
            // 
            this.EngineerName.Location = new System.Drawing.Point(34, 100);
            this.EngineerName.Name = "EngineerName";
            this.EngineerName.Size = new System.Drawing.Size(100, 20);
            this.EngineerName.TabIndex = 4;
            // 
            // engineerTasksListBox
            // 
            this.engineerTasksListBox.FormattingEnabled = true;
            this.engineerTasksListBox.Location = new System.Drawing.Point(162, 201);
            this.engineerTasksListBox.Name = "engineerTasksListBox";
            this.engineerTasksListBox.Size = new System.Drawing.Size(276, 95);
            this.engineerTasksListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.engineerTasksListBox);
            this.Controls.Add(this.EngineerName);
            this.Controls.Add(this.ShowTasksButton);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.AddTaskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Button ShowTasksButton;
        private System.Windows.Forms.TextBox EngineerName;
        private System.Windows.Forms.ListBox engineerTasksListBox;
    }
}

