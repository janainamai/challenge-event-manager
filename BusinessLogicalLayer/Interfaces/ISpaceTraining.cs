using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface ISpaceTraining : IEntitiesCRUD<ISpaceTraining>
    {
        SingleResponse<SpaceTraining> GetSmallerSpace();
        QueryResponse<SpaceTraining> GetSpaceWithEmptySeat(int personsPerRoom);
        Response UpdateMaxCapacity(SpaceTraining _space);
        int GetTotalCapacity();
    }
}
