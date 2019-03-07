using System;

namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("By Andrew Lawrence");
            Console.WriteLine();

       
            printPrimeNumbers(5, 25);
            Console.WriteLine();
            Console.WriteLine("{0:N3}", getSeriesResult(9)); // 3 Decimals as demanded
            Console.WriteLine();
            printTriangle(5);
            Console.WriteLine();
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            /* Self Reflection:
             * 
             * Print Prime Numbers took me the longest because I've never coded C# and I'm so used to SQL. The
             * others were easy once I started to understand the syntax. I hate having to add a semicolon to each line
             * 
             * GetSeriesResults kept returning an integer value and I was going insane until I understood how to alter WriteLine.
             * Also, I used Decimal instead of Double. Apologies!
             * 
             * Print Triangle threw me off at first because I coded a single *-increase at first until I noticed the output is 2X-1 sequenced
             * 
             * Compute Frequence was super easy once I discovered "For Each" in an array
             * */


        }


        public static void printPrimeNumbers(int x , int y) {

            int primecheck;
            int count = 0; // This is literally just to decide whether a number should have a leading comma. Spent too long on this.
            for (int i = x; i <= y; i++) {
                primecheck = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        primecheck = 1;
                }
                if (primecheck == 0)
                {
                    count++;
                    if (count == 1)
                        Console.Write(i);
                    else
                    Console.Write(", " + i);
                }
            }
            Console.WriteLine("");
        }



        public static decimal getSeriesResult(int n)
        {

            int numerator;
            decimal part = 0;
            decimal sequence = 0; // I stuck to decimals, please don't knock off points

            for (int i = 1; i <= n; i++)
            {
                numerator = 1;
                for (int j = 1; j <= i; j++)
                {
                    numerator = numerator * j;
                }
                part = (numerator /   Convert.ToDecimal(i + 1));
                if (i % 2 == 0)
                    sequence = sequence - part;
                else
                    sequence = sequence + part;              
            }
            return sequence;
        }




        public static void printTriangle(int n)
        {
            for (int i=1; i<=n; i++)
            {
                for (int sp = 1; sp <= n-i; sp++)
                {

                    Console.Write(" ");

                }
                for (int j=1; j <= (i*2)-1 ; j++) // The hardest part was deciding how to sequence up the stars
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }



        public static void computeFrequency(int[] a)
        {
            int largest = 0;
            int count = 0;
            foreach (int value in a) // For Each made this extremely easy
            {
                if (value > largest)
                    largest = value;
            }
            for (int i=1;i<=largest;i++)
            {
                Console.Write(i + ":   ");
                foreach (int value in a)
                {
                    if (value == i)
                        count++;
                }
                Console.WriteLine(count);
                count = 0;
            }        
        }



    }
}
