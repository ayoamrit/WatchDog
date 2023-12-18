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

        //ListView control to display the list of processes
        private ListView processListView;

        //List of running processes instances
        private IList<System.Diagnostics.Process> runningProcesses;

        //List of custom Process objects containing processed information
        private IList<Process> processList;

        //Instance of ProcessDataHandler to retrieve data from Process instances
        private ProcessDataHandler processDataHandler = new ProcessDataHandler();


        public ProcessHandler(ListView processListView)
        {
         
            //Set the ListView control
            this.processListView = processListView;

            //Init processList
            processList = new List<Process>();

            try
            {
                //Infinite loop to continuously update the processList
                while (true)
                {
                    Run();

                    //Sleep to control the update frequency
                    Thread.Sleep(100);
    
                }
            }
            catch (Exception)
            {
                //Throw an exception if an error occurred
                throw new ThreadException("An error occurred while executing the thread");
            }
        }

        private void Run()
        {
            //Get all the running processes in the system
            runningProcesses = System.Diagnostics.Process.GetProcesses().ToList();

            //Iterate through running processes
            foreach (var process in runningProcesses)
            {
                //Check if the process has a main window title
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    //Update the process list 
                    UpdateProcessList(process);
                }
            }

            //Clear ListView items on the UI thread
            processListView.Invoke((Action)ClearListViewItem);
            //Update the ListView on the UI thread
            processListView.Invoke((Action)Update);

            //Reset number for visual styling
            DesignHandler.ResetRowNumber();

            //Clear list to prepare for next update
            runningProcesses.Clear();
            processList.Clear();
            
        }

        private void Update()
        {
            //Iterate through processes
            foreach(var process in processList)
            {
                //Create a new instance and add it to the ListView
                ListViewItem listViewItem = new ListViewItem(process.Id);
                listViewItem.SubItems.Add(process.Name);
                listViewItem.SubItems.Add(process.WindowTitle);
                listViewItem.SubItems.Add(process.Memory);

                //Apply visual styling using DesignHandler
                new DesignHandler(listViewItem);

                //Add the ListViewItem to the ListView
                processListView.Items.Add(listViewItem);
            }
        }


        //Update the processList with information from the current Process
        private void UpdateProcessList(System.Diagnostics.Process currentProcess)
        {

            //Retrieve process data using ProcessDataHandler
            (string processId, string processName, string processWindowTitle, string memory) = processDataHandler.GetProcessData(currentProcess);

            //Add a new Process object to the processList
            processList.Add(new Process(processId, processName, processWindowTitle, memory));
        }

        //Clear all items from the ListView
        private void ClearListViewItem()
        {
            processListView.Items.Clear();
        }

    }
}
