using System;
using System.Collections.Generic;
using CareBearStare.Bears;

namespace CareBearStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }
        }
    }
}
