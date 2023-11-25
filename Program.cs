using System;

public class Program
{
    public static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Write("Enter the height in cm: ");
            double height = double.Parse(Console.ReadLine()) / 100.0;
            Console.Write("Enter the weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            var bmi = weight / (height * height);
            Console.WriteLine($"BMI: {Math.Round(bmi, 1)} kg/m²");
        }
    }
}