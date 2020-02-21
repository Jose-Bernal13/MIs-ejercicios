using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] operaciones = new string[5];
            operaciones[0] = "Suma";
            operaciones[1] = "Resta";
            operaciones[2] = "Multiplicacion";
            operaciones[3] = "Division";
            operaciones[4] = "Error";
            string RespuestaUsuario;
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            int Opcion=0;
            Console.WriteLine("Desea realizar algun tipo de operación: (Si/No)");
            RespuestaUsuario = Console.ReadLine();
            while (RespuestaUsuario == "Si") 
            {
                Console.WriteLine("Ingrese el primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                for (int Op = 0; Op <= 3; Op++)
                {
                    Console.WriteLine((Op + 1) +". " + operaciones[Op]);
                }
                Console.WriteLine("Seleccione una operacion: ");
                Opcion= Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1: Console.WriteLine("La operacion seleccionada fue Suma: ");
                        resultado = num1 + num2;
                        Console.WriteLine(+ num1 + " + "+ num2 +" = "+ resultado);
                            break;
                    case 2: Console.WriteLine("La operacion seleccionada fue resta: ");
                            resultado = num1 - num2;
                            Console.WriteLine(+num1 + " - " + num2 + " = " + resultado);
                            break;
                    case 3: Console.WriteLine("La operacion seleccionada fue Multiplicación: ");
                            resultado = num1 * num2;
                            Console.WriteLine(+num1 + " * " + num2 + " = " + resultado);
                            break;
                    case 4: Console.WriteLine("La operacion seleccionada fue División: ");
                            resultado = num1 / num2;
                            Console.WriteLine(+num1 + " / " + num2 + " = " + resultado);
                            break;
                    default:
                            Console.WriteLine("Ha seleccionado una operacion incorrecta");
                            break;
             
                }                 
                  Console.WriteLine("Desea realizar otra operación: (Si/No)");
                  RespuestaUsuario = Console.ReadLine();
            }
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
                      
        }      
    }

