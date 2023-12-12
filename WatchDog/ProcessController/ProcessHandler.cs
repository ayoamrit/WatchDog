using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchDog.DictionaryController;

namespace WatchDog.ProcessController
{
    public class ProcessHandler
    {
        private System.Diagnostics.Process currentProcess;
        private ListView processListView;
        private ProcessDataHandler processDataHandler = new ProcessDataHandler();

        public ProcessHandler(ListView processListView)
        {
            this.processListView = processListView;

            Run();
            Update();
        }

        private void Run()
        {
            System.Diagnostics.Process[] runningProcesses = System.Diagnostics.Process.GetProcesses();


            if(DictionaryHandler.ProcessDictionary.Count < runningProcesses.Length)
            {
                foreach(var runningProcess in runningProcesses)
                {
                    if (!String.IsNullOrEmpty(runningProcess.MainWindowTitle))
                    {
                        int processId = runningProcess.Id;

                        if (!DictionaryHandler.ProcessDictionary.ContainsKey(processId))
                        {
                            currentProcess = runningProcess;
                            AddToDictionary();
                        }
                    }

                }
            }

        }

        private void Update()
        {
            foreach(var key in DictionaryHandler.ProcessDictionary.Keys)
            {
                ListViewItem listViewItem = new ListViewItem(key.ToString());
                listViewItem.SubItems.Add(DictionaryHandler.ProcessDictionary[key].GetProcessName());
                listViewItem.SubItems.Add(DictionaryHandler.ProcessDictionary[key].GetStatus());
                listViewItem.SubItems.Add(DictionaryHandler.ProcessDictionary[key].GetPriority());
                listViewItem.SubItems.Add(DictionaryHandler.ProcessDictionary[key].GetMemory());
                listViewItem.SubItems.Add(DictionaryHandler.ProcessDictionary[key].GetRunTime());

                processListView.Items.Add(listViewItem);
            }
        }

        private void AddToDictionary()
        {
            int processId = currentProcess.Id;
            string processName = currentProcess.ProcessName;
            (string priority, string memory, string runTime) = processDataHandler.GetProcessData(currentProcess);


            DictionaryHandler.AddToDictionary(processId, new Process(processName, "Active", priority, memory, runTime));
        }

    }
}
