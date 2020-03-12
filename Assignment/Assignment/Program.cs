using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your name");
            string name = Console.ReadLine();
            Console.WriteLine("Give me your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me your weight");
            double weight = Convert.ToDouble(Console.ReadLine());

            string color = "0";
            List<string> colors = new List<string>() { "0-17 White", "18-24 Pink", "25-35 Red", "36-45 Green", "45-55 Blue", "55+ Black" };
            if (age >0 && age <= 17)
            {
                color = "White";
            }
            else if(age >=18 && age <= 24)
            {
                color = "Pink"; 
            }else if (age >= 25 && age <= 35)
            {
                color = "Red";
            }else if(age >= 36 && age <= 45)
            {
                color = "Green";
            }else if(age >= 45 && age <= 55)
            {
                color = "Blue";
            }else if(age >= 55)
            {
                color = "Black";
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
            

            List<string> sizes = new List<string>() { "<50kg, Small", "50 to 64kgs, Medium", "65 to 79kgs, Large", "80kgs and over X-Large"};
            string size = "0";
            if (weight < 50 && weight >0)
            {
                size = "Small";
            }else if (weight>50 && weight <= 64)
            {
                size = "Medium";
            }else if (weight>=65 && weight<= 79)
            {
                size = "Large";
            }
            else if(weight>=80)
            {
                size = "X-Large";
            }
            else
            {
                Console.WriteLine("Invalid Weight");
            }
            

           Console.WriteLine($"Hey {name}, it is cool to be {age} years old!  You should buy a {color} {size} shirt");


        }
    }
}
