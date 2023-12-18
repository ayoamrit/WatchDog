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
            ProcessListView.Size = new Size(774, 545);
            ProcessListView.TabIndex = 0;
            ProcessListView.UseCompatibleStateImageBehavior = false;
            ProcessListView.View = View.Details;
            ProcessListView.ItemSelectionChanged += ProcessListView_ItemSelectionChanged;
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
            EndTaskButton.Location = new Point(698, 589);
            EndTaskButton.Name = "EndTaskButton";
            EndTaskButton.Size = new Size(113, 38);
            EndTaskButton.TabIndex = 1;
            EndTaskButton.Text = "End Task";
            EndTaskButton.UseVisualStyleBackColor = true;
            EndTaskButton.Click += EndTaskButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 682);
            Controls.Add(EndTaskButton);
            Controls.Add(ProcessListView);
            Name = "Form1";
            Text = "WatchDog";
            FormClosing += CloseForm;
            ResumeLayout(false);
        }

        #endregion

        private ListView ProcessListView;
        private ColumnHeader PidColumn;
        private ColumnHeader ProcessNameColumn;
        private ColumnHeader WindowTitleColumn;
        private ColumnHeader MemoryColumn;
        private Button EndTaskButton;
    }
}