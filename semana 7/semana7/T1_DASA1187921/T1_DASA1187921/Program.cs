using System;

namespace T1_DASA1187921
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");
            string snombre;
            string sedad;
            string scarrera;
            string scarnet;
            Console.WriteLine("escriba su nombre:");
            snombre = Console.ReadLine();
            Console.WriteLine("escriba su carrera:");
            scarrera = Console.ReadLine();
            Console.WriteLine("escriba su edad:");
            sedad = Console.ReadLine();
            Console.WriteLine("escriba su carnet:");
            scarnet = Console.ReadLine();

            Console.WriteLine("nombre:" + snombre);
            Console.WriteLine("carrera:" + scarrera);
            Console.WriteLine("edad:" + sedad);
            Console.WriteLine("carnet:" + scarnet);
            Console.WriteLine("soy " + snombre+" ,tengo "+ sedad+" años y estudio la carrera de "+ scarrera+" mi numero de carnet es "+scarnet);
            Console.ReadLine();

        }
    }
}
