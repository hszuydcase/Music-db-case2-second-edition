using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class ExistsException : Exception
    {
        public ExistsException(string message)
            : base(message)
        { }
    }
}
