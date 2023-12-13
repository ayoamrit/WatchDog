namespace WatchDog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProcessListView = new ListView();
            PidColumn = new ColumnHeader();
            ProcessNameColumn = new ColumnHeader();
            WindowTitleColumn = new ColumnHeader();
            MemoryColumn = new ColumnHeader();
            EndTaskButton = new Button();
            CPUButton = new Button();
            RAMButton = new Button();
            SystemButton = new Button();
            SuspendLayout();
            // 
            // ProcessListView
            // 
            ProcessListView.BorderStyle = BorderStyle.None;
            ProcessListView.Columns.AddRange(new ColumnHeader[] { PidColumn, ProcessNameColumn, WindowTitleColumn, MemoryColumn });
            ProcessListView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessListView.FullRowSelect = true;
            ProcessListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ProcessListView.Location = new Point(37, 38);
            ProcessListView.MultiSelect = false;
            ProcessListView.Name = "ProcessListView";
            ProcessListView.Size = new Size(774, 300);
            ProcessListView.TabIndex = 0;
            ProcessListView.UseCompatibleStateImageBehavior = false;
            ProcessListView.View = View.Details;
            // 
            // PidColumn
            // 
            PidColumn.Text = "PID";
            PidColumn.Width = 115;
            // 
            // ProcessNameColumn
            // 
            ProcessNameColumn.Text = "Process";
            ProcessNameColumn.Width = 220;
            // 
            // WindowTitleColumn
            // 
            WindowTitleColumn.Text = "WindowTitle";
            WindowTitleColumn.Width = 310;
            // 
            // MemoryColumn
            // 
            MemoryColumn.Text = "Memory";
            MemoryColumn.TextAlign = HorizontalAlignment.Right;
            MemoryColumn.Width = 129;
            // 
            // EndTaskButton
            // 
            EndTaskButton.Location = new Point(698, 344);
            EndTaskButton.Name = "EndTaskButton";
            EndTaskButton.Size = new Size(113, 38);
            EndTaskButton.TabIndex = 1;
            EndTaskButton.Text = "End Task";
            EndTaskButton.UseVisualStyleBackColor = true;
            // 
            // CPUButton
            // 
            CPUButton.Location = new Point(37, 344);
            CPUButton.Name = "CPUButton";
            CPUButton.Size = new Size(113, 38);
            CPUButton.TabIndex = 2;
            CPUButton.Text = "CPU";
            CPUButton.UseVisualStyleBackColor = true;
            // 
            // RAMButton
            // 
            RAMButton.Location = new Point(156, 344);
            RAMButton.Name = "RAMButton";
            RAMButton.Size = new Size(113, 38);
            RAMButton.TabIndex = 3;
            RAMButton.Text = "RAM";
            RAMButton.UseVisualStyleBackColor = true;
            // 
            // SystemButton
            // 
            SystemButton.Location = new Point(275, 344);
            SystemButton.Name = "SystemButton";
            SystemButton.Size = new Size(113, 38);
            SystemButton.TabIndex = 4;
            SystemButton.Text = "System";
            SystemButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 682);
            Controls.Add(SystemButton);
            Controls.Add(RAMButton);
            Controls.Add(CPUButton);
            Controls.Add(EndTaskButton);
            Controls.Add(ProcessListView);
            Name = "Form1";
            Text = "WatchDog";
            ResumeLayout(false);

            this.FormClosing += CloseForm;
        }

        #endregion

        private ListView ProcessListView;
        private ColumnHeader PidColumn;
        private ColumnHeader ProcessNameColumn;
        private ColumnHeader WindowTitleColumn;
        private ColumnHeader MemoryColumn;
        private Button EndTaskButton;
        private Button CPUButton;
        private Button RAMButton;
        private Button SystemButton;
    }
}