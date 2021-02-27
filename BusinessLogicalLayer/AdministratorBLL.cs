using Common;
using DataAcessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class AdministratorBLL
    {
        AdministratorDAL admDAL = new AdministratorDAL();
        public SingleResponse<Administrator> GetAdm(Administrator _adm)
        {
            SingleResponse<Administrator> response = admDAL.GetAdm(_adm);
            return response;
        }
        public Response Insert(Administrator _adm)
        {
            Response response = admDAL.Insert(_adm);
            return response;
        }
    }
}
