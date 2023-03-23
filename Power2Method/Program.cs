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

        //overloading method with 2 param
        /// <summary>
        /// overloading method with 2 param
        /// </summary>
        /// <param name="n1">shift from here</param>
        /// <param name="n2">shift till here</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = (1 << n1); i <= (1 << n2); i = i << 1)
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
            //call method twice
            PowersOf2Until5();
            PowersOf2Until5();

            //call method twice with n number
            PowersOf2UntilN(4);
            PowersOf2UntilN(6);

            //call method twice with n1 and n2 numbers
            PowersOf2UntilN(4 ,6);
            PowersOf2UntilN(3, 7);
        }
    }
}
