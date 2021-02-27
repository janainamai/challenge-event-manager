using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Helper
{
    public class Operator
    {
        //totalSpaceFull = total de salas cheias
        //personsPerFullRoom = quantidade de pessoas que vão na sala cheia

        //totalSpaceNotFull = total de salas não cheias 
        //personsPerNotFullRoom = quantidade de pessoas que vão na sala não cheia

        public int TotalSpaceFull { get; set; }
        public int TotalSpaceNotFull { get; set; }
        public int PersonsPerFullRoom { get; set; }
        public int PersonsPerNotFullRoom { get; set; }
        public bool IsAllFull { get; set; }
    }
}
