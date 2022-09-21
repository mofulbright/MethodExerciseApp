using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is the name of your dog?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string userDogColor = Console.ReadLine();

            Console.WriteLine($"There is a man named {userName}, he was {age} year old");
            Console.WriteLine($"He had a dog named {userDogName}, and the color of the dog is {userDogColor}");
            Console.WriteLine();


            //Exercise 2 
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");


            Console.WriteLine("Give me a number to start with ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the previous one.");
            int num4 = int.Parse(Console.ReadLine());

            int difference = Difference(num3, num4);
            Console.WriteLine($"The difference is: {difference}");


            Console.WriteLine("Give me a number to multiply");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply by the first one.");
            int num6 = int.Parse(Console.ReadLine());

            int product = Multiply(num5, num6);
            Console.WriteLine($"The product is: {product}");

            Console.WriteLine("Give me a number to divide");
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide by the first one.");
            int num8 = int.Parse(Console.ReadLine());

            int quotient = Quotient(num7, num8);
            Console.WriteLine($"The quotient is: {quotient}");
            
            Console.WriteLine("Give me a number to divide");
            int num9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide by the first one but find the remainder for.");
            int num10 = int.Parse(Console.ReadLine());

            int modulus = Modulus(num9, num10);
            Console.WriteLine($"The remainder is: {modulus}");
        }
        
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

        public static int Difference(int x, int y)
        {
            return x - y;
        }
        public static int Quotient(int x, int y)
        {
            return x / y;
        }
        public static int Modulus(int x, int y)
        {
            return (x % y); 
        }
    }
}

