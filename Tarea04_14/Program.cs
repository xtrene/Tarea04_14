using System;

namespace Tarea04_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el radio:  ");
            double radio = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine("El área del círculo es:  {0}", Math.PI*Math.Pow(radio,2) );

            Console.ReadKey();
        }
    }
}
