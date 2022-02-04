using System;

namespace Task5
{

    class Program
    {
        private delegate double calc(int a, int b, int c);
        static void Main(string[] args)
        {
            calc calculator = (int a, int b, int c) => ((double)a + b + c) / 3;

            Console.WriteLine(calculator(4, 3, 6));
        }
    }
}
