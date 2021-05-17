using System;

namespace BLL_Automoviles
{
    public class SoftwareUpdate : Mejora
    {

        public override float DevolverCosto(float cotizador)
        {
            return (1500 * cotizador);
        }
    }
}
