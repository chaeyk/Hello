using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! {0}", (new Calculator()).Add(1, 2));
        }
    }

    public class Calculator
    {
        public int Add(int l, int r)
        {
            return l + r;
        }
    }

}
