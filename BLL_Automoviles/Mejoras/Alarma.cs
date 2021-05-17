using System;

namespace BLL_Automoviles
{
    public class Alarma : Mejora
    {
        
        public override float DevolverCosto(float cotizador) 
        {
            costo = 5000;
            return costo;
        }
    }
}
