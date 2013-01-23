using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class ForgottenInfoException : Exception
    {
        public ForgottenInfoException(string message) : base(message)
        { }
        
    }
}
