using OOP_Principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Mammals.Shrew
{
    public class Shrew : Mammals, IChiropteraInsectivora
    {
        public override bool HasFur { get; set; } = true;
        public override int LegNumber { get; set; } = 4;
        public override bool Carnivore { get; set; } = true;
        public override string Species { get; set; } = "Shrew";
        public override bool LaysEggs { get; set; } = false;

        public override void Eat()
        {
            Console.WriteLine("Shrews eat primarily bugs.");
            if (Venomous == true)
            {
                Console.WriteLine("They are also one of the few venomous mammals, with a bite strong enough to kill 200 mice. " +
                    "They're rarely dangerous to humans though.");
            }
        }

        public void EchoLocation()
        {
            Console.WriteLine("Some shrews use echolocation to see inside their tunnels!");
        }

        public string InsectivoraOrChiroptera { get; set; } = "Insectivora";

        public override void Sleep()
        {
            Console.WriteLine("Shrews only live for about 14 months and rarely sleep.");
        }

        public bool Venomous { get; set; } = true;
    }
}
