using System;

namespace Vehiculos
{
    public class Automovil : Categoria
    {
        public override float DevolverPrecio(float cotizacion)
        {
            return 100000 * cotizacion;
        }
        public Automovil()
        {
            this.Nombre = "Automovil";
        }
    }
}