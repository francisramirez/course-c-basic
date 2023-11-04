

using Vehicile.Class.MiembroObjs;

namespace Vehicile.Class.Objects
{
    public class Car : Vehiculo
    {
        Administractivo administractivo = new Administractivo();
        public override void Apagar()
        {

            administractivo.
            System.Console.WriteLine("Apagando Carro");
        }

        public override void Encender()
        {
            System.Console.WriteLine("Encender Carro");

        }

        
    }
}
