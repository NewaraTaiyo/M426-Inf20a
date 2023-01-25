using System;

namespace ParkingLot;

public class Display : ISubscriber
{
    public void Update(Message message)
    {
        DisplayOccupancy(message);
    }

    private static void DisplayOccupancy(Message message)
    {
        Console.WriteLine(
            $"{message.ChangeOfOccupancyMessage} {message.Name}: {message.Occupied}/{message.Capacity} occupied");
    }
}