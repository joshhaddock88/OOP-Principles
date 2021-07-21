using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interfaces
{
    interface ISwim
    {
        bool LivesUnderWater { get; set; }
        void SwimmingMechanics();
        string OxygenIntake { get; set; }
    }
}
