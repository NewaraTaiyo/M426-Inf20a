namespace ParkingLot
{
    public interface IPublisher
    {
        void Notify(string changeOfOccupancyMessage);
    }

    public interface ISubscriber
    {
        void Update(Message message);
    }
}
