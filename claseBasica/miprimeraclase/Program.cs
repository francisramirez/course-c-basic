
using miprimeraclase.Objects;

string line = string.Empty;
int num1 = 0;
int num2 = 0;

/*
 *  Mi Comentario //

 */
Console.Write("Ingrese el valor de primer numero: ");
line = Console.ReadLine();
num1 = Convert.ToInt32(line);


Console.Write("Ingrese el valor del segundo numero: ");
line = Console.ReadLine();
num2 = Convert.ToInt32(line);


Calc calc = new Calc();

var result = calc.Add(num1, num2);

Console.WriteLine($"Este es el resultado: { result }");

Console.ReadLine();