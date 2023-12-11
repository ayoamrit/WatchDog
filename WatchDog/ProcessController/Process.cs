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
        private string Disk { get; set; } = String.Empty;
        private string Network { get; set; } = String.Empty;

        public Process(string ProcessName, string Status, string CPU, string Memory, string Disk, string Network)
        {
            this.ProcessName = ProcessName;
            this.Status = Status;
            this.CPU = CPU;
            this.Memory = Memory;
            this.Disk = Disk;
            this.Network = Network;
        }

        public Process(string ProcessName)
        {
            this.ProcessName = ProcessName;
        }

        public Func<string> GetProcessName => () => ProcessName;

        public Func<string> GetStatus => () => Status;

        public Func<string> GetCPU => () => CPU;

        public Func<string> GetMemory => () => Memory;

        public Func<string> GetDisk => () => Disk;

        public Func<string> GetNetwork => () => Network;
    }
}
