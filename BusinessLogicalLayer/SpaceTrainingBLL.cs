using BusinessLogicalLayer.Helper;
using Common;
using DataAcessLayer;
using Entities;
using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class SpaceTrainingBLL : BaseValidator<SpaceTraining>
    {
        SpaceTrainingDAL spaceDAL = new SpaceTrainingDAL();
        public override Response Validate(SpaceTraining item)
        {
            AddError(item.Name.IsValidName());
            AddError(item.MaxCapacity.ToString().IsValidMaxCapacity());
            return base.Validate(item);
        }
        public Response Insert(SpaceTraining _space)
        {
            Response responseValidate = Validate(_space);
            if (responseValidate.Success)
            {
                Response response = spaceDAL.Insert(_space);
                return response;
            }
            return responseValidate;
        }
        public TableResponse GetAllTable()
        {
            TableResponse response = spaceDAL.GetAllTable();
            return response;
        }
        public QueryResponse<SpaceTraining> GetAllList()
        {
            QueryResponse<SpaceTraining> response = spaceDAL.GetAllList();
            return response;
        }
        public SingleResponse<SpaceTraining> Get(SpaceTraining _space)
        {
            SingleResponse<SpaceTraining> response = spaceDAL.Get(_space);
            return response;
        }
        public TableResponse GetByName(SpaceTraining _space)
        {
            TableResponse response = spaceDAL.GetByName(_space);
            return response;
        }
        public Response DeleteAll()
        {
            Response response = spaceDAL.DeleteAll();
            return response;
        }
        public SingleResponse<SpaceTraining> GetSmallerSpace()
        {
            SingleResponse<SpaceTraining> response = spaceDAL.GetSmallerSpace();
            return response;
        }
        public QueryResponse<SpaceTraining> GetSpaceWithEmptySeat(int personsPerRoom)
        {
            QueryResponse<SpaceTraining> response = spaceDAL.GetSpaceWithEmptySeat(personsPerRoom);
            return response;
        }
        public Response UpdateMaxCapacity(SpaceTraining _space)
        {
            Response responseValidate = Validate(_space);
            if (responseValidate.Success)
            {
                Response response = spaceDAL.UpdateMaxCapacity(_space);
                return response;
            }
            return responseValidate;
        }
        public SingleResponse<Operator> CheckHowToCreate(SpaceTraining _space)
        {
            SingleResponse<Operator> response = new SingleResponse<Operator>();
            Operator op = new Operator();

            Response responseValidate = Validate(_space);
            if (responseValidate.Success)
            {
                //o usuário irá informar a menor sala que ele tem disponível
                PersonBLL personBLL = new PersonBLL();
                QueryResponse<Person> r0 = personBLL.GetAllList();
                int totalPersons = r0.Data.Count;
                int personsPerRoom = _space.MaxCapacity;

                int remains = totalPersons % personsPerRoom;
                int division = totalPersons / personsPerRoom;
                int totalSpaces;
                int totalSpaceFull;

                //se o remains (resto) for igual a zero, significa que podemos distribuir as pessoas nas salas em quantidades iguais e o total de salas será o divisor
                op.IsAllFull = false;
                if (remains == 0)
                {
                    totalSpaces = division;
                    op.IsAllFull = true;
                }
                else //caso contrário, acrescentamos +1 sala para todos serem alocados
                {
                    totalSpaces = division + 1;
                }

                //preciso saber a quantidade total de salas cheias
                //a menor sala será a quantidade máxima que poderá ter em cada sala, existirão salas cheias e salas não cheias em que colocarei personsPerRoom -1, pois assim a diferença de pessoas entre as salas será de no máximo 1
                //e também tem outra questão, o usuário cadastrou a menor sala, ok, mas isso não significa que todas as outras terão capacidade a mais, então é melhor que a lotação máxima da menor sala seja também o máximo de pessoas que serão alocadas

                //a formula abaixo irá me ceder quantas salas cheias existirão
                //total de pessoas: 40
                //totalSpaces = 40 / 6 (o divisor é 6, então o totalSpaces é 6 + 1 = 7)
                //t = 40 + (1 - 6) * 7
                //t = 40 + 7 - 42
                //t = 5 (o total de salas cheias será igual a 5, então 5 salas terão capacidade 6 e 2 salas terão capacidade 5
                //ou seja, lugar para 40 pessoas conforme pedi
                //em algumas contas, o total de lugares fica acima do total de pessoas, mas não importa, haverá lugares para todo mundo respeitando regras do desafio

                totalSpaceFull = totalPersons + (1 - personsPerRoom) * totalSpaces;
                if (totalSpaceFull > 0) 
                {
                    //se cair aqui, apresentamos total de salas cheias e não cheias com respectivas capacidades
                    if (totalSpaceFull < 0)
                    {
                        op.TotalSpaceFull = totalSpaceFull + (-totalSpaceFull * 2);
                    }
                    else
                    {
                        op.TotalSpaceFull = totalSpaceFull;
                    }

                    op.PersonsPerFullRoom = personsPerRoom;
                    op.PersonsPerNotFullRoom = personsPerRoom - 1;
                    op.TotalSpaceNotFull = totalSpaces - op.TotalSpaceFull;
                    response.Data = op;

                    SingleResponse<SpaceTraining> r1 = this.Get(_space);
                    r1.Data.MaxCapacity = op.PersonsPerFullRoom;
                    this.UpdateMaxCapacity(r1.Data); 
                }
                else 
                {
                    //se cair aqui, apresentamos total de salas cheias com sua respectiva capacidade

                    if (totalPersons % personsPerRoom != 0)
                    {
                        List<int> x = new List<int>();

                        //encontrando o número ideal de pessoas por sala, garantindo que o resto da divisão resulte em zero
                        for (int i = 1; i <= personsPerRoom; i++)
                        {
                            if (totalPersons % i == 0)
                            {
                                x.Add(i);
                            }
                        }
                        personsPerRoom = x.Max();
                        totalSpaces = totalPersons / personsPerRoom;
                    }

                    op.TotalSpaceFull = totalSpaces;
                    op.TotalSpaceNotFull = 0;
                    op.PersonsPerFullRoom = personsPerRoom;
                    op.PersonsPerNotFullRoom = 0;
                    op.IsAllFull = true; 
                    response.Data = op;
                    
                    SingleResponse<SpaceTraining> r1 = this.Get(_space);
                    r1.Data.MaxCapacity = op.PersonsPerFullRoom;
                    this.UpdateMaxCapacity(r1.Data);
                }
                response.Success = true;
                return response;
            }
            else
            {
                response.Message = responseValidate.Message;
                response.Success = false;
                return response;
            }
        }
    }
}
