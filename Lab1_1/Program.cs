using System;

namespace Lab1_1
{
    class Program
    {
        private delegate double del(int a, int b, int c);
        static void Main(string[] args)
        {
            n1();
            n2();
            n3();

            Console.ReadLine();
        }

        static void n1()
        {
            del del = delegate (int a, int b, int c)
            {
                double result = (a + b + c) / 3;
                return result;
            };
            Console.WriteLine(del(4, 6, 9));
        }
        
        static void n2()
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(calc.Sub(6, 3));
            Console.WriteLine(calc.Div(15, 5));
            Console.WriteLine(calc.Mul(2, 7));
        }

        static void n3()
        {
            foreach (var del in N3.arr)
            {
                Console.WriteLine(del());
            }
        }
    }

}
