namespace Ucu.Poo.RideShare
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }

        public Vehicle(string brand, string model, string licensePlate)
        {
            this.Brand = brand;
            this.Model = model;
            this.LicensePlate = licensePlate;
        }
    }
}