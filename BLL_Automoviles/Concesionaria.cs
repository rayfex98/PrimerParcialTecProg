using System;
using System.Collections.Generic;

namespace BLL_Automoviles
{
    public class Concesionaria
    {
        private List<Vehiculo> _automovil = new List<Vehiculo>();
        private List<Vehiculo> _camioneta = new List<Vehiculo>();


        public List<Vehiculo> Automoviles
        {
            get { return _automovil; }
            set { _automovil = value; }
        }
        public List<Vehiculo> AutomovilesDisponibles()
        {
            Automovil catAuto = new Automovil();
            Vehiculo objauto1 = new Vehiculo();
            objauto1.Modelo = "Ford Focus";
            objauto1.Categoria = catAuto;
            objauto1.VelMax = 218;
            objauto1.KmRecorridos = 0;
            objauto1.Tanque = 43.2f;
            Vehiculo objauto2 = new Vehiculo();
            objauto2.Modelo = "Audi A3";
            objauto2.Categoria = catAuto;
            objauto2.VelMax = 202;
            objauto2.KmRecorridos = 6450;
            objauto2.Tanque = 34.8f;

            this.Automoviles.Add(objauto1);
            this.Automoviles.Add(objauto2);

            return this.Automoviles;
        }
        public List<Vehiculo> Camionetas
        {
            get { return _camioneta; }
            set { _camioneta = value; }
        }
        public List<Vehiculo> CamionetasDisponibles()
        {
            Camioneta catCam = new Camioneta();
            Vehiculo objCamioneta = new Vehiculo();
            objCamioneta.Modelo = "Ford Ranger";
            objCamioneta.Categoria = catCam;
            objCamioneta.VelMax = 170;
            objCamioneta.KmRecorridos = 12000;
            objCamioneta.Tanque = 55;

            this.Camionetas.Add(objCamioneta);

            return this.Camionetas;
        }
        private List<Categoria> _categorias = new List<Categoria>();

        protected List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
        }

        public List<Categoria> CategoriasDisponibles()
        {
            Automovil objAutomovil = new Automovil();
            Camioneta objCamioneta = new Camioneta();

            this.Categorias.Add(objAutomovil);
            this.Categorias.Add(objCamioneta);

            return this.Categorias;
        }
        public Mejoras ObtenerMejoras(Mejoras objmejora)
        {
            objmejora.SoftUpdate = 1500;
            objmejora.Alarma = 5000;
            objmejora.Vidrio = 1500;
            objmejora.Baliza = 1000;
            objmejora.LuzNeon = 7500;
            return objmejora;
        }
        public string CalcularPrecio(Vehiculo objvehiculo, Mejoras objmejora, float cotizacion) 
        {
            float precioFinal = 0;
            float precioMejoras = 0;
            string precio = string.Empty;
            precioFinal = objvehiculo.Categoria.DevolverPrecio(cotizacion);
            precio = "Valor vehiculo: " + objvehiculo.Categoria.DevolverPrecio(cotizacion);
            precioMejoras += objmejora.SoftUpdate;
            precioMejoras += objvehiculo.Mejora.Alarma;
            precioMejoras += objvehiculo.Mejora.Vidrio;
            precioMejoras += objvehiculo.Mejora.Baliza;
            precioMejoras += objvehiculo.Mejora.LuzNeon;
            precio += "\n Precio de mejoras: " + precioMejoras;
            precioFinal += precioMejoras;
            precio += "\n Precio Final: " + precioFinal;
            return precio;
        }
    }
}
