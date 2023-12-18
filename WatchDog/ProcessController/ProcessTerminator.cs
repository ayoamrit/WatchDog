using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{
    public class ProcessTerminator
    {
  
        public ProcessTerminator(int processId)
        {
            //Get the process by its ID.
            System.Diagnostics.Process process = GetProcess(processId);

            //Terminate the process
            TerminateProcess(process);
        }

        /// <summary>
        /// Gets the process by its ID
        /// </summary>
        /// <param name="processId">The ID of the process retrieve</param>
        /// <returns>Object representing the specified process</returns>
        private System.Diagnostics.Process GetProcess(int processId)
        {
            return System.Diagnostics.Process.GetProcessById(processId);
        }


        /// <summary>
        /// Terminate a process
        /// </summary>
        /// <param name="process">Object representing the process to terminate</param>
        private void TerminateProcess(System.Diagnostics.Process process)
        {
            //Check if the process is still running
            if (!process.HasExited)
            {
                //Terminate the process
                process.Kill();
            }
        }
    }
}
