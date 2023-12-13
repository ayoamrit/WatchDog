using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ExceptionHandler
{
    internal class DesignException : IOException
    {
        public DesignException(string message) : base(message)
        {

        }
    }
}
