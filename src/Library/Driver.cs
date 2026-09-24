using System;
using Ucu.Poo.Discord;
using Ucu.Poo.Cognitive;

namespace Ucu.Poo.RideShare
{
    public class Driver : User
    {
        public Vehicle Vehicle { get; set; }
        public double Rating { get; set; }
        public string Bio { get; set; }
        public bool NeedGlasses { get; set; }
        public Driver( string name, string lastName, string id, string photo,
        Vehicle vehicle, string bio, bool needGlasses)
        : base (name, lastName, id, photo)
        {
            this.Vehicle = vehicle;
            this.Bio = bio;
            this.Rating = 0;
            this.NeedGlasses = needGlasses;
        }

        public override string ObtenerMensajeBienvenida()
        {
            return $"¡Bienvenido/a {this.Name} {this.LastName} como nuevo conductor de UCURide! Bio: {this.Bio}";
        }

        public override bool EsFotoValida(CognitiveFace faceRecognizer)
        {
            CognitiveFace.RecognitionResult resultado = faceRecognizer.Recognize(this.Photo);
            if (!resultado.Success)
            {
                return false;
            }

            return !this.NeedGlasses || resultado.GlassesFound;
        }
    }
}
