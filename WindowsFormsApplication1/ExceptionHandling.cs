using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
    {
    class ExceptionHandling:Exception
        {
       public ExceptionHandling(string message, Exception innnerException)
           :base(message, innnerException)
           {

           }

        }
    }
