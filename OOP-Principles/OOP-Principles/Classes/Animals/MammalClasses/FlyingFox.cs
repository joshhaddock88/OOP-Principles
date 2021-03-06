using System;
using OOP_Principles.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Mammals.FlyingFox
{
    public class FlyingFox : Mammals, IChiropteraInsectivora
    {
        public bool IsCute { get; set; } = true;
        public int WingSpan { get; set; } = 6;
        public override int LegNumber { get; set; } = 2;
        public override bool Carnivore { get; set; } = false;
        public override string Species { get; set; } = "Flying Fox";
        public override bool LaysEggs { get; set; } = false;
        public override bool Nocturnal { get; set; } = true;
        public bool Venomous { get; set; } = false;

        public void Fly()
        {
            Console.WriteLine($"Flying Foxes are the largest flying mammal with a wingspan of {WingSpan}!");
        }
        public override void Eat()
        {
            Console.WriteLine("Flying foxes may look big and scary, but they eat almost exclusively fruit!");
        }

        public override void Sleep()
        {
            if(Nocturnal == true)
            {
                Console.WriteLine("Like most bats, Flying Foxes are mostly nocturnal and sleep during the day, hanging upside down.");
            }
            else
            {
                Console.WriteLine("Most bats are nocturnal, but I can't confirm whether that's true for the flying fox");
            }
        }

        public override void IsNursing()
        {
            base.IsNursing();
        }

        public void EchoLocation()
        {
            Console.WriteLine("While many bats have echo location, flying foxes do not. " +
                "They just have large eyes which are sensitive to light.");
        }

        public string InsectivoraOrChiroptera { get; set; } = "Chiroptera";
    }
}
