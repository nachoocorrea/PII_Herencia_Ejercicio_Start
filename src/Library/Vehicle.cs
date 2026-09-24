namespace Ucu.Poo.RideShare
{
    public class Vehicle
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public Vehicle(string marca, string modelo, string patente)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Patente = patente;
        }
    }
}