﻿namespace WatchDog
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
            StatusColumn = new ColumnHeader();
            CPUColumn = new ColumnHeader();
            MemoryColumn = new ColumnHeader();
            DiskColumn = new ColumnHeader();
            NetworkColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // ProcessListView
            // 
            ProcessListView.Columns.AddRange(new ColumnHeader[] { PidColumn, ProcessNameColumn, StatusColumn, CPUColumn, MemoryColumn, DiskColumn, NetworkColumn });
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
            PidColumn.Width = 100;
            // 
            // ProcessNameColumn
            // 
            ProcessNameColumn.Text = "Process";
            ProcessNameColumn.Width = 170;
            // 
            // StatusColumn
            // 
            StatusColumn.Text = "Status";
            StatusColumn.Width = 100;
            // 
            // CPUColumn
            // 
            CPUColumn.Text = "CPU";
            CPUColumn.TextAlign = HorizontalAlignment.Right;
            CPUColumn.Width = 100;
            // 
            // MemoryColumn
            // 
            MemoryColumn.Text = "Memory";
            MemoryColumn.TextAlign = HorizontalAlignment.Right;
            MemoryColumn.Width = 100;
            // 
            // DiskColumn
            // 
            DiskColumn.Text = "Disk";
            DiskColumn.TextAlign = HorizontalAlignment.Right;
            DiskColumn.Width = 100;
            // 
            // NetworkColumn
            // 
            NetworkColumn.Text = "Network";
            NetworkColumn.TextAlign = HorizontalAlignment.Right;
            NetworkColumn.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 682);
            Controls.Add(ProcessListView);
            Name = "Form1";
            Text = "WatchDog";
            ResumeLayout(false);
        }

        #endregion

        private ListView ProcessListView;
        private ColumnHeader PidColumn;
        private ColumnHeader ProcessNameColumn;
        private ColumnHeader StatusColumn;
        private ColumnHeader CPUColumn;
        private ColumnHeader MemoryColumn;
        private ColumnHeader DiskColumn;
        private ColumnHeader NetworkColumn;
    }
}