using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Classes.Animals.Birds
{
    public abstract class Birds : Animals
    {
        public abstract bool Perching { get; set; }
        public abstract int Speed { get; set; }

        public virtual void Fly()
        {
            
        }

        public virtual void Migratory()
        {
            
        }
    }
}
