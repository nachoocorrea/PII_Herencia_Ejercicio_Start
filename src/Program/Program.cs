//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Discord;
using Ucu.Poo.Cognitive;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            string botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            string channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");
            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno 'DISCORD_BOT_TOKEN' y 'CHANNEL_ID'.");
                return;
            }

            string subscriptionKey = Environment.GetEnvironmentVariable("AZURE_FACE_SUBSCRIPTION_KEY");
            if (string.IsNullOrWhiteSpace(subscriptionKey))
            {
                Console.WriteLine("Falta la variables de entorno 'AZURE_FACE_SUBSCRIPTION_KEY'.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);

            DiscordClient discord = new DiscordClient();
            Console.WriteLine("Conectando con Discord...");
            discord.Login(botToken);

            CognitiveFace faceRecognizer = new CognitiveFace();
            DiscordPublisher publisher = new DiscordPublisher(discord, channelId);
            UcuRideShare rideShare = new UcuRideShare(publisher, faceRecognizer);

            Vehicle vehicle1 = new Vehicle("Toyota", "Corolla", "SBA1234");
            Vehicle vehicle2 = new Vehicle("Chevrolet", "Onix", "SBB5678");

            // Caso 1: conductor Standard, no necesita lentes -> se publica si hay cara.
            Driver conductor1 = new StandardDriver(
                "Juan", "Pérez", "12345678", "bill.jpg", vehicle1, "Me gusta la música.", false);

            // Caso 2: conductor Pool, necesita lentes -> solo se publica si la foto tiene lentes.
            Driver conductorPool1 = new PoolDriver(
                "Ana", "Gómez", "87654321", "rick.jpg", vehicle2, "Profesora de Programación II.", true, 4);

            // Caso 3: pasajero -> solo se publica si la foto tiene una cara.
            Passenger pasajero1 = new Passenger("Lucía", "Fernández", "11111111", "bill.jpg");

            rideShare.Add(conductor1);
            rideShare.Add(conductorPool1);
            rideShare.Add(pasajero1);

            Console.WriteLine("Registro finalizado.");
        }
    }
}
