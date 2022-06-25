using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    public abstract class BaseSalesManager : ISalesGameService
    {
        public void Sell(Gamer gamer)
        {
            Console.WriteLine("Sold to " + gamer.FirstName);
        }
    }
}
