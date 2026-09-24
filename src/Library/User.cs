using Ucu.Poo.Cognitive;

namespace Ucu.Poo.RideShare
{
    public abstract class User
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string Id { get; protected set; }
        public string Photo { get; protected set; }

        protected User(string name, string lastName, string id, string photo)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
            this.Photo = photo;
        }

        public abstract string ObtenerMensajeBienvenida();

        public abstract bool EsFotoValida(CognitiveFace faceRecognizer);
    }
}