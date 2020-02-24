using System;

class Program
{
    static void Main(string[] args)
    {
        string Nombre = " ";
        string Apellido = " ";
        Console.Write("Por favor, ingrese su nombre: ");
        Nombre = Console.ReadLine();
        Console.Write("Por favor, ingrese su Apellido: ");
        Apellido = Console.ReadLine();

        MostarMensaje(Nombre, Apellido);
    }
        
         public static void MostarMensaje(string NombreUsuario, string NombreApellido)
        {
            Console.WriteLine("Bienvenido señor(a): " + NombreUsuario + " " + NombreApellido);
            Console.ReadLine();
        }
}
