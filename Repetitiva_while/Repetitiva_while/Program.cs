using System;

    class Program
    {
        static void Main(string[] args)
        {
            string nombreusuario = "";
            Console.Write("Por favor, ingresa tu nombre: ");
            nombreusuario = Console.ReadLine();

            //Estructura repetitiva para preguntar el nombre
            while (nombreusuario != "FIN")
            {
                Console.WriteLine("Bienvenido sr(a)," + nombreusuario + ".");
                Console.WriteLine("");
                Console.Write("Por favor, ingresa tu nombre: ");
                nombreusuario = Console.ReadLine();
                //Console.ReadLine();

            }
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
    }

