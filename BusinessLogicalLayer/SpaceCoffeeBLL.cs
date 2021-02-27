using BusinessLogicalLayer.Helper;
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
    public class SpaceCoffeeBLL : BaseValidator<SpaceCoffee>
    {
        SpaceCoffeeDAL spaceDAL = new SpaceCoffeeDAL();
        public override Response Validate(SpaceCoffee item)
        {
            AddError(item.Name.IsValidName());
            return base.Validate(item);
        }
        public Response Insert(SpaceCoffee space)
        {
            Response responseValidate = Validate(space);
            if (responseValidate.Success)
            {
                Response response = spaceDAL.Insert(space);
                return response;
            }
            return responseValidate;
        } 
        public TableResponse GetAllTable()
        {
            TableResponse response = spaceDAL.GetAllTable();
            return response;
        } 
        public TableResponse GetByName(SpaceCoffee _space)
        {
            TableResponse response = spaceDAL.GetByName(_space);
            return response;
        } 
        public QueryResponse<SpaceCoffee> GetAllList()
        {
            QueryResponse<SpaceCoffee> response = spaceDAL.GetAllList();
            return response;
        } 
        public SingleResponse<SpaceCoffee> Get(SpaceCoffee _space)
        {
            SingleResponse<SpaceCoffee> response = spaceDAL.Get(_space);
            return response;
        } 
        public Response DeleteAll()
        {
            Response response = spaceDAL.DeleteAll();
            return response;
        } 
        public Response ExistTwoSpaces()
        {
            Response response = new Response();

            //pegar todas as salas de café
            QueryResponse<SpaceCoffee> r1 = this.GetAllList();
            int totalSpaces = r1.Data.Count;

            if (totalSpaces == 2)
            {
                response.Success = true;
                response.Message = "Existem duas salas de café cadastradas, vá ao próximo passo.";
            }
            else
            {
                response.Success = false;
            }

            return response;
        } 

    }
}
