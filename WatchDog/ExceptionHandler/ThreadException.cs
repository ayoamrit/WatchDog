using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ExceptionHandler
{
    public class ThreadException : IOException
    {
        public ThreadException(string message): base(message)
        {

        }
    }
}
