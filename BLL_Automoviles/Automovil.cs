using System;

namespace BLL_Automoviles
{
    public class Automovil : Vehiculo
    {
        public override float DevolverPrecio(float cotizacion)
        {
            return 100000 * cotizacion;
        }
        public Automovil()
        {
            this.Categoria = "Automovil";
        }
    }
}