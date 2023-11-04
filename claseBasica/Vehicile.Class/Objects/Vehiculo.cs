

namespace Vehicile.Class.Objects
{
    public abstract class Vehiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public string? Color { get; set; }

        public int Anio { get; set; }

        public int CantidadPuertas { get; set; }

        public abstract void Encender();
        public abstract void Apagar();


    }
}
