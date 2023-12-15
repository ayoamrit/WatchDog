using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessorController
{
    public class Processor
    {
        //Fields to processor information
        private string _id { get; set; }
        private string _name { get; set; }
        private string _manufacturer { get; set; }
        private string _maxClockSpeed { get; set; }
        private string _numberOfCores { get; set; }
        private string _logicalProcessors { get; set; }

        //Constructor to initialize the processor information
        public Processor(string _id, string _name, string _manufacturer, string _maxClockSpeed, string _numberOfCores, string _logicalProcessors)
        {
            this._id = _id;
            this._name = _name;
            this._manufacturer = _manufacturer;
            this._maxClockSpeed = _maxClockSpeed;
            this._numberOfCores = _numberOfCores;
            this._logicalProcessors = _logicalProcessors;
        }

        //Gets the processor Id
        public string Id { get { return _id; } }

        //Gets the processor name
        public string Name { get { return _name; } }

        //Gets the manufacturer of the processor
        public string Manufacturer { get { return _manufacturer; } }

        //Gets the maximum clock speed of the processor
        public string MaxClockSpeed { get { return _maxClockSpeed; } }

        //Gets the number of physical cores in the processor
        public string NumberOfCores { get { return _numberOfCores; } }

        //Gets the total number of logical processors in the processors
        public string LogicalProcessors { get { return _logicalProcessors; } }
    }
}
