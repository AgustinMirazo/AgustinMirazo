
Console.WriteLine("por favor ingrese 10 numeros");

int[] numeros = new int[10];

    for (int i = 0; i < numeros.Length; i++)
     {
          numeros[i] = int.Parse(Console.ReadLine());
     }

 

int suma = 0; 


    for (int i = 0; i < numeros.Length; i++)
     {
        suma = suma + numeros[i];
     
     }


Console.WriteLine("sus numeros elegidos son:  ");
    for (int i = 0; i < numeros.Length; i++)
        {
      Console.WriteLine(numeros[i]);
        }



Console.WriteLine($"la suma de sus números elegidos es:   {suma}");

Console.WriteLine($"el número mínimo elegído es: {numeros.Min()}");

Console.WriteLine($"el número máximo elegído es: {numeros.Max()}");


int promedio = suma / numeros.Length; 
Console.WriteLine($"el promedio de sus números elegidos es: {promedio}");





