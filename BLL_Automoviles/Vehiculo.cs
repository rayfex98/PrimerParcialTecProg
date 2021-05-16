using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public class Vehiculo
    {
        private string _Marca;
        private string _Modelo;
        private Categoria _categoria;
        //private Mejoras _mejoras;
        private int _velMax;
        private float _kmRecorridos;
        private float _capacidadTanque;

        
        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
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
    }
}
