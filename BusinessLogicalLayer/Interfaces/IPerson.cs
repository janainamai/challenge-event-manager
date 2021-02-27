using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IPerson : IEntitiesCRUD<Person>
    {
         TableResponse GetAllByStage1IDASC();
         TableResponse GetAllByStage1ID(SpaceTraining _space);
         TableResponse GetAllByStage2ID(SpaceTraining _space);
         TableResponse GetAllByCoffeeID();
         TableResponse GetNamesOnly();
         Response UpdateStage1ID(SpaceTraining _space, Person _person);
         Response UpdateStage2ID(SpaceTraining _space, Person _person);
         Response UpdateStage2IDInformingInt(int _newID, Person _person);
         Response UpdateCoffeeID(int _newID, Person _person);
         QueryResponse<Person> GetPeopleByStage1ID(SpaceTraining _space);
         Response CheckDistributionOfPeopleIsPossible();
         Response OrganizeFirstStage();
         Response OrganizeSecondStage();
         Response OrganizeBreakTime();
    }
}
