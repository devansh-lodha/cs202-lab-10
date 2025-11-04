namespace LabActivity_2_Inheritance
{
    /// <summary>
    /// The base class representing a generic vehicle.
    /// It provides a default implementation that can be overridden by derived classes.
    /// </summary>
    public class Vehicle
    {
        // Protected fields are accessible by this class and any class that inherits from it.
        protected int speed;
        protected int fuel;

        public Vehicle()
        {
            speed = 80;
            fuel = 100;
        }

        // Virtual methods can be overridden in derived classes.
        public virtual void Drive()
        {
            fuel -= 5;
            Console.WriteLine("Vehicle is moving...");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"  - Speed: {speed} km/h, Fuel: {fuel}%");
        }
    }
}
