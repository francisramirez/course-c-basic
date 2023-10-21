
//Numeros1A10();

//CalcularPromedio();


//CalcularNotas();


Numeros1Al10While();


void Numeros1A10()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"El valor de i: {i}");

        if (i > 5)
        {
            Console.WriteLine("Realizar operación");
        }
    }
}

void Numeros1Al10While()
{
    int i = 1;
    List<int> milista = new List<int>();
    while (i <= 10)
    {
        //Hacer x operación
        milista.Add(i);
        Console.WriteLine($"Valor de i: { i }");


        i += 1;
    }

    foreach (var item in milista)
    {
        if (item<= 5)
        {
            Console.WriteLine($"Valor de mi mista: {item}");
        }
        Console.WriteLine($"Valor de mi mista: { item }");
    }

    foreach (var itemMenor in milista.Where(cd => cd <=5))
    {
        Console.WriteLine($"Valor de mi mista: {  itemMenor }");
    }
}
void CalcularPromedio()
{
    int suma = 0;
    int valor = 0;
    decimal promedio = 0;
    int cantidad = 3;
    string linea = string.Empty;

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine("Digite el valor: ");

        linea = Console.ReadLine();

        //decimal, long, short, int, DateTime 

        if (int.TryParse(linea, out int myValue))
            valor = myValue;

        else
        {
            Console.WriteLine("El valor introducio es inválido");
            break;
        }

        //valor = Convert.ToInt32(Console.ReadLine());

        suma = suma + valor;
    }

    promedio = (suma / cantidad);

    Console.WriteLine($"El valor de la suma es: {suma} y el promedio es {promedio}");

    

}

void CalcularNotas()
{
    int cantidadAprobados = 0;
    int cantidadReprobados = 0;
    int cantidadNota = 0;
    int nota = 0;
    string linea = string.Empty;

    Console.WriteLine("Ingrese la cantidad de notas: ");

    cantidadNota = int.Parse(Console.ReadLine());

    for (int i = 0; i < cantidadNota; i++)
    {
        Console.WriteLine($"Ingrese la nota {i} ");

        linea = Console.ReadLine();


        if (int.TryParse(linea, out int myNota))
            nota = myNota;
        else
        {
            Console.WriteLine("El valor de la nota es inválido.");
            break;
        }


        if (nota >= 10)
        {
            //cantidadAprobados = cantidadAprobados + 1;
            cantidadAprobados += 1;

        }
        else
        {
            cantidadReprobados += 1;
        }
    }

    Console.WriteLine($"Cantidad aprobados: {cantidadAprobados}");

    Console.WriteLine($"Cantidad reprobados: {cantidadReprobados}");

}

