using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interfaces
{
    interface IChiropteraInsectivora
    {
        bool Venomous { get; set; }
        void EchoLocation();
        string InsectivoraOrChiroptera { get; set; }
    }
}
