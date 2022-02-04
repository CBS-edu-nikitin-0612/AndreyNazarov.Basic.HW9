using System;

namespace Task3
{
    class Program
    {
        private delegate int delegate1(Random rnd);
        private delegate double delegate2(delegate1[] arr);
        static void Main(string[] args)
        {
            delegate1[] arr = new delegate1[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = (rnd) => rnd.Next(0, 100);
            }

            delegate2 delegate2 = (arr) =>
            {
                Random rnd = new();
                int total = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i](rnd);
                }
                return total / (double)arr.Length;
            };

            Console.WriteLine(delegate2(arr));
        }
    }
}
