using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace VehicleTransports
{
    class CShip: CVehicle
    {
        public CShip(int maxspeed, int price, int year, int passengers, string homeport, Point2D coordinates)
        {
            MaxSpeed = maxspeed;
            Price = price;
            ReleaseYear = year;
            HomePort = homeport; 
            PassengerCapacity = passengers;
            CoordinatesXY = coordinates;
        }

        public override int MaxSpeed { get; }
        public override int Price { get; protected set; }
        public override int ReleaseYear { get; }
        public int PassengerCapacity { get; }
        public string HomePort { get; set; }
        public Point2D CoordinatesXY { get; set; }



        public override string ToString()
        {
            return $"CShip  info: MaxSpeed={MaxSpeed}, Price={Price}, ReleaseYear={ReleaseYear}, PassengerCapacity={PassengerCapacity}, HomePort={HomePort}, CoordinatesXY={CoordinatesXY.ToString()}";
        }
    }
}
