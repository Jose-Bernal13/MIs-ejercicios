using System; 

    class Program
    {
        static void Main(string[] args)
        {
            int numeronotas = 0;
            Console.WriteLine("===PROMEDIO DE NOTAS===");
            Console.WriteLine("Ingrese el numero de notas: ");
            Int32.TryParse(Console.ReadLine(), out numeronotas);
            string resultado = calcularnotas(numeronotas);
        }
        public static string calcularnotas(int numeronotas)
        {
            decimal promedio = 0;
            decimal nota = 0;
            decimal sumanotas = 0;
            for (int n = 1; n <= numeronotas; n++)
            {
                Console.Write("Ingrese la nota Nº " + n + ": ");
                decimal.TryParse(Console.ReadLine(), out nota);
                sumanotas += nota++;
                promedio = sumanotas / n;
                
            }
            Console.WriteLine("La suma de las notas es: " + sumanotas);
            Console.ReadLine();
            Console.WriteLine("El promedio de las notas es: {0:F2} ", promedio);
            Console.ReadLine();
            if (promedio >= 6)
            {
                Console.WriteLine("Usted aprobo con el siguiente promedio: {0:F2} ", promedio);
                Console.Write("Paso el año Felicitaciones!!!");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Usted reprobo con el siguiente promedio: {0:F2} ", promedio);
                Console.Write("Perdio el año, lo espero de nuevo. Mas suerte para la proxima!!!");
                Console.ReadLine();
            }
            return "";

       
        }      
    }


