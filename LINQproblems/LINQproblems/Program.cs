using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 1. Using LINQ, write a function that returns all words that contain the substring “th” from a list.
            * List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };
            */

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };


            var results = words.Where(X => X.Contains("th"));

            foreach (var element in results)
            {
                Console.WriteLine(element);
            }
            //Console.ReadLine();



            /*
             * 2.Using LINQ, write a function that takes in a list of strings and returns a copy of the list 
             * without duplicates.List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
             */

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            var results2 = names.Distinct();

            foreach (var element in results2)
            {
                Console.WriteLine(element);
            }
            //Console.ReadLine();

            /*3. Using LINQ, write a function that calculates the class grade average after dropping the lowest grade 
             * for each student. The function should take in a list of strings of grades 
             * (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, 
             * averages the rest of the grades from that string, then averages the averages.
             * List<string> classGrades = new List<string>(){
             * "80,100,92,89,65",
             * "93,81,78,84,69",
             * "73,88,83,99,64",
             * "98,100,66,74,55"
             * };
             * Expected output: 86.125
             */

            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            List<int[]> classGrades2 = new List<int[]>() { };


            foreach (var element in classGrades)
            {
                classGrades2.Add(element.Split(',').Select(str => int.Parse(str)).ToArray());
            }
            foreach (var element in classGrades2)
            {
                element.Take(element.Count() - 1).ToArray();
                Console.WriteLine(element.Length);
            }


            Console.ReadLine();
        }
    }
}
