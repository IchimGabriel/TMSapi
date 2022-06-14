using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    public class ConflictException : CustomException
    {
        public ConflictException(string message)
        : base(message, null, HttpStatusCode.Conflict)
        {
        }
    }
}
