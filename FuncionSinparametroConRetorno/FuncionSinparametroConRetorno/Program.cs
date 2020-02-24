using System;

class Program
{
    string Respuesta = "";
    static decimal PrecioProducto = 0;
    static decimal PrecioProductoConIva = 0;
    static int CategoriaProducto = 0;
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("Por favor, ingrese el costo del prodcuto: ");
        decimal.TryParse(Console.ReadLine(), out PrecioProducto);
        Console.WriteLine("Por favor, ingrese la categoria del producto: ");
        Int32.TryParse(Console.ReadLine(), out CategoriaProducto);
        if (CategoriaProducto == 1)
        {
            PrecioProductoConIva = Porcentaje5();
            Console.WriteLine("El precio del producto " + " con Iva es: {0:C}", PrecioProductoConIva);
        }
        if (CategoriaProducto == 2)
        {
            PrecioProductoConIva = Porcentaje5();
            Console.WriteLine("El precio del producto " + " con Iva es: {0:C}", PrecioProductoConIva);
        }
        if (CategoriaProducto == 3)
        {
            PrecioProductoConIva = Porcentaje10();
            Console.WriteLine("El precio del producto " + " con Iva es: {0:C}", PrecioProductoConIva);
        }
        if (CategoriaProducto == 4)
        {
            PrecioProductoConIva = Porcentaje19();
            Console.WriteLine("El precio del producto " + " con Iva es: {0:C}", PrecioProductoConIva);
        } 
          Console.ReadLine();
    }
        public static decimal Porcentaje0()
       {
        decimal aux = 0.00M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;

       } 
       public static decimal Porcentaje5()
       {
        decimal aux = 0.05M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;
        
       }
       public static decimal Porcentaje10()
       {
        decimal aux = 0.1M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;
       }    
           public static decimal Porcentaje19()
       {
        decimal aux = 0.19M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;
      
       }
      
}

