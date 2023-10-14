//Declarar las variables //
int mes = 0;
int dia = 0;
int anio = 0;
string linea = string.Empty;


Console.WriteLine("Ingrese el dia: ");
linea = Console.ReadLine();
dia = Convert.ToInt32(dia);

Console.WriteLine("Ingrese el mes: ");
linea = Console.ReadLine();
mes = Convert.ToInt32(linea);

Console.WriteLine("Ingrese el año: ");
linea = Console.ReadLine();
anio = Convert.ToInt32(linea);

if (mes == 1 || mes == 2 || mes == 3)
{
    Console.WriteLine("El mes corresponde al primer trimestre");
}
else
{
    Console.WriteLine("El mes no corresponde al primer trimestre");
}

