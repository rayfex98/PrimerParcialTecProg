using System;

namespace BLL_Automoviles
{
    public abstract class Mejora
    {
        protected float costo;

        public float Costos
        {
            get { return costo; }
            set { costo = value; }
        }
        public abstract float DevolverCosto(float cotizador);
    }
}
