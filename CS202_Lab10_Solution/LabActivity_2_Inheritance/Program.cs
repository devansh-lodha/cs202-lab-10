namespace LabActivity_2_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstrating Polymorphism ---");

            // Create an array of the BASE type.
            Vehicle[] vehicles = new Vehicle[3];

            // Populate it with instances of the DERIVED types.
            vehicles[0] = new Vehicle();
            vehicles[1] = new Car();
            vehicles[2] = new Truck();

            // Loop through the array, calling methods on the base reference.
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"\nOperating a {v.GetType().Name}:");
                v.Drive();    // The correct overridden method is called at runtime.
                v.ShowInfo(); // The correct overridden method is called at runtime.
            }
        }
    }
}
