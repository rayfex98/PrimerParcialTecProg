﻿using System;

namespace BLL_Automoviles.Excepciones
{
    public class ExcepcionCotizacionInvalida : Excepciones
    {
        public ExcepcionCotizacionInvalida()
        {
            this.Descripcion = "Ingrese un valor valido a la cotizacion! (numeros mayores a 0, con/sin punto decimal)";
        }
    }
}
