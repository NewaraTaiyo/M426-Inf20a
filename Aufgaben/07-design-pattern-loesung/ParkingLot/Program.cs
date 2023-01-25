using System.Threading;
using System;

namespace ParkingLot
{
    class Program
    {
        private const int maxFillIntervalMillis = 1000;
        private const int maxEmptyIntervalMillis = 2000;
        private const int initialFillPhaseMillis = 5000;

        static void Main(string[] args)
        {
            ParkingLot bahnhofParking = new("Bahnhof Parking", 100);
            bahnhofParking.Attach(new Display());
            Thread fill = new(Program.FillParkingLots);
            Thread empty = new(Program.EmptyParkingLots);


            fill.Start(bahnhofParking);
            Thread.Sleep(initialFillPhaseMillis);
            empty.Start(bahnhofParking);

            fill.Join();
            empty.Join();
        }

        public static void FillParkingLots(object data)
        {
            Random random = new();
            ParkingLot lot = (ParkingLot)data;
            while (lot.Occupied < lot.Capacity)
            {
                lot.Enter();
                Thread.Sleep(random.Next() % maxFillIntervalMillis);
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
            }
        }
    }
}