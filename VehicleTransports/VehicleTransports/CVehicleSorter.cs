using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTransports
{
    static class CVehicleSorter
    {
        public static void PrintVehicles(CVehicle[] vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        public static CVehicle[] SortMaxSpeed(CVehicle[] vehicles)
        {
            int[] vehicleFilterArray = new int[vehicles.Length];

            for (var i = 0; i < vehicles.Length; i++)
            {
                vehicleFilterArray[i] = vehicles[i].MaxSpeed;
            }

            Array.Sort(vehicleFilterArray);
            Array.Reverse(vehicleFilterArray);
            CVehicle[] sortedVehicles = new CVehicle[vehicles.Length];

            foreach (var item in vehicles)
            {
                bool gotPosition = false;
                int i = 0;

                while (gotPosition == false)
                {
                    if ((item.MaxSpeed == vehicleFilterArray[i]) && (sortedVehicles[i] == null))
                    {
                        sortedVehicles[i] = item;
                        gotPosition = true;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }

            return sortedVehicles;
        }

        public static CVehicle[] SortMaxPrice(CVehicle[] vehicles)
        {
            int[] vehicleFilterArray = new int[vehicles.Length];

            for (var i = 0; i < vehicles.Length; i++)
            {
                vehicleFilterArray[i] = vehicles[i].Price;
            }

            Array.Sort(vehicleFilterArray);
            Array.Reverse(vehicleFilterArray);
            CVehicle[] sortedVehicles = new CVehicle[vehicles.Length];

            foreach (var item in vehicles)
            {
                bool gotPosition = false;
                int i = 0;

                while (gotPosition == false)
                {
                    if ((item.Price == vehicleFilterArray[i]) && (sortedVehicles[i] == null))
                    {
                        sortedVehicles[i] = item;
                        gotPosition = true;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }

            return sortedVehicles;
        }

        public static CVehicle[] SortMaxReleaseYear(CVehicle[] vehicles)
        {
            int[] vehicleFilterArray = new int[vehicles.Length];

            for (var i = 0; i < vehicles.Length; i++)
            {
                vehicleFilterArray[i] = vehicles[i].ReleaseYear;
            }

            Array.Sort(vehicleFilterArray);
            Array.Reverse(vehicleFilterArray);
            CVehicle[] sortedVehicles = new CVehicle[vehicles.Length];

            foreach (var item in vehicles)
            {
                bool gotPosition = false;
                int i = 0;

                while (gotPosition == false)
                {
                    if ((item.ReleaseYear == vehicleFilterArray[i]) && (sortedVehicles[i] == null))
                    {
                        sortedVehicles[i] = item;
                        gotPosition = true;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }

            return sortedVehicles;
        }
    }
}
