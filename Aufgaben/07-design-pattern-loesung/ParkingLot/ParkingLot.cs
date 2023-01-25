using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace ParkingLot
{
    public class ParkingLot : IPublisher
    {
        private List<ISubscriber> subscribers = new();
        public string Name { get; }
        public int Capacity { get; }
        public int Occupied { get; set; }

        public ParkingLot(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Occupied = 0;
        }

        public void Attach(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void Detach(ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Enter()
        {
            if (Occupied < Capacity)
            {
                Occupied++;
            }
            else
            {
                throw new InvalidOperationException("parking lot is full");
            }

            Notify("A car entered the lot");
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Exit()
        {
            if (Occupied > 0)
            {
                Occupied--;
            }
            else
            {
                throw new InvalidOperationException("parking lot is empty");
            }

            Notify("A car left the lot");
        }

        public void Notify(string changeOfOccupancyMessage)
            => subscribers.ForEach(x => x.Update(
                new Message(
                    changeOfOccupancyMessage,
                    Name,
                    Occupied,
                    Capacity)));
    }
}