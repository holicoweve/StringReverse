using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringReverse");
            while(true)
            {
                Console.WriteLine("\nPlease enter a string to reverse, q to quit");
                Console.Write(">");
                string input = Console.ReadLine();

                if (input == "q")
                    return;

                Console.WriteLine("Iterate: " + ReverseString.ReverseIterate(input));
                Console.WriteLine("Stack: " + ReverseString.ReverseStack(input));
                Console.WriteLine("Recursion: " + ReverseString.ReverseRecursion(input));
            }
        }
    }

    public class ReverseString
    {
        public static string ReverseIterate(string input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = input.Length-1; i >=0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

        public static string ReverseStack(string input)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> myStack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                myStack.Push(input[i]);
            }
            while (myStack.Count > 0)
            {
                sb.Append(myStack.Pop());
            }
            return sb.ToString();
        }

        public static string ReverseRecursion(string input)
        {
            if (input.Length <= 1)
                return input;
            else
                return input[input.Length - 1] + ReverseRecursion(input.Substring(0, input.Length - 1));
        }
    }

}
