using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Mammals.Hippo
{
    public class Hippo : Mammals
    {
        public override string Groups { get; set; } = "Hippos are social, usually congregating in groups of 10-30.";
        public override bool WarmBlooded { get; set; } = true;
        public override int LegNumber { get; set; } = 4;
        public override bool Carnivore { get; set; } = false;
        public override string Species { get; set; } = "Hippopotamus";
        public override bool LaysEggs { get; set; } = false;

        public string Graze()
        {
            string grazingHabits = "Hippos do, in fact, graze";
            return grazingHabits;
        }
        public override void Eat()
        {
            string grazingHabits = Graze();
            Console.WriteLine($"{grazingHabits}, but they also eat lots of things.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Hippos sleep and astonishing 16 hours a night!");
        }
    }
}
