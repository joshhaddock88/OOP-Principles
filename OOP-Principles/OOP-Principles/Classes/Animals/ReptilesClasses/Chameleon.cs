using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Reptiles.Chameleon
{
    class Chameleon : Reptiles
    {
        public string Color { get; set; } = "Green";
        public override bool ExtendableTongue { get; set; } = true;
        public override bool WarmBlooded { get; set; } = false;
        public override int LegNumber { get; set; } = 4;
        public override bool Carnivore { get; set; } = true;
        public override string Species { get; set; } = "Chameleon";
        public override bool LaysEggs { get; set; } = true;

        public void ChangeColor(string color)
        {
            Console.WriteLine($"Look, the Chameleon is changing color! They're currently {Color}!");
            Color = color;
            Console.WriteLine($"And now they're {Color}!");
        }
        public override void Eat()
        {
            Console.WriteLine("They eat insects: grasshoppers, locusts, mantids etc.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Chameleons sleep around 12 hours a night.");
        }
    }
}
