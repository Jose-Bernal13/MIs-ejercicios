using System;

class Program
{
    static void Main(string[] args)
    {
        string respuesta = "";
        int valorpro = 0;
        int totalpro = 0;
        int numpro = 0;
        int cantidadpro = 0;
        int totalcompra = 0;

        Console.WriteLine("Desea agregar productos al carrito: (SI/NO)");
        respuesta = (Console.ReadLine());

        while (respuesta == "SI")
        {
            numpro++;
            Console.WriteLine("Ingrese el valor del producto: " + numpro);
            valorpro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto: ");
            cantidadpro = Convert.ToInt32(Console.ReadLine());
            totalpro = valorpro * cantidadpro;
            totalcompra += totalpro;

            Console.WriteLine("Desea agregar mas productos al carrito: (SI/NO)");
            respuesta = (Console.ReadLine());
        }
        Console.WriteLine("El valor total de la compra es:  " + totalcompra);
        Console.WriteLine("Fin la compra");
        Console.WriteLine("Vuelva pronto!!");
        Console.ReadLine();

    }
}