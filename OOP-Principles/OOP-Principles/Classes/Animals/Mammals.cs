using OOP_Principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Mammals
{
    public abstract class Mammals : Animals
    {
        public virtual bool Nocturnal { get; set; }
        public virtual string Groups { get; set; }

        public virtual bool HasFur { get; set; } = true;

        public virtual void IsNursing()
        {
            Console.WriteLine("All mammals nurse! It's what makes them mammals!");
        }
        public virtual void Swimming()
        {
            Console.WriteLine("This animal loves to swim!");
        }
    }
}
