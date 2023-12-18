using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ExceptionHandler
{
    public class TerminateTaskException : Exception
    {
        public TerminateTaskException(string message) : base(message)
        {

        }
    }
}
