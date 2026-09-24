namespace Ucu.Poo.RideShare
{
    public class PoolDriver : Driver
    {
        public int CapacidadMaxima { get; set; }

        public PoolDriver(string name, string lastName, string id, string photo,
        Vehicle vehicle, string bio, bool needGlasses ,int capacidadMaxima)
        : base (name, lastName, id, photo, vehicle, bio, needGlasses)
        {
            this.CapacidadMaxima = capacidadMaxima;
        }
    }
}