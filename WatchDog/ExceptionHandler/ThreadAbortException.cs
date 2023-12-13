using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ExceptionHandler
{
    public class ThreadAbortException : IOException
    {
        public ThreadAbortException() : base("Thread has been aborted")
        {

        }
    }
}
