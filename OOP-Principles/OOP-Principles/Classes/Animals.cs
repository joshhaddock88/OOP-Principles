using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes
{
    public abstract class Animals
    {
        public abstract bool WarmBlooded { get; set; }
        public abstract int LegNumber { get; set; }
        public abstract bool Carnivore { get; set; }
        public abstract string Species { get; set; }
        public abstract bool LaysEggs { get; set; }

        public abstract void Eat();
        public abstract void Sleep();
    }
}
