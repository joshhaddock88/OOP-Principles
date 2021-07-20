using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals
{
    public abstract class Reptiles
    {
        public abstract bool ExtendableTongue { get; set; }
        public virtual int TailCondition {get; set; }

        public virtual void RegrowTail(int condition)
        {
            condition += 2;
            Console.WriteLine("The tail is damaged, but over time it gets better.");
            Console.WriteLine($"If the tail looks like a {condition} out of 10 right now... " +
                $"In just one week it will be a {condition} out of 10!");
        }
    }
}
