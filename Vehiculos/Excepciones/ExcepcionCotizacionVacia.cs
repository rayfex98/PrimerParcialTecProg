using System;

namespace Vehiculos.Excepciones
{
    public class ExcepcionCotizacionVacia : Excepciones
    {
        public ExcepcionCotizacionVacia()
        {
            this.Descripcion = "Recuerde completar el cuadro de cotizacion!";
        }
    }
}
