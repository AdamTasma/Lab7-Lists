using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 0, 1, 2 };
            List<string> students = new List<string>() { "Adam", "Aaron", "Ian" };
            List<string> towns = new List<string>() { "Grand Rapids", "Hart", "Allendale" };
            List<string> foods = new List<string>() { "Putine", "Ribeye", "Alfredo" };
            int input;

            Console.WriteLine("Welcome to our C# class.");
            input = UserChoosesStudent(numbers, students, towns, foods);
            UserChoosesData(input, numbers, students, towns, foods);
            Repeat();
        }

        static int UserChoosesStudent(int input, List<int> numbers, List<string> students, List<string> towns, List<string> foods)
        {
            Console.WriteLine("Which student would you like to learn more about?");
            Console.WriteLine("(Please enter a number between 1 and 12)");
            input = int.Parse(Console.ReadLine());
            //Console.WriteLine(input);
            if (input > numbers.Count)
            {
                //Console.WriteLine("I'm sorry, that student doesn't exist. Please try again");
                //input = int.Parse(Console.ReadLine());
                UserChoosesStudent(numbers, students, towns, foods); 
            }
            else
            {
                Console.WriteLine("number " + input + " is " + students[input] + ".");

            }
            return input;
        }
        static void UserChoosesData(List<int> numbers, List<string> students, List<string> towns, List<string> foods)
        {
            Console.WriteLine("what would you like to know about " + students[input] + "?");
            Console.WriteLine("(enter \"home town\" or \"favorite food\")");
            string input2 = Console.ReadLine().ToLower();
            //nsole.WriteLine(input2);
            if (input2.Equals("home town"))
            {
                Console.WriteLine(students[input] + "'s home town is " + towns[input] + ".");
            }
            else if (input2.Equals("favorite food"))
            {
                Console.WriteLine(students[input] + "'s favorite food is " + foods[input] + ".");
            }
            else
            {
                Console.WriteLine("That data does not exist, please re-enter");
                Console.WriteLine("(enter \"home town\" or \"favorite food\")");
                input2 = Console.ReadLine().ToLower();

            }
        }
    }
}
