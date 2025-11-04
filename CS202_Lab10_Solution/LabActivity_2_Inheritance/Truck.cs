namespace LabActivity_2_Inheritance
{
    /// <summary>
    /// A derived class representing a Truck, which inherits from Vehicle.
    /// </summary>
    public class Truck : Vehicle
    {
        private int _cargoWeight;

        public Truck()
        {
            _cargoWeight = 5000; // in kg
            speed = 90;
        }

        public override void Drive()
        {
            fuel -= 15; // Trucks consume the most fuel.
            Console.WriteLine("Truck is moving with cargo");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"  - Speed: {speed} km/h, Fuel: {fuel}%, Cargo: {_cargoWeight} kg");
        }
    }
}
