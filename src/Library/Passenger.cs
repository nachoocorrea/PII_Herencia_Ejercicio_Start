using System;
using Ucu.Poo.Discord;
using Ucu.Poo.Cognitive;

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

        public override string ObtenerMensajeBienvenida()
        {
            return $"¡Bienvenido/a {this.Name} {this.LastName} a UCURide!";
        }

        public override bool EsFotoValida(CognitiveFace faceRecognizer)
        {
            CognitiveFace.RecognitionResult resultado = faceRecognizer.Recognize(this.Photo);
            return resultado.Success && resultado.FaceFound;
        }
    }
}
