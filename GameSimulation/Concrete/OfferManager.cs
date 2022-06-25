using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class OfferManager : IOfferService
    {
        public void AddOffer()
        {
            Console.WriteLine("Offer added");
        }

        public void DeleteOfer()
        {
            Console.WriteLine("Offer deleted");
        }

        public void UpdateOffer()
        {
            Console.WriteLine("Offer updated");
        }
    }
}
