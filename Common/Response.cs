using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string ExeptionMessage { get; set; }
        public string StackTrace { get; set; }

        public Response()
        { }

        public Response(string message, bool sucess, string exeptionMessage, string stackTrace)
        {
            this.Message = message;
            this.Success = sucess;
            this.ExeptionMessage = exeptionMessage;
            this.StackTrace = stackTrace;
        }
    }
}
