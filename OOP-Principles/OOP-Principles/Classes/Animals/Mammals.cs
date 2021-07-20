using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public abstract class Mammals
    {
        public virtual bool Nocturnal { get; set; }
        public virtual string Groups { get; set; }

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
