using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{
    public class Process
    {
        private string ProcessName { get; set; } = String.Empty;
        private string Status { get; set; } = String.Empty;
        private string CPU { get; set; } = String.Empty;
        private string Memory { get; set; } = String.Empty;
        private string RunTime { get; set; } = String.Empty;

        public Process(string ProcessName, string Status, string CPU, string Memory, string RunTime)
        {
            this.ProcessName = ProcessName;
            this.Status = Status;
            this.CPU = CPU;
            this.Memory = Memory;
            this.RunTime = RunTime;
        }

        public Process(string CPU, string Memory, string RunTime)
        {
            this.CPU = CPU;
            this.Memory = Memory;
            this.RunTime = RunTime;
        }

        public Func<string> GetProcessName => () => ProcessName;

        public Func<string> GetStatus => () => Status;

        public Func<string> GetCPU => () => CPU;

        public Func<string> GetMemory => () => Memory;

        public Func<string> GetRunTime => () => RunTime;
    }
}
