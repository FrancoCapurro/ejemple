using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int float bool char
            // double decimal, long, short, string, datetime

            int a,b,c;

            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());

            b = 10;

            c = a + b;
            
            

            Console.WriteLine("El resultado es:" + c);

            // IF

            if (a == b)
            {
                Console.WriteLine("A y B son iguales");
            } else
            {
                Console.WriteLine("Son distintos");

            }

                Console.ReadKey();

            switch (a)
            {
                case 0:
                      break;
                case 1:
                      break;
                case 2:
                      break;
                case 3:
                      break;
                default:
                      break;
            }
        }
    }
}
