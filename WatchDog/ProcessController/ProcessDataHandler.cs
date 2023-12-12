using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{

    /// <summary>
    /// Handles retrieval of specific data from a system process
    /// </summary>
    public class ProcessDataHandler
    {
        /// <summary>
        /// Retrieves process-related data such as priority class, start time (runTime), and memory usage
        /// </summary>
        /// <param name="currentProcess">The system process for which data is to be retrieved.</param>
        /// <returns>A tuple containing process priority class, memory usage, and run time</returns>
        public (string, string, string) GetProcessData(System.Diagnostics.Process currentProcess)
        {
            string processPriority = currentProcess.PriorityClass.ToString();
            string processRunTime = currentProcess.StartTime.ToString("hh:mm:ss");
            string processMemoryUsage = (currentProcess.WorkingSet64 / (1024 * 1024)).ToString("0.00");

            return (processPriority, processMemoryUsage, processRunTime);
        }
    }
}
