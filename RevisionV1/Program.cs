using System;

namespace RevisionV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7 + 9;
            Console.WriteLine(x); // 16
            string firstName = "John";
            string lastName = "Doe";
            // Do not forget the space between them
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName); // John Doe

            int squarePerimeter = 17;
            float squareSide = (float)(squarePerimeter / 4.0);
            float squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide); // 4.25
            Console.WriteLine(squareArea); // 18.0625
            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // 9
            Console.WriteLine(a + (b++)); // 9
            Console.WriteLine(a + b); // 10
            Console.WriteLine(a + (++b)); // 11
            Console.WriteLine(a + b); // 11
            Console.WriteLine(14 / a); // 2
            Console.WriteLine(14 % a); // 4

            Console.ReadLine();

        }
    }
}
