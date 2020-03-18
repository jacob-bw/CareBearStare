using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class GrumpyBear : CareBearBase
    {
        public GrumpyBear()
        {
            BellyBadge = "Rain Cloud";
            Color = BearColor.Blue;
            Name = "Grumpy Bear";
        }

        public override void Stare()
        {
            Console.WriteLine("Stares aggressively into the distance while shooting a beam from his belly");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Grumpy Bear Hates Hugs and insteads shuns {careBearToHug.Name}.");
        }
    }
}
