using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public abstract class Vehiculo
    {
        private string _categoria;
        private string _modelo; //TODO: Separar en marca y modelo
        //private Mejoras _mejoras; a futuro podria guardar las mejoras del vehiculo a comprar
        private int _velMax;
        private float _kmRecorridos;
        private float _capacidadTanque;

        
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        /*public Mejoras Mejoras
        {
            get { return _mejoras; }
            set { _mejoras = value; }
        }*/
        public float Tanque
        {
            get { return _capacidadTanque; }
            set { _capacidadTanque = value; }
        }
        public float KmRecorridos
        {
            get { return _kmRecorridos; }
            set { _kmRecorridos = value; }
        }
        public int VelMax
        {
            get { return _velMax; }
            set { _velMax = value; }
        }

        public abstract float DevolverPrecio();
    }
}
