using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace VehicleTransports
{
    class CPlane: CVehicle
    {
        public CPlane(int maxspeed, int price, int year, int passengers, Point3D coordinates)
        {
            MaxSpeed = maxspeed;
            Price = price;
            ReleaseYear = year;
            PassengerCapacity = passengers;
            CoordinatesXYZ = coordinates;
        }

        public override int MaxSpeed { get; }
        public override int Price { get; protected set; }
        public override int ReleaseYear { get; }
        public int PassengerCapacity { get; }
        public Point3D CoordinatesXYZ { get; set; }



        public override string ToString()
        {
            return $"CPlane info: MaxSpeed={MaxSpeed}, Price={Price}, ReleaseYear={ReleaseYear}, PassengerCapacity={PassengerCapacity}, CoordinatesXYZ={CoordinatesXYZ.ToString()}";
        }
    }
}
