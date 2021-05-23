using System;

namespace BLL_Automoviles.Excepciones
{
    public class ExcepcionCotizacionVacia : Excepciones
    {
        public ExcepcionCotizacionVacia()
        {
            this.Descripcion = "Recuerde completar el cuadro de cotizacion!";
        }
    }
}
