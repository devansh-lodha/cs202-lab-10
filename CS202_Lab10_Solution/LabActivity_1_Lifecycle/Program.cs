namespace LabActivity_1_Lifecycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Creating three objects ---");
            LifecycleTracker obj1 = new LifecycleTracker();
            LifecycleTracker obj2 = new LifecycleTracker();
            LifecycleTracker obj3 = new LifecycleTracker();
            Console.WriteLine();

            Console.WriteLine("--- Setting data for each object ---");
            obj1.SetData(10);
            obj2.SetData(20);
            obj3.SetData(30);
            Console.WriteLine();


            Console.WriteLine("--- Displaying data from each object ---");
            obj1.ShowData();
            obj2.ShowData();
            obj3.ShowData();
            Console.WriteLine();

            Console.WriteLine("--- Main method finished. Program will now exit. ---");
            Console.WriteLine("Observe that destructor messages may not appear.");
        }
    }
}
