using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{
    /// <summary>
    /// Represents information about a running process
    /// </summary>
    public class Process
    {
        //Properties to store process information
        private string ProcessName { get; set; } = String.Empty;
        private string Status { get; set; } = String.Empty;
        private string Priority { get; set; } = String.Empty;
        private string Memory { get; set; } = String.Empty;
        private string RunTime { get; set; } = String.Empty;
        

        /// <summary>
        /// Initialize a new instance of the Process class
        /// </summary>
        /// <param name="ProcessName">The name of the process</param>
        /// <param name="Status">The status of the process</param>
        /// <param name="Priority">The priority class of the process</param>
        /// <param name="Memory">The amount of physical memory allocated for the associated process</param>
        /// <param name="RunTime">The start time of the process</param>
        public Process(string ProcessName, string Status, string Priority, string Memory, string RunTime)
        {
            this.ProcessName = ProcessName;
            this.Status = Status;
            this.Priority = Priority;
            this.Memory = Memory;
            this.RunTime = RunTime;
        }

        /// <summary>
        /// Gets a lambda expression to set the memory property
        /// </summary>
        public Action<string> SetMemory => Memory => this.Memory = Memory;

        /// <summary>
        /// Gets a lambda expression to retrieve the process name
        /// </summary>
        public Func<string> GetProcessName => () => ProcessName;

        /// <summary>
        /// Gets a lambda expression to retrieve the process status
        /// </summary>
        public Func<string> GetStatus => () => Status;

        /// <summary>
        /// Gets a lambda expression to retrieve the process priority class
        /// </summary>
        public Func<string> GetPriority => () => Priority;

        /// <summary>
        /// Gets a lambda expression to retrieve the process memory usage
        /// </summary>
        public Func<string> GetMemory => () => Memory;

        /// <summary>
        /// Gets a lambda expression to retrieve the process start time.
        /// </summary>
        public Func<string> GetRunTime => () => RunTime;
    }
}
