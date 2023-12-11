using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{
    public class ProcessHandler
    {
        private Dictionary<int, Process> ProcessDictionary = new Dictionary<int, Process>();
        private ListView ProcessListView;

        public ProcessHandler(ListView ProcessListView)
        {
            this.ProcessListView = ProcessListView;
            Run();
        }

        private void Run()
        {
            System.Diagnostics.Process[] runningProcesses = System.Diagnostics.Process.GetProcesses();


            foreach(var process in runningProcesses)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                   
                    ProcessDictionary.Add(process.Id, new Process(process.ProcessName));
                }
            }




            foreach (var key in ProcessDictionary.Keys)
            {
                ListViewItem listViewItem = new ListViewItem(key.ToString());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetProcessName());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetStatus());
                ProcessListView.Items.Add(listViewItem);
            }

        }
    }
}
