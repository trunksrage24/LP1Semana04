using System;

namespace Power2Method
{
    class Program
    {
        //method for shift 1 five times
        private static void PowersOf2Until5()
        {
            for(int i = 1; i <= (1 << 5); i = i << 1)
            {
            Console.WriteLine(i);
            }
        }

        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= ( 1 << n ); i = i << 1)
            {  
                Console.WriteLine(i);
            }
        }

        //main method
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOf2UntilN(4);
            PowersOf2UntilN(6);
        }
    }
}
