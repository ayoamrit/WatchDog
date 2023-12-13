using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchDog.ExceptionHandler;

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
        public (string, string, string, string) GetProcessData(System.Diagnostics.Process currentProcess)
        {
            string processId = string.Empty;
            string processName = string.Empty;
            string processWindowTitle = string.Empty;
            string processMemoryUsage = string.Empty;

            try
            {
                processId = currentProcess.Id.ToString();
                processName = currentProcess.ProcessName;
                processWindowTitle = currentProcess.MainWindowTitle;
                processMemoryUsage = (currentProcess.WorkingSet64 / (1024 * 1024)).ToString();


                return (processId, processName, processWindowTitle, processMemoryUsage);
            }
            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException($"'{currentProcess}': does not have admin permissions to execute");
            }
            catch(Exception ex)
            {
                throw new ProcessDataException(currentProcess, "an error occurred during the execution", ex.ToString());
            }


        }
    }
}
