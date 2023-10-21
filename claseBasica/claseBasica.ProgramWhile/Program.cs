
CalcularPromedio();



void CalcularPromedio()
{
    int suma = 0;
    int valor = 0;
    decimal promedio = 0;
    int cantidad = 0;
    string linea = string.Empty;
    int x = 1;


    Console.WriteLine("Ingrese la cantidad: ");
    linea = Console.ReadLine();

    if (int.TryParse(linea, out int myCantidad))
    {
        cantidad = myCantidad;
    }
    else
    {
        Console.WriteLine("La cantidad ingresada no es válida");
        return;
    }

    Console.WriteLine("---------------------------INGRESAR LOS VALORES------------------------------");

    while (x <= cantidad)
    {
        Console.WriteLine($"Ingrese el valor { x } ");
        linea = Console.ReadLine();


        if (int.TryParse(linea, out int myValue))
        {
            valor = myValue;
        }
        else
        {
            Console.WriteLine("El valor digitado es inválido");
            break;
        }
             

        suma = (suma + valor);
        x += 1;
    }

    promedio = (suma / cantidad);

    Console.WriteLine("--------------------------------------RESULTADOS----------------------------------------------------");


    Console.WriteLine($"La suma es: { suma } ");

    Console.WriteLine($"El promedio es: {promedio}");


}
