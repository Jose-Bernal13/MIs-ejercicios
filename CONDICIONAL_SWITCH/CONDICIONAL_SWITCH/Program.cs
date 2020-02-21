using System;

class Program
{
    static void Main(string[] args)
    {
        string mesletras = "";
        int dia = 0;
        int mes = 0;
        int año = 0;
       
        Console.WriteLine("Ingresar el dia de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresar el mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresar el año de nacimiento: ");
        año = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        { 
            case 01:
                mesletras = "Enero";
                break;
            case 02:
                mesletras = "Febrero";
                break;
            case 03:
                mesletras = "Marzo";
                break;
            case 04:
                mesletras = "Abril";
                break;
            case 05:
                mesletras = "Mayo";
                break;
            case 06:
                mesletras = "Junio";
                break;
            case 07:
                mesletras = "Julio";
                break;
            case 08:
                mesletras = "Agosto";
                break;
            case 09:
                mesletras = "Septiembre";
                break;
            case 10:
                mesletras = "Octubre";
                break;
            case 11:
                mesletras = "Noviembre";
                break;
            case 12:
                mesletras = "Diciembre";
                break;
            default:
                mesletras = "Error!!";
                    break;
        }
        if (mesletras == "Error!!")
        {
            Console.WriteLine(" La fecha ingresada es incorrecta.");

            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Usted nacio el " + dia + " de " + mesletras + " del año " + año);
            Console.ReadLine();
        }
       
    }
}
