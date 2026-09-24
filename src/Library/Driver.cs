using System;

namespace Ucu.Poo.RideShare
{
    public class Driver : User
    {
        public Vehicle Vehicle { get; set; }
        public double Rating { get; set; }
        public string Bio { get; set; }

        public Driver( string name, string lastName, string id, string photo,
        Vehicle vehicle, string bio)
        : base (name, lastName, id, photo)
        {
            this.Vehicle = vehicle;
            this.Bio = bio;
            this.Rating = 0;
        }

        public override void PublicarEnDiscord()
        {
            Console.WriteLine($"¡Bienvenido/a {this.Name} {this.LastName} como nuevo conductor de UCURide!");
            Console.WriteLine($"Bio: {this.Bio}");
            Console.WriteLine($"Foto: {this.Photo}");
        }
    }
}
