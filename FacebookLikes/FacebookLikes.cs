using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test1 = new string[] { "Alex", "Jacob", "Mark", "Max" };
            string[] test2 = new string[] {"Max", "John", "Mark" };
            Console.WriteLine(Likes(test1));
            Console.WriteLine(Likes(test2));
            Console.ReadLine();
        }

        public static string Likes(string[] name)
        {
            string likeSentence = "no one likes this";

            if (name.Length == 1)
            {
                likeSentence = name[0] + " likes this";
            }

            if (name.Length == 2)
            {
                likeSentence = name[0] + " and " + name[1] + " like this";
            }

            if (name.Length == 3)

            {
                likeSentence = name[0] + ", " + name[1] + " and " + name[2] + " like this";
            }

            if (name.Length > 3)
            {
                int numberOfOthers = name.Length - 2;
                likeSentence = name[0] + ", " + name[1] + " and " + numberOfOthers + " others like this";
            }
            return likeSentence;
        }
    }
}
