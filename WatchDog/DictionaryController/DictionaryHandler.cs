using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.DictionaryController
{
    public class DictionaryHandler
    {

        /// <summary>
        /// Dictionary to store processes with their corresponding IDs
        /// </summary>
        public static Dictionary<int, WatchDog.ProcessController.Process> ProcessDictionary = new Dictionary<int, ProcessController.Process>();

        /// <summary>
        /// Add a process to the dictionary
        /// </summary>
        /// <param name="processId">The unique identifier of the process</param>
        /// <param name="process">The process to be added</param>
        public static void AddToDictionary(int processId, ProcessController.Process process)
        {
            //Add process to the dictionary
            ProcessDictionary.Add(processId, process);
        }
    }
}
