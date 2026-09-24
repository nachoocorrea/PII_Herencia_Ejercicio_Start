using System;

namespace Ucu.Poo.RideShare
{
    public class Passenger : User
    {
        public double Rating { get; set; }

        public Passenger( string name, string lastName, string id, string photo)
        : base (name, lastName, id, photo)
        {
            this.Rating = 0;
        }

        public override void PublicarEnDiscord()
        {
            Console.WriteLine($"¡Bienvenido/a {this.Name} {this.LastName} a UCURide!");
            Console.WriteLine($"Foto: {this.Photo}");
        }
    }
}
