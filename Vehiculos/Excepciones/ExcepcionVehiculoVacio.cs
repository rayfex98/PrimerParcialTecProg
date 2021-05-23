using System;

namespace Vehiculos.Excepciones
{
    public class ExcepcionVehiculoVacio : Excepciones
    {
        public ExcepcionVehiculoVacio()
        {
            this.Descripcion = "Seleccione un vehiculo antes de continuar!";
        }
    }
}