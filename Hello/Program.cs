using System;

namespace Hello
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! {0}", (new Calculator()).Add(1, 2));
            Console.WriteLine("Hello World! {0}", (new Calculator()).Sub(1, 2));
            Console.WriteLine("Hello World! {0}", (new Calculator()).Mul(1, 2));
        }
    }

    public class Calculator
    {
        public int A;
        public int E;

        public int Add(int l, int r)
        {
            A = l + r;
            return A;
        }

        public int Sub(int l, int r)
        {
            A = l - r;
            return A;
        }

        public int Mul(int l, int r)
        {
            A = l * r;
            return A;
        }

        public int Div(int l, int r)
        {
            A = l / r;
            return A;
        }
    }

}
