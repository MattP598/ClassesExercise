using System;

namespace ClassesExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Buick";
            myCar.Model = "Encore";
            myCar.Year = "2019";

            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
        }
    }
}
