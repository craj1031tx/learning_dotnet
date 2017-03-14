using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testString = "Irving, TX";
            int testNum = 12;
            string testInterpolate = $"interpolate this plz: {3*3}";
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a test. {0} {1}, age {2} and lives in {3}", "Chetan", "Raj", 27, testString);
            Console.WriteLine("Here is a test"+testNum+"of some commas");
            Console.WriteLine($"Here is some math: {5+5}");
            Console.WriteLine(testInterpolate);
        }
    }
}
