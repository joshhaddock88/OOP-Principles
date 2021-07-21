using System;
using OOP_Principles.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Birds.Penguin
{
    public class Penguin : Birds, ISwim
    {
        public override bool Perching { get; set; } = false;
        public override int Speed { get; set; } = 5;
        public override int LegNumber { get; set; } = 2;
        public override bool Carnivore { get; set; } = true;
        public override string Species { get; set; } = "Penguin";
        public override bool LaysEggs { get; set; } = true;
        public bool LivesUnderWater { get; set; } = false;
        public string OxygenIntake { get; set; } = "Lungs";

        public override void Migratory()
        {
            Console.WriteLine("Penguins can migrate over 100 miles!");
        }

        public override void Eat()
        {
            Console.WriteLine("A penguins diet consists mainly of small fish they get from the ocean!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Penguins sleep for only a few minutes at a time! They get their rest by taking dozens of tiny naps throughout the day!");
        }

        public void SwimmingMechanics()
        {
            Console.WriteLine("Penguins have webbed feet and aerodynamic bodies that makes " +
                "for excellent swimmers. Their slick fur and cylindrical bodies glide through " +
                "the ocean with ease.");
        }
    }
}
