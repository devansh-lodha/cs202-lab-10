namespace LabActivity_1_Lifecycle
{
    /// <summary>
    /// Demonstrates object lifecycle with constructors, destructors,
    /// and a static member to track active instances.
    /// </summary>
    public class LifecycleTracker
    {
        // Private field to hold data (encapsulation)
        private int _data;

        // Static field to track the number of active objects across all instances
        private static int _activeObjects = 0;

        // Constructor: Called when a new object is created with 'new'
        public LifecycleTracker()
        {
            _data = 0; // Initialize data
            _activeObjects++; // Increment the static counter
            Console.WriteLine($"Constructor Called. Active Objects: {_activeObjects}");
        }

        // Destructor (Finalizer): Called by the Garbage Collector when the object is cleaned up.
        // NOTE: This is not guaranteed to run on program exit in modern .NET.
        ~LifecycleTracker()
        {
            _activeObjects--; // Decrement the static counter
            Console.WriteLine($"Object Destroyed. Active Objects: {_activeObjects}");
        }

        // Public method to set the private data field's value
        public void SetData(int x)
        {
            this._data = x;
        }

        // Public method to display the private data field's value
        public void ShowData()
        {
            Console.WriteLine($"Data value is: {_data}");
        }
    }
}
