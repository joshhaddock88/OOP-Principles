using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals
{
    public abstract class Birds
    {
        public virtual string Migratory { get; set; }
        public abstract bool Perching { get; set; }
        public abstract int Speed { get; set; }

        public virtual int Fly(int speed)
        {
            Console.WriteLine($"This bird can fly as fast as {speed} miles per hour!");
            return speed;
        }
    }
}
