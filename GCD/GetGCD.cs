using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Net.Configuration;
    using System.Threading;

    public static class GetGCD
    {
        /// <summary>
        /// This method calculate GDC value from 2 arguments
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDEuklid(int a, int b)
        {
            if ((a <= 1) || (b <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            return Euklid(a, b);
        }
        /// <summary>
        /// This method calculate GCD value by Euklid algorithm from 3 arguments
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>

        public static int GCDEuklid(int a, int b, int c)
        {
            if ((a <= 1) || (b <= 1) || (c <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            return Euklid(Euklid(a, b), c);
        }

        /// <summary>
        /// This method calculate GCD value by Euklid algorithm from 3 arguments
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <param name="args">args is array 4 and more arguments</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDEuklid(int a, int b, int c, params int[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            for (int i = 0; i < args.Length; i++)
            {
                if ((a <= 1) || (b <= 1) || (c <= 1) || (args[i] <= 1))
                {
                    throw new ArgumentException("Value should be greater than 1");
                }
                a = Euklid(a, args[i]);
            }

            return a;
        }

        /// <summary>
        /// This method calculate GCD value by Euklid algorithm from 2 arguments
        /// with calculate elapsed execution time  
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="timeWatchTick">is out elapsed time by ticks</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDEuklid(out long timeWatchTick, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if ((a <= 1) || (b <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            int gcd = Euklid(a, b);
            stopwatch.Stop();
            timeWatchTick = stopwatch.ElapsedMilliseconds;
            return gcd;
        }

        /// <summary>
        /// This method calculate GCD value by Euklid algorithm from 3 arguments
        /// with calculate elapsed execution time  
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <param name="timeWatchTick">is out elapsed time by ticks</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDEuklid(out long timeWatchTick, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if ((a <= 1) || (b <= 1) || (c <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            int gcd = Euklid(Euklid(a, b), c);
            stopwatch.Stop();
            timeWatchTick = stopwatch.ElapsedMilliseconds;
            return gcd;
        }
        /// <summary>
        /// This method calculate GCD value by Euklid algorithm from 4 and more arguments
        /// with calculate elapsed execution time  
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <param name="args">args is array 4 and more arguments</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">if values less or greater 1 throw ArgumentException </exception>
        /// <exception cref="ArgumentException">if incomming value array is null reference
        /// throw ArgumentNullException</exception>
        public static int GCDEuklid(out long timeWatchTick, int a, int b, int c, params int[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < args.Length; i++)
            {
                if ((a <= 1) || (b <= 1) || (c <= 1) || (args[i] <= 1))
                {
                    throw new ArgumentException("Value should be greater than 1");
                }
                a = Euklid(a, args[i]);
            }

            stopwatch.Stop();
            timeWatchTick = stopwatch.ElapsedTicks;
            return a;
        }

       
        private static int Euklid(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }




        /// <summary>
        /// This method calculate GDC value from 2 arguments
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDStein(int a, int b)
        {
            if ((a <= 1) || (b <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            return Stein(a, b);
        }
        /// <summary>
        /// This method calculate GCD value by Stein algorithm from 3 arguments
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>

        public static int GCDStein(int a, int b, int c)
        {
            if ((a <= 1) || (b <= 1) || (c <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            return Stein(Stein(a, b), c);
        }

        /// <summary>
        /// This method calculate GCD value by Stein algorithm from 3 arguments
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <param name="args">args is array 4 and more arguments</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDStein(int a, int b, int c, params int[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            for (int i = 0; i < args.Length; i++)
            {
                if ((a <= 1) || (b <= 1) || (c <= 1) || (args[i] <= 1))
                {
                    throw new ArgumentException("Value should be greater than 1");
                }
                a = Stein(a, args[i]);
            }

            return a;
        }

        /// <summary>
        /// This method calculate GCD value by Stein algorithm from 2 arguments
        /// with calculate elapsed execution time  
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="timeWatchTick">is out elapsed time by ticks</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDStein(out long timeWatchTick, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if ((a <= 1) || (b <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            int gcd = Stein(a, b);
            stopwatch.Stop();
            timeWatchTick = stopwatch.ElapsedMilliseconds;
            return gcd;
        }

        /// <summary>
        /// This method calculate GCD value by Stein algorithm from 3 arguments
        /// with calculate elapsed execution time  
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <param name="timeWatchTick">is out elapsed time by ticks</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">If values less or greater 1 throw Argument Exception </exception>
        public static int GCDStein(out long timeWatchTick, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if ((a <= 1) || (b <= 1) || (c <= 1))
            {
                throw new ArgumentException("Value should be greater than 1");
            }

            int gcd = Stein(Stein(a, b), c);
            stopwatch.Stop();
            timeWatchTick = stopwatch.ElapsedMilliseconds;
            return gcd;
        }
        /// <summary>
        /// This method calculate GCD value by Stein algorithm from 4 and more arguments
        /// with calculate elapsed execution time  
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <param name="c">third argument</param>
        /// <param name="args">args is array 4 and more arguments</param>
        /// <returns>GCD value</returns>
        /// <exception cref="ArgumentException">if values less or greater 1 throw ArgumentException </exception>
        /// <exception cref="ArgumentException">if incomming value array is null reference
        /// throw ArgumentNullException</exception>
        public static int GCDStein(out long timeWatchTick, int a, int b, int c, params int[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < args.Length; i++)
            {
                if ((a <= 1) || (b <= 1) || (c <= 1) || (args[i] <= 1))
                {
                    throw new ArgumentException("Value should be greater than 1");
                }
                a = Stein(a, args[i]);
            }

            stopwatch.Stop();
            timeWatchTick = stopwatch.ElapsedTicks;
            return a;
        }

        private static int Stein(int a, int b)
        {
            int t = 1;
            while ((a != 0) && (b != 0))
            {
                while ((a % 2 == 0) && (b % 2 == 0))
                {
                    a /= 2;
                    b /= 2;
                    t *= 2;
                }

                while (a % 2 == 0)
                {
                    a /= 2;
                }

                while (b % 2 == 0)
                {
                    b /= 2;
                }

                if (a >= b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return b * t;
        }
    }

}
