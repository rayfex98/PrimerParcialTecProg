using System;

namespace Vehiculos
{
    public class Baliza : Mejora
    {
        public override float DevolverCosto(float cotizador)
        {
            costo = 1000;
            return costo;
        }
    }
}
