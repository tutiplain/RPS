using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Services
{
    public class RandomNumberService : IRandomNumberService
    {
        public Random rnd { get; set; }

        public RandomNumberService()
        {
            rnd = new Random();
        }

        public int getRandom(int min,int max)
        {
            return rnd.Next(min, max);
        }

    }
}
