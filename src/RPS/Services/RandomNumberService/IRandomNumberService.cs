using System;

namespace RPS.Services
{
    public interface IRandomNumberService
    {
        Random rnd { get; set; }

        int getRandom(int min, int max);
    }
}