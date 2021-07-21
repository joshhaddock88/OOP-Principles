using System;
using OOP_Principles.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Mammals.Hippo
{
    public class Hippo : Mammals, ISwim, IGroupStyle
    {
        public override int LegNumber { get; set; } = 4;
        public override bool Carnivore { get; set; } = false;
        public override string Species { get; set; } = "Hippopotamus";
        public override bool LaysEggs { get; set; } = false;
        public bool LivesUnderWater { get; set; } = false;
        public string OxygenIntake { get; set; } = "Lungs";

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

        public void SwimmingMechanics()
        {
            Console.WriteLine("Hippos aren't particularly fast swimmers, they much more " +
                "spry on land. However they do spend a lot fo time in the water, mostly moving by " +
                "sinking to the bottom of their body of water and then pushing off with their " +
                "strong legs.");
        }

        public void GroupSize()
        {
            Console.WriteLine("Hippos are typically in groups that range between 15-30, although groups as " +
                "large as 100 have been seen.");
        }

        public void FamilyUnit()
        {
            Console.WriteLine("While hippos huddle often, they do not form social bonds " +
                "(except between mothers and daughters).");
        }

        public string MatingHabits()
        {
            return "Hippos are polygamists";
        }

        public string Hierarchy { get; set; } = "Complex";
    }
}
