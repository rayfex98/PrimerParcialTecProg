using System;

namespace BLL_Automoviles
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
