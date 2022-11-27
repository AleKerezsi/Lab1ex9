using System;

namespace Lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care interschimba valoarea a doua variabile intregi */

            Console.WriteLine("Introduceti x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y:");
            int y = int.Parse(Console.ReadLine());

            int z;

            z = x;
            x = y;
            y = z;

            Console.WriteLine("x= " + x+" "+"y= "+y);   
          
        }
    }
}
