class Program
{
    int f;
    public static void Main(string[] args)
    {
        Console.WriteLine("run 1");
        Program p = new Program(new int() + "0".Length); // p.f starts at 2
        for (int i = 0, _ = i; i < 5 && ++p.f >= 0; i++, Console.WriteLine(p.f++))
        {
            // NOTE: The curly braces here are MISLEADING. They are NOT the body of the for loop.
            // The semicolon at the end of the for(...) line makes the for loop's body empty.
            // This block is just a regular code block that executes AFTER the for loop finishes.
        }
        { // This block executes once, after the for-loop completes.
            for (; p.f == 0;) ; // This is a second, unrelated loop that will never run.
            {
                Console.WriteLine(p.f); // This prints the final state of p.f
            }
        }
        Console.WriteLine("\nrun 2");
        p = new Program(p.f);
        Console.WriteLine(p.f);
        Console.WriteLine("\nrun 3");
        p = new Program();
        Console.WriteLine(p.f);
    }
    Program() => f = 0;
    Program(int x) => f = x;
}
