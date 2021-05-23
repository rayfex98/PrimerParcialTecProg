using System;

namespace Vehiculos
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
