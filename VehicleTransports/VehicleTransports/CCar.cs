using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace VehicleTransports
{
    class CCar: CVehicle
    {
        public CCar(int maxspeed, int price, int year, Point2D coordinates)
        {
            MaxSpeed = maxspeed;
            Price = price;
            ReleaseYear = year;
            CoordinatesXY = coordinates;
        }

         public override int MaxSpeed { get; }
         public override int Price { get; protected set; }
         public override int ReleaseYear { get; }
         public Point2D CoordinatesXY { get; set; }


        public override string ToString()
        {
            return $"CCar   info: MaxSpeed={MaxSpeed}, Price={Price}, ReleaseYear={ReleaseYear}, CoordinatesXY={CoordinatesXY.ToString()}";
        }
    }
}
