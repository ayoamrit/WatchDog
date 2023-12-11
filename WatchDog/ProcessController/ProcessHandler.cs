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
        private System.Diagnostics.Process CurrentProcess;
        private ListView ProcessListView;

        public ProcessHandler(ListView ProcessListView)
        {
            this.ProcessListView = ProcessListView;
            Run();
        }

        private void Run()
        {
            System.Diagnostics.Process[] runningProcesses = System.Diagnostics.Process.GetProcesses();

            

            if(ProcessDictionary.Count < runningProcesses.Length)
            {
                foreach(var runningProcess in runningProcesses)
                {
                    if (!String.IsNullOrEmpty(runningProcess.MainWindowTitle))
                    {
                        int processId = runningProcess.Id;

                        if (!ProcessDictionary.ContainsKey(processId))
                        {
                            CurrentProcess = runningProcess;
                            AddToDictionary();
                        }
                    }

                }
            }

            foreach(var key in ProcessDictionary.Keys)
            {
                ListViewItem listViewItem = new ListViewItem(key.ToString());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetProcessName());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetStatus());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetCPU());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetMemory());
                listViewItem.SubItems.Add(ProcessDictionary[key].GetRunTime());

                ProcessListView.Items.Add(listViewItem);
            }

        }

        private void AddToDictionary()
        {
            int ProcessId = CurrentProcess.Id;
            string ProcessName = CurrentProcess.ProcessName;
            string Status = "Active";
            string CPU = GetProcessorUsage(ProcessName).ToString();
            string Memory = GetMemoryUsage().ToString("0.00");
            string RunTime = GetProcessRunTime().ToString();


            ProcessDictionary.Add(ProcessId, new Process(ProcessName, Status, CPU, Memory, RunTime));
        }

        private double GetMemoryUsage()
        {
            double memoryUsageMegaBytes = (CurrentProcess.WorkingSet64) / (1024 * 1024);

            return memoryUsageMegaBytes;
        }

        private double GetProcessorUsage(string ProcessName)
        {
            PerformanceCounter performanceCounter = new PerformanceCounter("Process", "% Processor Time", ProcessName,true);

            //float processorUsage = performanceCounter.NextValue();

            //return Math.Round(processorUsage / Environment.ProcessorCount, 2);

            ////return processorUsage / (Environment.ProcessorCount, 2);
           
            double rawValue1 = performanceCounter.NextValue();
            Thread.Sleep(250);

            // Calculate the percentage by considering the elapsed time and the number of processor cores


            return Math.Round(rawValue1);
        }

        private int GetProcessRunTime()
        {
            return 2;
        }

    }
}
