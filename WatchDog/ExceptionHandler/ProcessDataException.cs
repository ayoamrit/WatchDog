using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog.ExceptionHandler
{
    public class ProcessDataException : IOException
    {
        public ProcessDataException(System.Diagnostics.Process process, string message, string exception) : base($"'{process}': message: {exception}")
        {

        }
    }
}
