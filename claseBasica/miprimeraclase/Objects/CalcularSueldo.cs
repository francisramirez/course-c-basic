

namespace miprimeraclase.Objects
{
    public class CalcularSueldo
    {
        public void Calcular(string linea) 
        {
            
            decimal valorImpuesto = 3000;
            decimal sueldo = 0;
           

            if (decimal.TryParse(linea, out decimal myValue))
            {
                sueldo = myValue;

                if (sueldo > valorImpuesto)
                {
                    Console.WriteLine("El empleado debe pagar impuesto.");
                    return;
                }
                else if (sueldo <= valorImpuesto)
                {
                    Console.WriteLine("El empleado no debe pagar impuesto.");
                    return;
                }
                else if (sueldo == valorImpuesto)
                {
                    Console.WriteLine("El sueldo es igual al valor de impuesto.");
                    return;
                }
            }
            else
                Console.WriteLine("El sueldo digitado no es válido.");



            //sueldo = //decimal.Parse(linea);  //Convert.ToDecimal(linea);




            //Console.WriteLine($"El sueldo digitado es: { sueldo }");
        }
    }
}
