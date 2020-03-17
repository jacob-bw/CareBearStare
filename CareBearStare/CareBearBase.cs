using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare
{
    class CareBearBase
    {
        public string Name { get; set; }
        public BearColor Color { get; set; }
        public string BellyBadge { get; set; }

        public abstract void Stare();

        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }
    }

    enum BearColor
    {
        Yellow,
        Pink,
        White,
        Aqua,
        Mauve,
        Purple,
        Gold,
        Blue,
        Brown
    }
}
