using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interfaces
{
    interface IGroupStyle
    {
        void GroupSize();
        void FamilyUnit();
        string MatingHabits();
        string Hierarchy { get; set; }
    }
}
