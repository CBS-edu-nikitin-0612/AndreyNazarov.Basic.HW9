using System;

namespace Task2
{
    public delegate int MyDelegate(int left, int right);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate add = (int left, int right) => left + right;
            MyDelegate div = (int left, int right) =>
            {
                if (right == 0)
                    throw new DivideByZeroException(left + " is 0");
                return left / right;
            };
            MyDelegate mul = (int left, int right) => left * right;
            MyDelegate sub = (int left, int right) => left - right;

            while (true)
            {
                Console.WriteLine("Type first operand");
                int operand1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type operator (+ - / *)");
                char oper = char.Parse(Console.ReadLine());
                Console.WriteLine("Type second operand");
                int operand2 = int.Parse(Console.ReadLine());
                int? result = null;
                try
                {
                    result = oper switch
                    {
                        '+' => add(operand1, operand2),
                        '-' => sub(operand1, operand2),
                        '*' => mul(operand1, operand2),
                        '/' => div(operand1, operand2),
                        _ => throw new FormatException()
                    };
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                if (result != null)
                {
                    Console.WriteLine("result: " + result);
                }
            }
        }
    }
}
