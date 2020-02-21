using System;

class Program
{
    static void Main(string[] args)
    {
        string nombrepro = "";
        int Ciudad = 1;

        Console.Write("Por favor, ingrese el nombre de una ciudad turística: ");
        nombrepro = Console.ReadLine();

        //Estructura repetitiva para preguntar el nombre
        while (nombrepro != "FIN")
        {

            Console.WriteLine("Bienvenido a la ciudad turistica Nº: " + Ciudad + ".");
            Console.WriteLine("La ciudad Nº  " + Ciudad + " Es: " + nombrepro);
            Console.WriteLine("");
            Console.Write("Por favor, ingrese el nombre de una ciudad turística: ");
            nombrepro = Console.ReadLine();
            Ciudad += 1;
            //Console.ReadLine();
        }
        Console.WriteLine("Fin del programa");
        Console.ReadLine();
    }
}

