using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b.
        //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.
        //Осуществить использование экземпляра в программе.


        static void Main(string[] args)
        {
            try
                { 
                LinearZeroEquation eq;
                Console.WriteLine("Алгоритм находит корень линейного уравнения 0=kx+b,");
                Console.Write("где k=");
                eq.k = Convert.ToSingle(Console.ReadLine());
                Console.Write("b=");
                eq.b = Convert.ToSingle(Console.ReadLine()); 
                Console.WriteLine("\nКорень уравнения 0={0}x+{1}     x={2}", eq.k, eq.b, eq.Root());
                }
            catch (Exception ex)    
                { Console.WriteLine(ex.Message); }

            Console.ReadKey();
        }
        struct LinearZeroEquation
        {
            public float k;
            public float b;
            public float Root()
            {
                float x;
                x = -b / k;
                return x;
            }
        }
    }
}
