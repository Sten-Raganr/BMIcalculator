using System;

namespace BMIcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}," +
                $"Welcome to BMI calculator." +
                $" This calculator is for 20 to 60 years old people. ");
            Console.WriteLine("Enter your Year of Birth: ");
            int YearofBirth = Int32.Parse(Console.ReadLine());
            int age = (2020 - YearofBirth);

            if (age < 20)
            {
                Console.WriteLine("Sorry, But you are too young for this calculator. :(");
            }else if (age > 60)
            {
                Console.WriteLine("Sorry, but you are too old for this calculator. :(");
            }
            else
            {
                Console.WriteLine("Enter your weight in kilograms :");
                double weight = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter your height in meters :");
                double height = double.Parse(Console.ReadLine());
                double BMIscore = weight / (height * height) ;
                Console.WriteLine($"Your BMI score are {BMIscore}");
            }

            
        }
    }
}
