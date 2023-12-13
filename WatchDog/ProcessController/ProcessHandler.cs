using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WatchDog.ProcessController
{
    public class ProcessHandler
    {
        private System.Diagnostics.Process currentProcess;
        private ListView processListView;
        private IEnumerable<System.Diagnostics.Process> runningProcesses = null;
        private ProcessDataHandler processDataHandler = new ProcessDataHandler();

        public ProcessHandler(ListView processListView)
        {
            this.processListView = processListView;

            while (true)
            {
                Run();
            }
        }

        private void Run()
        {
            runningProcesses = System.Diagnostics.Process.GetProcesses();

            foreach (var process in runningProcesses)
            {

                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    currentProcess = process;

                    processListView.Invoke((Action)Update);
                }
            }

            Thread.Sleep(5000);
            processListView.Invoke((Action)ClearProcessList);
            DesignHandler.ResetRowNumber();
            runningProcesses = null;

        }

        private void Update()
        {
            (string processId, string processName, string processWindowTitle, string memory) = processDataHandler.GetProcessData(currentProcess);


            ListViewItem listViewItem = new ListViewItem(processId);
            listViewItem.SubItems.Add(processName);
            listViewItem.SubItems.Add(processWindowTitle);
            listViewItem.SubItems.Add(memory);

            new DesignHandler(listViewItem);
            processListView.Items.Add(listViewItem);
        }

        private void ClearProcessList()
        {
            processListView.Items.Clear();
        }

    }
}
