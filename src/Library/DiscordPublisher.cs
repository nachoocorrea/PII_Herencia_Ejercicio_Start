using System;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    public class DiscordPublisher
    {
        private DiscordClient discord;
        private ulong channelId;
        public DiscordPublisher(DiscordClient discord, ulong channelId)
        {
            this.discord = discord;
            this.channelId = channelId;
        }
        public void Publicar(User user)
        {
            string mensaje = user.ObtenerMensajeBienvenida();
            this.discord.SendImage(this.channelId, user.Photo, mensaje);
        }
    }
}