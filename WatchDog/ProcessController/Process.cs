using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ProcessController
{
    public class Process
    {
        private string _id { get; set; }
        private string _name { get; set; }
        private string _windowTitle { get; set; }
        private string _memory { get; set; }

        public Process(string _id, string _name, string _windowTitle, string _memory)
        {
            this._id = _id;
            this._name = _name;
            this._windowTitle = _windowTitle;
            this._memory = _memory;
        }

        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string WindowTitle { get { return _windowTitle; } }
        public string Memory { get { return _memory; } }
    }
}
