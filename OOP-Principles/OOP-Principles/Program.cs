using System;
using OOP_Principles.Classes.Animals.Birds.Hawk;
using OOP_Principles.Classes.Animals.Birds.Penguin;
using OOP_Principles.Classes.Animals.Reptiles.Chameleon;
using OOP_Principles.Classes.Animals.Mammals.FlyingFox;
using OOP_Principles.Classes.Animals.Mammals.Hippo;
using OOP_Principles.Classes.Animals.Mammals.Shrew;

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
            Hawk myHawk = new Hawk();
            Penguin myPenguin = new Penguin();
            Chameleon myChameleon = new Chameleon();
            FlyingFox myFlyingFox = new FlyingFox();
            Hippo myHippo = new Hippo();
            Shrew myShrew = new Shrew();
            Console.WriteLine($"At the zoo we have a {myHippo.Species}, {myHawk.Species}, " +
                $"{myPenguin.Species}, {myChameleon.Species}, {myFlyingFox.Species}, " +
                $"{myShrew.Species}");
            myPenguin.Migratory();
            myChameleon.ChangeColor("purple");
            myShrew.Eat();
            myHawk.Fly();
            myHippo.SwimmingMechanics();
            myFlyingFox.EchoLocation();
        }
    }
}
