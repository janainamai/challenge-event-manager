using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IAdministrator
    {
        SingleResponse<Administrator> GetAdm(Administrator _adm);
        Response Insert(Administrator _adm);
    }
}
