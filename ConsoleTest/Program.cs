using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Floatpointconverter;
using GCD;
namespace ConsoleTest
{
    class Program
    {

    static void Main(string[] args)
    {
        string l = DoubleToBinaryStringFormat.DoubleToIEEE754(-255.255);

        Console.WriteLine(l);
        int gcd = 0;
        gcd = GetGCD.GCDEuklid(14, 21);
        gcd = GetGCD.GCDEuklid(14, 21, 28);//7
        gcd = GetGCD.GCDEuklid(72, 32, 256);
        gcd = GetGCD.GCDEuklid(72, 32, 256);//8
        long timeWatch;
        gcd = GetGCD.GCDEuklid(out timeWatch, 72, 32, 256, 16, 128);//8

                                                //gcd = GetGCD.GCDEuklid(72, 32, 256, 12);//4 


        Console.WriteLine("{0 } {1 }", gcd, timeWatch);

        gcd = GetGCD.GCDStein(out timeWatch, 72, 32, 256, 16, 128);//8
        Console.WriteLine("{0 } {1 }", gcd, timeWatch);

            //gcd = GetGCD.GCDStein(116150, 232704);
            //Console.WriteLine(gcd);




            Console.ReadLine();
    }
}

}
