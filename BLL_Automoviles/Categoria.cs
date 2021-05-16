using System;

namespace BLL_Automoviles
{
    public abstract class Categoria
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public abstract float DevolverPrecio(float _cotizacion);
    }
}
