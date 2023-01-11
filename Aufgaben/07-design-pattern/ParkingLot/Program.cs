using System.Threading;
using System;

namespace ParkingLot
{
    class Program
    {
        private const int maxFillIntervalMillis = 1000;
        private const int maxEmptyIntervalMillis = 2000;
        private const int initialFillPhaseMillis = 5000;
        private const int refreshDisplayIntervalMillis = 250;

        static void Main(string[] args)
        {
            ParkingLot bahnhofParking = new("Bahnhof Parking", 100);
            Thread fill = new(Program.FillParkingLots);
            Thread empty = new(Program.EmptyParkingLots);
            Thread display = new(Program.Display);

            display.Start(bahnhofParking);
            fill.Start(bahnhofParking);
            Thread.Sleep(initialFillPhaseMillis);
            empty.Start(bahnhofParking);

            fill.Join();
            empty.Join();
            display.Join();
        }

        public static void FillParkingLots(object data)
        {
            Random random = new();
            ParkingLot lot = (ParkingLot)data;
            while (lot.Occupied < lot.Capacity)
            {
                lot.Enter();
                Thread.Sleep(random.Next() % maxFillIntervalMillis);
                Console.WriteLine($"A car entered the lot '{lot.Name}'.");
            }
        }

        public static void EmptyParkingLots(object data)
        {
            Random random = new();
            ParkingLot lot = (ParkingLot)data;
            while (lot.Occupied > 0)
            {
                lot.Exit();
                Thread.Sleep(random.Next() % maxEmptyIntervalMillis);
                Console.WriteLine($"A car left the lot '{lot.Name}'.");
            }
        }

        public static void Display(object data)
        {
            ParkingLot lot = (ParkingLot)data;
            while (true)
            {
                Console.WriteLine($"{lot.Name}: {lot.Occupied}/{lot.Capacity} occupied");
                Thread.Sleep(refreshDisplayIntervalMillis);
            }
        }
    }
}
