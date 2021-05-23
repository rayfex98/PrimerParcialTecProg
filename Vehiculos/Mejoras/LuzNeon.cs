using System;

namespace Vehiculos
{
    public class LuzNeon: Mejora
    {

        public override float DevolverCosto(float cotizador)
        {
            costo = 1500;
            return costo;
        }
    }
}