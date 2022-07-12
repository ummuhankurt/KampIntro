using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class GamerManager : IGamerService
    {

        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " added");
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
        }

        public void Delete(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " deleted");
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
        }

        public void Update(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " updated");
            }
            else
            {
                Console.WriteLine("Not a valid person.");
            }
        }
    }
}
