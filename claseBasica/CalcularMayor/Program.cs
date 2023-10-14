// Tres numeros por teclado //
int num1 = 0;
int num2 = 0;
int num3= 0;

string linea = string.Empty;

//Pedir numeros //
Console.WriteLine("Ingrese el valor de num1: ");
linea = Console.ReadLine();
num1 = Convert.ToInt32(linea);

Console.WriteLine("Ingrese el valor de num2: ");
linea = Console.ReadLine();
num2 = Convert.ToInt32(linea);


Console.WriteLine("Ingrese el valor de num3: ");
linea = Console.ReadLine();
num3 = Convert.ToInt32(linea);

// &&, ||
//!= diferente de //
// == igualda //


if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("El num1 es el mayor");
}
else
{
	if (num2 > num3)
	{
        Console.WriteLine("El num2 es el mayor");
    }
	else
	{
        Console.WriteLine("El num3 es el mayor");
    }
}



