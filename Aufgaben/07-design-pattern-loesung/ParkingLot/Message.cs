namespace ParkingLot;

public class Message
{
    public Message(
        string changeOfOccupancyMessage,
        string name,
        int occupied,
        int capacity)
    {
        ChangeOfOccupancyMessage = changeOfOccupancyMessage;
        Name = name;
        Occupied = occupied;
        Capacity = capacity;
    }

    public string ChangeOfOccupancyMessage { get; }

    public string Name { get; }

    public int Occupied { get; }

    public int Capacity { get; }
}