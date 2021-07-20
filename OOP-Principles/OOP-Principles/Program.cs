using System;
using OOP_Principles.Classes.Animals.Mammals.Shrew;
using OOP_Principles.Classes.Animals.Mammals.Hippo;
using OOP_Principles.Classes.Animals.Reptiles.Chameleon;

namespace OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAnimalStats();
        }

        static void DisplayAnimalStats()
        {
            Shrew MyShrew = new Shrew();
            Hippo MyHippo = new Hippo();
            Console.WriteLine($"{MyHippo.Species}");
            Chameleon MyChameleon = new Chameleon();
            MyChameleon.ChangeColor("purple");
            
        }
    }
}
