Console.WriteLine("Hola, a continuación le vamos a pedir 10 números....pulse enter para continuar.");
Console.ReadLine(); 
Console.Clear(); 

int[] numeros = new int[10];
       
for (int n = 0; n < numeros.Length; n ++  )
{
    Console.WriteLine($"Por favor, ingrese el número: {n + 1}");
    numeros[n] = int.Parse(Console.ReadLine());
    Console.Clear();
}

Console.WriteLine("Los números ingresados son:");
for (int c = 0; c < numeros.Length; c++)
{
    Console.WriteLine(numeros[c]);    
}

double suma = 0;
for (int s = 0; s < numeros.Length; s++)
{
    suma = suma + numeros[s];
}
Console.WriteLine($"La suma de los números ingresados es de {suma}");


double menor = numeros[0];
for (int men = 1; men < numeros.Length; men++)
{

    if (menor > numeros[men])
    {
        menor = numeros[men];
    }
}
Console.WriteLine($"El número menor es {menor}");


double mayor = numeros[0];
for (int may = 1; may < numeros.Length; may++)
{
    if (mayor < numeros[may])
    {
        mayor = numeros[may];
    }
}
Console.WriteLine($"El número mayor es {mayor}");


double promedio = (suma / numeros.Length);

Console.WriteLine($"El promedio es de {promedio}");

Console.WriteLine("Muchas gracias! Vamos*+");