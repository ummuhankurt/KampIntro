using GameSimulation.Abstract;
using GameSimulation.Concrete;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Id = 1, FirstName = "Ümmühan", LastName = "Kurt", DateOfBirth = new DateTime(1999, 8, 22), NationalityId = "22222222222" };
            BaseSalesManager baseSalesManager = new GameSalesManager();
            baseSalesManager.Sell(gamer);
            IGamerService gamerService = new GamerManager(new GamerCheckManager());
            gamerService.Add(gamer);
            IOfferService offerService = new OfferManager();
            offerService.AddOffer();
            Console.ReadLine();
        }
    }
}
