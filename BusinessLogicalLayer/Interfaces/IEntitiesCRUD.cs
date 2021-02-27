using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public interface IEntitiesCRUD<T>
    {
        Response Validate(T item);
        Response Insert(T item);
        TableResponse GetAllTable();
        QueryResponse<T> GetAllList();
        SingleResponse<T> Get(T _space);
        TableResponse GetByName(T _space);
        Response DeleteAll();
    }
}
