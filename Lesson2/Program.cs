using System;

namespace Lesson2
{
    class Program
    {
        static float Add(float a, float b) => a + b;
        static float Mul(float a, float b) => a * b;
        static float Div(float a, float b) => (b == 0) ? 0 : a / b;
        static float Diff(float a, float b) => a - b;


        static void Main()
        {
            float a, b;
            char operation;


            while (true)
            {
                Console.Write("Enter the number: ");
                float.TryParse(Console.ReadLine(), out a);
                Console.Clear();

                do
                {
                    Console.WriteLine("Enter the operator (+ - * /): ");
                    char.TryParse(Console.ReadLine(), out operation);
                    Console.Clear();


                } while (operation != '+' && operation != '-'&& operation!='*'&& operation !='/');


                Console.WriteLine("Enter the number: ");
                float.TryParse(Console.ReadLine(), out b);

                Console.Write($"{a} {operation} {b} = ");

                switch (operation)
                {
                    case '+':
                        Console.WriteLine(Add(a, b));
                        break;
                    case '-':
                        Console.WriteLine(Diff(a, b));
                        break;
                    case '*':
                        Console.WriteLine(Mul(a, b));
                        break;
                    case '/':
                        Console.WriteLine(Div(a, b));
                        break;
                    default:
                        break;
                }
                break;
            }
        }
    }
}
