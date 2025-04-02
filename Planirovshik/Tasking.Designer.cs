namespace Planirovshik
{
    partial class Tasking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Editing = new TabPage();
            button1 = new Button();
            listBoxTasks = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            tasksList = new Label();
            AddTask = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            ActiveTasks = new CheckedListBox();
            TaskActiveList = new Label();
            label3 = new Label();
            ComplitedTasks = new ListBox();
            tabControl1.SuspendLayout();
            Editing.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Editing);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 460);
            tabControl1.TabIndex = 0;
            // 
            // Editing
            // 
            Editing.Controls.Add(button1);
            Editing.Controls.Add(listBoxTasks);
            Editing.Controls.Add(label2);
            Editing.Controls.Add(textBox1);
            Editing.Controls.Add(tasksList);
            Editing.Controls.Add(AddTask);
            Editing.Controls.Add(label1);
            Editing.Location = new Point(4, 29);
            Editing.Name = "Editing";
            Editing.Padding = new Padding(3);
            Editing.Size = new Size(795, 427);
            Editing.TabIndex = 0;
            Editing.Text = "Редактирование";
            Editing.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(503, 167);
            button1.Name = "button1";
            button1.Size = new Size(202, 49);
            button1.TabIndex = 6;
            button1.Text = "Изменить выбранную задачу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EditTask_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.Location = new Point(21, 79);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(457, 324);
            listBoxTasks.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 33);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите название задачи:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(503, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 36);
            textBox1.TabIndex = 3;
            // 
            // tasksList
            // 
            tasksList.Location = new Point(30, 79);
            tasksList.Name = "tasksList";
            tasksList.Size = new Size(448, 316);
            tasksList.TabIndex = 2;
            // 
            // AddTask
            // 
            AddTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddTask.Location = new Point(503, 112);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(202, 38);
            AddTask.TabIndex = 1;
            AddTask.Text = "Добавить новую задачу";
            AddTask.UseVisualStyleBackColor = true;
            AddTask.Click += AddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(167, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 38);
            label1.TabIndex = 0;
            label1.Text = "Задачи:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ComplitedTasks);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Выполненные задачи";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ActiveTasks);
            tabPage1.Controls.Add(TaskActiveList);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(795, 427);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Активные задачи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ActiveTasks
            // 
            ActiveTasks.FormattingEnabled = true;
            ActiveTasks.Location = new Point(29, 66);
            ActiveTasks.Name = "ActiveTasks";
            ActiveTasks.Size = new Size(468, 312);
            ActiveTasks.TabIndex = 1;
            ActiveTasks.ItemCheck += ActiveTasks_ItemCheck;
            // 
            // TaskActiveList
            // 
            TaskActiveList.AutoSize = true;
            TaskActiveList.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TaskActiveList.Location = new Point(232, 14);
            TaskActiveList.Name = "TaskActiveList";
            TaskActiveList.Size = new Size(349, 38);
            TaskActiveList.TabIndex = 0;
            TaskActiveList.Text = "Список активных задач:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(176, 17);
            label3.Name = "label3";
            label3.Size = new Size(410, 38);
            label3.TabIndex = 0;
            label3.Text = "Список выполненных задач:";
            // 
            // ComplitedTasks
            // 
            ComplitedTasks.FormattingEnabled = true;
            ComplitedTasks.Location = new Point(52, 74);
            ComplitedTasks.Name = "ComplitedTasks";
            ComplitedTasks.Size = new Size(457, 324);
            ComplitedTasks.TabIndex = 6;
            // 
            // Tasking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Tasking";
            Text = "Tasking";
            tabControl1.ResumeLayout(false);
            Editing.ResumeLayout(false);
            Editing.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Editing;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button AddTask;
        private Label label1;
        private Label tasksList;
        private Label label2;
        private TextBox textBox1;
        private ListBox listBoxTasks;
        private Button button1;
        private Label TaskActiveList;
        private CheckedListBox ActiveTasks;
        private ListBox ComplitedTasks;
        private Label label3;
    }
}