using System;

namespace BLL_Automoviles
{
    public class Automovil : Vehiculo
    {
        public override float DevolverPrecio()
        {
            return 100000;
        }
        public Automovil()
        {
            this.Categoria = "Automovil";
        }
    }
}