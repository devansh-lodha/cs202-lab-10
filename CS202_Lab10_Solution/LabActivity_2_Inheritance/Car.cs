namespace LabActivity_2_Inheritance
{
    /// <summary>
    /// A derived class representing a Car, which inherits from Vehicle.
    /// It overrides the base class's methods to provide specific behavior.
    /// </summary>
    public class Car : Vehicle
    {
        private int _passengers;

        public Car()
        {
            // The base class constructor is implicitly called first.
            _passengers = 4;
            speed = 120; // We can access the 'protected' speed field from the base class.
        }

        // The 'override' keyword replaces the base class's virtual method.
        public override void Drive()
        {
            fuel -= 10; // Cars consume more fuel in this example.
            Console.WriteLine("Car is moving with a passenger");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"  - Speed: {speed} km/h, Fuel: {fuel}%, Passengers: {_passengers}");
        }
    }
}
