using System.Collections.Generic;
using Ucu.Poo.Cognitive;

namespace Ucu.Poo.RideShare
{
    public class UcuRideShare
    {
        private List<User> users = new List<User>();
        private DiscordPublisher publisher;
        private CognitiveFace faceRecognizer;

        public UcuRideShare(DiscordPublisher publisher, CognitiveFace faceRecognizer)
        {
            this.publisher = publisher;
            this.faceRecognizer = faceRecognizer;
        }

        public void Add(User user)
        {
            if (user.EsFotoValida(this.faceRecognizer))
            {
                this.users.Add(user);
                this.publisher.Publicar(user);
            }
        }
    }
}