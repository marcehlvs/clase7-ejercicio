
//Escribe un programa que:

//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.



float[] numeros = new float[10];
bool banderaMayor = false;
bool banderaMenor = false;
float numeroMayor = 0;
float numeroMenor = 0;
float sumatoria = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingrese diez números por favor");
    numeros[i] = float.Parse(Console.ReadLine());
    sumatoria += numeros[i];

    if (banderaMayor == false)
    {       
        numeroMayor = numeros[i];
        banderaMayor = true;
    }
    else if (numeros[i] > numeroMayor)
    {
        numeroMayor = numeros[i];   
    }
    if (banderaMenor == false)
    {
        numeroMenor = numeros[i];
        banderaMenor = true;
    }
    else if (numeros[i]<numeroMenor)
    {
        numeroMenor = numeros[i];
    }
 
}

Console.WriteLine("Elija una opción por favor: suma, mayor, menor, promedio, mostrar todos.");

string opcionElegida = Console.ReadLine();
   
switch (opcionElegida.ToLower())
    {
        case "suma":
            Console.WriteLine($"La sumatoria es igual a: {sumatoria}");
            break;
        case "resta":
            Console.WriteLine($"El mayor de los números es: {numeroMayor}");
            break;
        case "menor":
            Console.WriteLine($"El menor de los números es: {numeroMenor}");
            break;
        case "promedio":
            float promedio = sumatoria / numeros.Length;
            Console.WriteLine($"El promedio es: {promedio}");
            break;
        case "mostrar todos":           
            Console.WriteLine($"La sumatoria es igual a: {sumatoria}");           
            Console.WriteLine($"El mayor de los números es: {numeroMayor}");
            Console.WriteLine($"El menor de los números es: {numeroMenor}");
            float promedio2 = sumatoria / numeros.Length;
            Console.WriteLine($"El promedio es: {promedio2}");
            break;
        default:
            Console.WriteLine("Opción incorrecta. Intente nuevamente por favor");
            break;
    }
Console.WriteLine("Gracias por utilizar este programa");
