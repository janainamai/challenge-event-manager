using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class QueryResponse<T> : Response
    {
        public List<T> Data { get; set; }
    }

    public class TableResponse : Response
    {
        public DataTable DataTable { get; set; } 
    }

    public class SingleResponse<T> : Response
    {
        public T Data { get; set; }
    }
}
