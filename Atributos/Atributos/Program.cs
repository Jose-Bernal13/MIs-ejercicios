using System;

    class Program
    {

        static void Main(string[] args)
        {
            aprendiz apsena = new aprendiz();
            apsena.Nombres = "Juan Jose";
            apsena.Apellidos = "Hernandez Bernal";
            apsena.Direccion = " Cra 7 # 7 - 43";
            apsena.MunicipioResidencia = "Acevedo";
            Saludo(apsena);
        }
        private static void Saludo(aprendiz apsena)
        {
            Console.WriteLine("Bienvenido, Sr(a) " + apsena.Nombres + " " + apsena.Apellidos);
            Console.WriteLine("Su municipio de residencia es: " + apsena.MunicipioResidencia);
            Console.Write("Su dirección es: " + apsena.Direccion );
            Console.ReadLine();

        }
    }

