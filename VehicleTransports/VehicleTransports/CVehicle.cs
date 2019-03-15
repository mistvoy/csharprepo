using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace VehicleTransports
{
    abstract class CVehicle
    {
        abstract public int MaxSpeed { get; }
        abstract public int Price { get; protected set; }
        abstract public int ReleaseYear { get; }
        abstract public override string ToString();
    }
}
