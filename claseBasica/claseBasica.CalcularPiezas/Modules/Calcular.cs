
namespace claseBasica.CalcularPiezas.Modules
{
    public class Calcular
    {
        public void CalcularCantidadLogitud()
        {
            int x = 1;
            int cantidad = 0;
            float largo = 0;
            string linea = string.Empty;
            int cantidadAptas = 0;
            int cantidadNoAptas = 0;

            Console.WriteLine("Ingrese la cantidad de piezas: ");
            linea = Console.ReadLine();


            Console.WriteLine("-------------------------------------CANTIDAD INGRESADA--------------------------------------");

            if (int.TryParse(linea, out int myCantidad))
            {
                cantidad = myCantidad;
            }
            else
            {
                Console.WriteLine("La cantidad de piezas digitada es inválida.");
                return;
            }


            while (x <= cantidad)
            {
                Console.WriteLine("Ingrese la medida de la pieza. ");
                
                linea = Console.ReadLine();

                if (float.TryParse(linea, out float myLargo))
                {
                    largo = myLargo;
                }
                else
                {
                    Console.WriteLine("El largo introducido es inválido.");
                    continue;
                }

                if (largo >= 1.20 && largo <= 1.30 )
                {
                    cantidadAptas += 1;
                }
                else
                {
                    cantidadNoAptas += 1;
                }

                x += 1;
            }

            Console.WriteLine($"Cantidad de piezas aptas: { cantidadAptas }");

            Console.WriteLine($"Cantidad de piezas no aptas: { cantidadNoAptas }");

        }
    }
}
