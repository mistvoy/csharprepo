using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace VehicleTransports
{
    class Program
    {
        static void Main(string[] args)
        {
            CCar car1 = new CCar(200, 15000, 2012, new Point2D(3, 3));
            CCar car2 = new CCar(180, 12000, 2009, new Point2D(4, 4));
            CCar car3 = new CCar(220, 21000, 2015, new Point2D(5, 8));
            CShip ship1 = new CShip(35, 100000, 2000, 90, "Odessa", new Point2D(1, 6));
            CShip ship2 = new CShip(33, 92000, 1995, 110, "Porto", new Point2D(15, 7));
            CShip ship3 = new CShip(38, 70000, 2010, 30, "Marcel", new Point2D(12, 4));
            CPlane plane1 = new CPlane(700, 330000, 2007, 50, new Point3D(1, 4, 13));
            CPlane plane2 = new CPlane(1200, 400000, 2016, 15, new Point3D(8, 2, 9));
            CPlane plane3 = new CPlane(600, 370000, 2012, 85, new Point3D(23, 5, 14));

            CVehicle[] vehicles = new CVehicle[9];
            vehicles[0] = car1;
            vehicles[1] = car2;
            vehicles[2] = car3;
            vehicles[3] = ship1;
            vehicles[4] = ship2;
            vehicles[5] = ship3;
            vehicles[6] = plane1;
            vehicles[7] = plane2;
            vehicles[8] = plane3;

            
            Console.WriteLine("Hello, please, choise an option of sorting vehicles:");
            Console.WriteLine("1. by max speed");
            Console.WriteLine("2. by max price");
            Console.WriteLine("3. by max release year");

            int userChoise = 0;

            while ((userChoise < 1) || (userChoise > 3))
            {
                Console.WriteLine(Environment.NewLine + "Please, choose option from 1 to 3:");
                String userOutput = Console.ReadLine();

                while (!int.TryParse(userOutput, out userChoise))
                {
                    Console.WriteLine(Environment.NewLine + "Not a valid integer, please, choose option from 1 to 3 once again...");
                    userOutput = Console.ReadLine();
                }
            }

            switch (userChoise)
            {
                case 1:
                    vehicles = CVehicleSorter.SortMaxSpeed(vehicles);
                    Console.WriteLine(Environment.NewLine + "CVehicles sorted by max speed:");
                    break;
                case 2:
                    vehicles = CVehicleSorter.SortMaxPrice(vehicles);
                    Console.WriteLine(Environment.NewLine + "CVehicles sorted by max price:");
                    break;
                case 3:
                    vehicles = CVehicleSorter.SortMaxReleaseYear(vehicles);
                    Console.WriteLine(Environment.NewLine + "CVehicles sorted by max release year:");
                    break;
                default:
                    Console.WriteLine(Environment.NewLine + "Unsorted list of CVehicles");
                    break;
            }

            CVehicleSorter.PrintVehicles(vehicles);


        }
    }
}
