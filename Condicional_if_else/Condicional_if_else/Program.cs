using System;

class Program
{
    static void Main(string[] args)
    {
        string Nombreusuario = "";

        Console.Write("Por favor, ingresa tu nombre: ");
        Nombreusuario = Console.ReadLine();
        Console.WriteLine("Bienvenido(a), " + Nombreusuario + ".");
        Console.ReadLine();
    }
}
