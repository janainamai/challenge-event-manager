using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Helper
{
    public class BaseValidator<T>
    {
        private List<string> errors = new List<string>();

        public void AddError(string error)
        {
            if(error != "")
                errors.Add(error);
        }

        public virtual Response Validate(T item)
        {
            return CheckError();
        }

        public Response CheckError()
        {
            Response response = new Response();
            if (errors.Count == 0)
            {
                response.Success = true;
                return response;
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                foreach(string item in errors)
                {
                    builder.AppendLine(item);
                }
                response.Success = false;
                response.Message = builder.ToString();
                return response;
            }
        }
    }
}
