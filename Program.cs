// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();


Console.WriteLine("Introduzca su nombre");
string nombre = Console.ReadLine();
Console.WriteLine($"¡hola {nombre}!");


Console.WriteLine("deseas continuar? S/N");
 string respuesta = Console.ReadLine();



// decidí que las letras minusculas s y n cuenten como S y N 



switch (respuesta.ToUpper())
{
    case "S":
        while (respuesta.ToUpper () ==  "S" )
        {

            Console.WriteLine("Introduzca su nombre");
            string nombre1 = Console.ReadLine();
            Console.WriteLine($"¡hola {nombre1}!");

            Console.WriteLine("deseas continuar? S/N");
             
            respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "N")
            { Console.WriteLine("Programa finalizado correctamente"); 
            }

        }
        break;

    case "N":
        Console.WriteLine("Programa finalizado correctamente");
            break;
    default:
        Console.WriteLine("Opción no valida");
        break;



}


        

            