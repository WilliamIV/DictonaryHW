using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonarySlideHW

{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize var
            string animalName;



            // Imput animal to search for
            Console.Write("Please enter an animal to search: ");
            animalName = Console.ReadLine();
            Console.WriteLine();



            // make the dictionary
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("bear", 4);
            animals.Add("Squid", 8);
            animals.Add("Bird", 2);
            animals.Add("Dog", 4);
            animals.Add("Kangaroo", 2);
            animals.Add("Ape", 4);
            // Print out animal with number of legs
            if (animals.ContainsKey(animalName))
            {
                int value = animals[animalName];
                Console.WriteLine("The " + animalName + " has " + value + " legs.\n");
            }
            else // If animal not found
            {
                Console.WriteLine(animalName + " is not in the dictonary.\n");
            }
        }
    }
}