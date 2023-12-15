using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management; 

namespace WatchDog.ProcessorController
{
    public class ProcessorHandler
    {
        public ProcessorHandler()
        {
            var processorSearcher = ProcessorSearcher();

            foreach(var processorObject in processorSearcher.Get())
            {

            }
        }

        private ManagementObjectSearcher ProcessorSearcher()
        {
            return new ManagementObjectSearcher("select * from Win32_Processor");
        }
    }
}
