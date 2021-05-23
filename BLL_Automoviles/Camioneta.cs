using System;

namespace Vehiculos
{
    public class Camioneta : Categoria
    {
        public override float DevolverPrecio(float cotizacion)
        {
            return 150000 * cotizacion;
        }
        public Camioneta()
        {
            this.Nombre = "Camioneta";
        }
    }
}
