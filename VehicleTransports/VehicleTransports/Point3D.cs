using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Point3D: Point2D
    {
        public Point3D(int x, int y, int z): base (x,y)
        {
            Z = z;
        }

        public int Z { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()},{Z}";
        }
    }
}
