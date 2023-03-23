using System;

namespace Power2Method
{
    class Program
    {
        //method for shift 1 five times
        /// <summary>
        /// method for shift 1 five times
        /// </summary>
        private static void PowersOf2Until5()
        {
            //changed method to use PowersOf2UntilN()
            PowersOf2UntilN(5);
        }

        //method for shift 1 n times
        /// <summary>
        /// method for shift 1 n times
        /// </summary>
        /// <param name="n">variable for number of times method shifts left</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= ( 1 << n ); i = i << 1)
            {  
                Console.WriteLine(i);
            }
        }

        //main method
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args">method accepts strings as type</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOf2UntilN(4);
            PowersOf2UntilN(6);
        }
    }
}
