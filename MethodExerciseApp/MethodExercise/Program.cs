using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            //Console.WriteLine("What is the name of your dog?");
            //string userDogName = Console.ReadLine();

            //Console.WriteLine("What color is your dog?");
            //string userDogColor = Console.ReadLine();

            //Console.WriteLine($"There is a man named {userName}, he was {age} year old");
            //Console.WriteLine($"He had a dog named {userDogName}, and the color of the dog is {userDogColor}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply by the first one.");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");






        }
        //Step 2
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;

        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
