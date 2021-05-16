using System;

namespace BLL_Automoviles
{
    public class Vehiculo
    {
        
        private string _modelo; //TODO: Separar en marca y modelo
        private Mejoras _mejoras;
        private Categoria _categoria;
        private float _velMax;
        private float _kmRecorridos;
        private float _capacidadTanque;


        
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public Mejoras Mejora
        {
            get { return _mejoras; }
            set { _mejoras = value; }
        }
        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
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
        public float VelMax
        {
            get { return _velMax; }
            set { _velMax = value; }
        }

        public float ARGVelMax()
        {
            return _velMax * 1.609f;
        }
        public float ARGDistancia()
        {
            return _kmRecorridos * 1.609f;
        }
        public float ARGTanque()
        {
            return _capacidadTanque * 3.78f;
        }
    }
}
