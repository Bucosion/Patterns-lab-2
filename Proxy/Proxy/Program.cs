using System;

namespace Proxy.RealWorld
{
     public class Program
     {
          public static void Main(string[] args)
          {

               MathProxy proxy = new MathProxy();

               Console.WriteLine("Results:");
               Console.WriteLine("1 + 2 = " + proxy.Add(1, 2));
               Console.WriteLine("5 - 3 = " + proxy.Sub(5, 3));
               Console.WriteLine("8 * 2 = " + proxy.Mul(8, 2));
               Console.WriteLine("6 / 2 = " + proxy.Div(6, 2));
               Console.WriteLine("Calculation Finished!!!");

               Console.ReadKey();
          }
     }
}
