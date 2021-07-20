using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Birds.Hawk
{
    public class Hawk : Birds
    {
        public int DiveSpeed { get; set; } = 120;
        public override bool Perching { get; set; } = true;
        public override int Speed { get; set; } = 15;
        public override bool WarmBlooded { get; set; } = true;
        public override int LegNumber { get; set; } = 2;
        public override bool Carnivore { get; set; } = true;
        public override string Species { get; set; } = "Hawk";
        public override bool LaysEggs { get; set; } = true;

        public override void Eat()
        {
            Console.WriteLine("Hawks eat mostly field mice and small rodents.");
        }

        public override void Fly()
        {
            Console.WriteLine($"Some hawks can dive at a speed of {DiveSpeed}mph!");
            Console.WriteLine($"Though, when they're just gliding about they'll move closer to {Speed}.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Hawks sleep high up in trees close the trunk, and are incredibly light sleepers!");
        }
    }
}
