﻿using System;

namespace BLL_Automoviles.Excepciones
{
    public class Excepciones : Exception
    {
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
