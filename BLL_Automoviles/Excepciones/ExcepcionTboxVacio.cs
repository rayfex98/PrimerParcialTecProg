using System;

namespace BLL_Automoviles.Excepciones
{
    public class ExcepcionTboxVacio : FormatException
    {
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public ExcepcionTboxVacio()
        {
            this.Descripcion = "Recuerde completar el cuadro de cotizacion!";
        }
    }
}
