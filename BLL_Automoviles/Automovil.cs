using System;

namespace BLL_Automoviles
{
    public class Automovil : Categoria
    {
        public override float DevolverPrecio()
        {
            return 100000;
        }
        public Automovil()
        {
            this.Nombre = "Automovil";
        }
    }
}