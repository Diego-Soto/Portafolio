using System;

namespace L1_DASA1187921
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World ");
            Console.WriteLine("soy Diego");

            /* la diferencia es que el writeline pone la palabra seleccionada en la siguiente lines*/

            Console.Write("Hello World");
            Console.Write(" soy Diego");
            Console.ReadKey();


            Console.WriteLine("ingrese su nombre");
            string nombre = Console.ReadLine();


            Console.WriteLine("hola mundo");
            Console.WriteLine("soy" + nombre);
            Console.ReadKey();


        }
    }
}
