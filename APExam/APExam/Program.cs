using System;
using System.Text.RegularExpressions;

namespace APExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2();
        }

        public static void Exercise1()
        {
            var people = new People {Name = "Mary", Gender = true, Age = 25};
            people.Age = 35;
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine("Person details: " + people.ToString());
            Console.WriteLine("Person details (apter incrementing age) :" + people.ToString());
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter a String");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            var wrd = Console.ReadLine();

            var count = Regex.Matches(str, wrd).Count;
            Console.WriteLine("word found " +count +" times in the string.");

        }

    }
}