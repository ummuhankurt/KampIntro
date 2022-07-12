using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    class NewUserCheck : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return false;
        }
    }
}
