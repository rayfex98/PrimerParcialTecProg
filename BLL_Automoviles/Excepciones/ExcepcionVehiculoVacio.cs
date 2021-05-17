using System;

namespace BLL_Automoviles.Excepciones
{
    public class ExcepcionVehiculoVacio : Excepciones
    {
        public ExcepcionVehiculoVacio()
        {
            this.Descripcion = "Seleccione un vehiculo antes de continuar!";
        }
    }
}