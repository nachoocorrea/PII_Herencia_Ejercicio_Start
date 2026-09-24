using System.Runtime.CompilerServices;

namespace Ucu.Poo.RideShare
{
    public class CommonDriver : Driver
    {
        public CommonDriver(string name, string lastName, string id, string photo, Vehicle vehicle,
        string bio) : base (name, lastName, id, photo, vehicle, bio)
        {
        }
    }
}