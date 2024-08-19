using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] sizeFifty = new int[50];
            Populater(sizeFifty);
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            

            //TODO: Print the first number of the array
            Console.WriteLine(sizeFifty[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(sizeFifty[49]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(sizeFifty);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(sizeFifty);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(sizeFifty);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(sizeFifty);
            foreach (var number in sizeFifty)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> masterList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(masterList.Count);
            
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            PopulaterL(masterList);

            //TODO: Print the new capacity
            Console.WriteLine(masterList.Count);            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);

            while (!inputSuccess)
            {
                Console.WriteLine("Please enter a number");
                inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
            }
            NumberChecker(masterList, parseSucceed);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(masterList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(masterList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            masterList.Sort();
            foreach (var sortedValue in masterList)
            {
             Console.WriteLine(sortedValue);   
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            masterList.ToArray();

            //TODO: Clear the list
            masterList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int isThree = 0; isThree < numbers.Length; isThree++)
            {
                if (numbers[isThree] % 3 == 0)
                {
                    numbers[isThree] = 0;
                    Console.WriteLine(numbers[isThree]);
                }
                else
                {
                    Console.WriteLine(numbers[isThree]);
                }
            }   
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (var isOdd in numberList.ToList())
            {
                if (isOdd % 2 != 0)
                {
                    numberList.Remove(isOdd);
                }
                else
                {
                    Console.WriteLine(isOdd);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool has = false;
            foreach (var toLook in numberList)
            {
                if (toLook == searchNumber)
                {
                    has = true;
                }
            }
            if (has)
            {
                Console.WriteLine("Your number is on the list!");
            }
            else
            {
                Console.WriteLine("Sorry, it isn't.");
            }
            
        }

        private static void PopulaterL(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                Random rng = new Random();
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
