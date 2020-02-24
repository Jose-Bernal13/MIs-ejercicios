using System;


class Program
{

    static void Main(string[] args)
    {
        Calculadora();
    }
    public static void Calculadora()
    {        
          int operacion = 0;
          Console.WriteLine("Ingrese la operacion: ");
          Console.WriteLine("1: Suma ");
          Console.WriteLine("2: Resta ");
          Console.WriteLine("3: Multipliacion ");
          Console.WriteLine("4: Division");
          
          
          Int32.TryParse(Console.ReadLine(), out operacion);
          switch (operacion)
          { 
            case 0:
                Console.WriteLine("Error");
                break;
            case 1:
                Suma();
                break;
            case 2:
                Resta();
                break;
            case 3:
                Multiplicacion();
                break;
            case 4:
                Division();
                break;

           }
          Fin();
     }       
        public static void Suma()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 + num2;
            Console.WriteLine(" El resultado de la suma es: " + num1 + " + " + num2 + " = " + resultado);
            Console.ReadLine();
        }
        public static void Resta()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 - num2;
            Console.WriteLine(" El resultado de la resta es: " + num1 + " - " + num2 + " = " + resultado);
            Console.ReadLine();
        }
        public static void Multiplicacion()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 * num2;
            Console.WriteLine(" El resultado de la multiplicacion es: " + num1 + " x " + num2 + " = " + resultado);
            Console.ReadLine();
        }
        public static void Division()
        {
            int resultado = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Ingrese el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 / num2;
            Console.WriteLine(" El resultado de la division es: " + num1 + " / " + num2 + " = " + resultado);
            Console.ReadLine();
        }
        public static void Fin()
        {
            string Respuesta;
            Console.WriteLine("Desea realizar otra operacion (Y/N)");
            Respuesta = Console.ReadLine();
            if (Respuesta == "Y")
            {
                Calculadora();
            }
            else
            {
             Console.WriteLine("Fin del programa");
            Console.ReadLine();
            }
        }       
}        
         


