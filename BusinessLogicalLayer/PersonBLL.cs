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
    public class PersonBLL : BaseValidator<Person>
    {
        PersonDAL personDAL = new PersonDAL();
        public override Response Validate(Person item)
        {
            AddError(item.Name.IsValidName());
            AddError(item.Surname.IsValidSurname());
            return base.Validate(item);
        }
        public TableResponse GetByNameViewModel(Person _person)
        {
            TableResponse response = personDAL.GetByNameViewModel(_person);
            return response;
        }
        public TableResponse GetViewModel()
        {
            TableResponse response = personDAL.GetViewModel();
            return response;
        }
        public Response Insert(Person person)
        {
            person.FullName = person.Name + " " + person.Surname;
            Response responseValidate = Validate(person);
            if (responseValidate.Success)
            {
                Response response = personDAL.Insert(person);
                return response;
            }
                return responseValidate;
        }
        public Response DeleteAll()
        {
            Response response = personDAL.DeleteAll(); ;
            return response;
        }
        public TableResponse GetAllTable()
        {
            TableResponse tableResponse = personDAL.GetAllTable();
            return tableResponse;
        }
        public TableResponse GetByName(Person _person)
        {
            TableResponse response = personDAL.GetByName(_person);
            return response;
        }
        public TableResponse GetAllByStage1IDASC()
        {
            TableResponse tableResponse = personDAL.GetAllByStage1IDASC();
            return tableResponse;
        }
        public TableResponse GetAllByStage1ID(SpaceTraining _space)
        {
            TableResponse response = personDAL.GetAllByStage1ID(_space);
            return response;
        }
        public TableResponse GetAllByStage2ID(SpaceTraining _space)
        {
            TableResponse response = personDAL.GetAllByStage2ID(_space);
            return response;
        }
        public TableResponse GetAllByCoffeeID(SpaceCoffee _space)
        {
            TableResponse response = personDAL.GetAllByCoffeeID(_space);
            return response;
        }
        public TableResponse GetNamesOnly()
        {
            TableResponse tableResponse = personDAL.GetNamesOnly();
            return tableResponse;
        }
        public QueryResponse<Person> GetAllList()
        {
            QueryResponse<Person> response = personDAL.GetAllList();
            return response;
        }
        public Response UpdateStage1ID(SpaceTraining _space, Person _person)
        {
            Response response = personDAL.UpdateStage1ID(_space, _person);
            return response;
        }
        public Response UpdateStage2ID(SpaceTraining _space, Person _person)
        {
            Response response = personDAL.UpdateStage2ID(_space, _person);
            return response;
        }
        public Response UpdateStage2IDInformingInt(int _newID, Person _person)
        {
            Response response = personDAL.UpdateStage2IDInformingInt(_newID, _person);
            return response;
        }
        public Response UpdateCoffeeID(int _newID, Person _person)
        {
            Response response = personDAL.UpdateCoffeeID(_newID, _person);
            return response;
        }
        public QueryResponse<Person> GetPeopleByStage1ID(SpaceTraining _space)
        {
            QueryResponse<Person> response = personDAL.GetPeopleByStage1ID(_space);
            return response;
        }
        public Response OrganizeFirstStage()
        {
            Response response = new Response();

            // aqui está a distribuição de pessoas nas salas para primeira etapa 

            SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();

            //lista de todas as pessoas
            QueryResponse<Person> r3 = this.GetAllList();
            List<Person> listPersons = r3.Data;

            if (listPersons.Count > 0)
            {
                //lista e contagem de todas as salas de treinamento 
                QueryResponse<SpaceTraining> r4 = spaceBLL.GetAllList();
                List<SpaceTraining> listSpaces = r4.Data;

                if (listSpaces.Count > 0)
                {
                    // >>>> executa a partir de agora distribuição de pessoas para etapa 1

                    foreach (SpaceTraining s in listSpaces)
                    {
                        //pegar capacidade total desta sala maxCapacity
                        SingleResponse<SpaceTraining> r0 = spaceBLL.Get(s);
                        int final = r0.Data.MaxCapacity;
                        
                        for (int i = 1; i <= final; i++)
                        {
                            foreach (Person p in listPersons)
                            {
                                Response r5 = this.UpdateStage1ID(s, p);
                                Response r6 = this.UpdateStage2ID(s, p);
                                listPersons.Remove(p);
                                break;
                            }
                            if (listPersons.Count == 0)
                                break;
                        }
                        if (listSpaces.Count == 0)
                            break;
                    }

                    response.Success = true;
                    response.Message = "Dados inseridos com sucesso.";
                    return response;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Não há salas cacastradas.";
                    return response;
                }
            }
            else
            {
                response.Success = false;
                response.Message = "Não há pessoas cadastradas.";
                return response;
            }
        }
        public Response OrganizeSecondStage()
        {
            Response response = new Response();

            int half;
            int totalSpaces = 0;
            //Pelo menos metade das pessoas de cada sala deve trocar de sala, para estimular a troca de informações

            //pegar quantidade total de salas de treinamento e colocar em uma listSpaces
            SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
            QueryResponse<SpaceTraining> r1 = spaceBLL.GetAllList();
            List<SpaceTraining> listSpaces = r1.Data;

            if (listSpaces.Count > 0)
            {
                //foreach que percorre a listSpaces
                foreach (SpaceTraining spaceNow in listSpaces)
                {
                    //atualizar quantidade de salas
                    totalSpaces++;

                    //pegar a lista de pessoas que foi destinada a fazer a primeira etapa nesta sala e colocar em uma listPersons
                    QueryResponse<Person> r2 = this.GetPeopleByStage1ID(spaceNow);
                    List<Person> listPersons = r2.Data;

                    //contar quantas pessoas tem na listPersons
                    Response r3 = listPersons.Count.ToString().IsPair();

                    //se for par 
                    if (r3.Success)
                    {
                        //definir metade de pessoas a serem excluidas da lista, o que restar será trocada de sala
                        half = (listPersons.Count / 2);
                    }
                    //se for ímpar
                    else
                    {
                        //definir metade acrescentando +1 e divindo por 2, assim não teremos número quebrado e estarei trocando pelo menos metade da sala
                        half = (listPersons.Count - 1) / 2;
                    }

                    //excluir um total de half da listPersons, o que sobrar receberá o novo ID da etapa 2
                    for (int i = 1; i <= half; i++)
                    {
                        foreach (Person p in listPersons)
                        {
                            listPersons.Remove(p);
                            break;
                        }
                    }

                    //verificar se existe uma próxima sala depois desta
                    if (totalSpaces < listSpaces.Count)
                    {
                        //se cair aqui, existe outra sala depois desta, fazer foreach que percorre a newListPerson e inserir no STAGE2ID: spaceNow.ID + 1
                        foreach (Person p in listPersons.ToList())
                        {
                            int newID = spaceNow.ID + 1;
                            //chamar método que insere o ID no STAGE2ID informando newID
                            Response r4 = personDAL.UpdateStage2IDInformingInt(newID, p);
                            listPersons.Remove(p);
                        }
                    }
                    else
                    {
                        //se cair aqui, esta é a última sala existente, inserir ID da primeira sala da listSpace
                        //fazer foreach que percorrerá a primeira sala da listSpace para pegar o ID dela, e depois disso deverá sair do foreach, pois eu quero apenas a primeira sala
                        foreach (SpaceTraining firstSpace in listSpaces)
                        {
                            foreach (Person p in listPersons.ToList())
                            {
                                int newID = firstSpace.ID;
                                Response r5 = personDAL.UpdateStage2IDInformingInt(newID, p);
                                listPersons.Remove(p);
                            }
                            break;
                        }
                    }
                }

                response.Success = true;
                response.Message = "Dados inseridos com sucesso.";
                return response;
            }
            else
            {
                response.Success = false;
                response.Message = "Não existem salas cadastradas.";
                return response;
            }
        }
        public Response OrganizeBreakTime()
        {
            Response response = new Response();

            //contar quantas pessoas tem cadastradas
            QueryResponse<Person> r1 = this.GetAllList();
            List<Person> listPersons = r1.Data;
            int totalPersons = listPersons.Count;
            int half;

            if (totalPersons > 0)
            {
                //se for par, metade recebe um id, e metade recebe o outro id
                if (totalPersons.ToString().IsPair().Success)
                {
                    half = totalPersons / 2;
                }
                //se for ímpar, o half terá um número a mais para evitar números quebrados
                else
                {
                    half = (totalPersons + 1) / 2;
                }

                for (int i = 1; i <= half; i++)
                {
                    foreach (Person p in listPersons.ToList())
                    {
                        //inserir ID da sala de café 1
                        int newID = 1;
                        //chamar método que insere o ID da sala de intervalo
                        Response r2 = personDAL.UpdateCoffeeID(newID, p);
                        listPersons.Remove(p);
                        break;
                    }
                }

                foreach (Person p in listPersons.ToList())
                {
                    //inserir ID da sala de café 2
                    int newID = 2;
                    //chamar método que insere o ID da sala de intervalo
                    Response r3 = personDAL.UpdateCoffeeID(newID, p);
                    listPersons.Remove(p);
                }
                response.Message = "Dados inseridos com sucesso.";
                response.Success = true;
                return response;
            }
            else
            {
                response.Message = "Não existem pessoas cadastradas.";
                response.Success = false;
                return response;
            }
        }
    }
}
