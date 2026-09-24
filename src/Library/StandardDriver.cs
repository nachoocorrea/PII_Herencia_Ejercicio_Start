using System.Runtime.CompilerServices;

namespace Ucu.Poo.RideShare
{
    public class StandardDriver : Driver
    {
        public StandardDriver(string name, string lastName, string id, string photo, Vehicle vehicle,
        string bio, bool needGlasses) : base (name, lastName, id, photo, vehicle, bio, needGlasses)
        {
        }
    }
}