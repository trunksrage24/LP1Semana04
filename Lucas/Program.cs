using System;

namespace Lucas
{
    class Program
    {
        private static int Lucas(int n)
        {
            if (n==0)
                return 2;

            else if (n==1)
                return 1;

            else
                return (Lucas(n - 1) + Lucas(n - 2));
        }

        static void Main(string[] args)
        {
            int UserInput = int.Parse(args[0]);
            int Input = Lucas(UserInput);

            Console.WriteLine(Input);
            Console.WriteLine("hello");
        }
    }
}