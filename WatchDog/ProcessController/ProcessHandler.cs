using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchDog.ExceptionHandler;
using System.Windows.Forms.VisualStyles;

namespace WatchDog.ProcessController
{
    public class ProcessHandler
    {
        private ListView processListView;
        private IList<System.Diagnostics.Process> runningProcesses;
        private IList<Process> processList;
        private ProcessDataHandler processDataHandler = new ProcessDataHandler();

        public ProcessHandler(ListView processListView)
        {
         
            this.processListView = processListView;
            processList = new List<Process>();

            try
            {
                while (true)
                {
                    Run();
                    Thread.Sleep(5000);
    
                }
            }
            catch (Exception)
            {
                throw new ThreadException("An error occurred while executing the thread");
            }
        }

        private void Run()
        {
            runningProcesses = System.Diagnostics.Process.GetProcesses().ToList();

            foreach (var process in runningProcesses)
            {

                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    UpdateProcessList(process);
                }
            }

            processListView.Invoke((Action)ClearListViewItem);
            processListView.Invoke((Action)Update);
            DesignHandler.ResetRowNumber();
            runningProcesses.Clear();
            processList.Clear();
            
        }

        private void Update()
        {

            foreach(var process in processList)
            {
                ListViewItem listViewItem = new ListViewItem(process.Id);
                listViewItem.SubItems.Add(process.Name);
                listViewItem.SubItems.Add(process.WindowTitle);
                listViewItem.SubItems.Add(process.Memory);

                new DesignHandler(listViewItem);
                processListView.Items.Add(listViewItem);
            }
        }

        private void UpdateProcessList(System.Diagnostics.Process currentProcess)
        {
            (string processId, string processName, string processWindowTitle, string memory) = processDataHandler.GetProcessData(currentProcess);

            processList.Add(new Process(processId, processName, processWindowTitle, memory));
        }

        private void ClearListViewItem()
        {
            processListView.Items.Clear();
        }

    }
}
