using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public class Concesionaria
    {
        private List<Vehiculo> _vehiculos = new List<Vehiculo>();
        private List<Categoria> _categorias = new List<Categoria>();

        public List<Vehiculo> Vehiculos
        {
            get { return _vehiculos; }
            set { _vehiculos = value; }
        }
        public List<Vehiculo> VehiculosDisponibles()
        {
            Vehiculo objveh1 = new Vehiculo();
            Vehiculo objveh2 = new Vehiculo();
            Vehiculo objveh3 = new Vehiculo();
            objveh1.Marca = "Ford";
            objveh2.Marca = "Ford";
            objveh3.Marca = "Audi";
            objveh1.Modelo = "Focus";
            objveh2.Modelo = "Ranger";
            objveh3.Modelo = "A3";
            objveh1.Categoria.Nombre = "Automovil";
            objveh1.Categoria.Nombre = "Camioneta";
            objveh1.Categoria.Nombre = "Automovil";
            objveh1.VelMax = 218;
            objveh2.VelMax = 170;
            objveh3.VelMax = 202;
            objveh1.KmRecorridos = 0;
            objveh2.KmRecorridos = 12000;
            objveh3.KmRecorridos = 6450;
            objveh1.Tanque = 43.2f;
            objveh2.Tanque = 55;
            objveh3.Tanque = 34.8f;

            this.Vehiculos.Add(objveh1);
            this.Vehiculos.Add(objveh2);
            this.Vehiculos.Add(objveh3);

            return this.Vehiculos;
        }

        protected List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
        }
        public List<Categoria> CategoriasDisponibles()
        {
            Camioneta objCamioneta = new Camioneta();
            Automovil objAutomovil = new Automovil();

            this.Categorias.Add(objCamioneta);
            this.Categorias.Add(objAutomovil);

            return this.Categorias;
        }
    }
}
