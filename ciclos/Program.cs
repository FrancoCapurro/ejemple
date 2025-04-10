using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ciclos
            // for ,while ,do while


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // vectores


            int[] numeros = new int[10];
            float[] precios = new float[12];

            numeros[0] = 10;
            
            int j = numeros[0];

            Console.WriteLine(Saludar("franco"));
            Console.ReadKey();
            
                
                
        }
        static int sumar(int a, int b)
        {
            return a + b;
        }

        static string Saludar(string nombre)
        {

            return "hola" + nombre;
        }
    }
}
