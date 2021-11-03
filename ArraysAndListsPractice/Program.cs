using System;
using System.Collections.Generic;

namespace ArraysAndListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>();

            //for (int i = 0; i < 1000; i+=15)
            //{
            //    numbers.Add(i);
            //}

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Array variable containing multiple things of same type
            var cars = new string[] { "Buick", "Ford", "Chevy", "Pontiac", "Oldsmobile" };
            var scores = new int[] { 21, 5, 34, 6, 2345 };

            Console.WriteLine(cars[3]);

            //Create array with specific number of variables
            int[] myScores = new int[] { 12, 34, 23, 16, 45 };
            //myScores[3] = 3456;
            //myScores[2] = 223567;

            foreach (string name in cars)
            {
                Console.WriteLine(name);
                Console.WriteLine(scores);
            }

            var grade = new char[] { 'A', 'B', 'C' };
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine(grade[i]);
            }


            //LISTS
            var ages = new List<int>();
            ages.Add(5);
            ages.Add(345);
            ages.Add(15);
            //ages.Remove(5);
            Console.WriteLine(ages.Count);
            Console.WriteLine(ages.GetType());

            var days = new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            Console.WriteLine(days.Count);
            Console.WriteLine(days.GetType());
            days.Add("Wednesday");
            Console.WriteLine(days.Count);
            days.Clear();
            Console.WriteLine(days.Count);

        }
    }
}
