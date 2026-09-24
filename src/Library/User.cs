using System.Dynamic;

namespace Ucu.Poo.RideShare
{
    public abstract class User
    {
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string Id { get; set; }
        protected string Photo { get; set; }

        protected User(string name, string lastname, string id, string photo)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Id = id;
            this.Photo = photo;
        }

        public abstract void PublicarEnDiscord();

    }

}