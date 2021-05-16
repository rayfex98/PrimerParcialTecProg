using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public class Concesionaria
    {
        private float _precioFinal;
        private List<Vehiculo> _automovil = new List<Vehiculo>();
        private List<Vehiculo> _camioneta = new List<Vehiculo>();


        public List<Vehiculo> Automoviles
        {
            get { return _automovil; }
            set { _automovil = value; }
        }
        public List<Vehiculo> AutomovilesDisponibles()
        {
            Vehiculo objauto1 = new Vehiculo();
            objauto1.Modelo = "Ford Focus";
            objauto1.VelMax = 218;
            objauto1.KmRecorridos = 0;
            objauto1.Tanque = 43.2f;

            Vehiculo objauto3 = new Vehiculo();
            objauto3.Modelo = "Audi A3";
            objauto3.VelMax = 202;
            objauto3.KmRecorridos = 6450;
            objauto3.Tanque = 34.8f;

            this.Automoviles.Add(objauto1);
            this.Automoviles.Add(objauto3);

            return this.Automoviles;
        }
        public List<Vehiculo> Camionetas
        {
            get { return _camioneta; }
            set { _camioneta = value; }
        }
        public List<Vehiculo> CamionetasDisponibles()
        {
            Vehiculo objCamioneta = new Vehiculo();
            objCamioneta.Modelo = "Ford Ranger";
            objCamioneta.VelMax = 170;
            objCamioneta.KmRecorridos = 12000;
            objCamioneta.Tanque = 55;

            this.Camionetas.Add(objCamioneta);

            return this.Camionetas;
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
        public string CalcularPrecioAuto() 
        {
            
            
            string precio = string.Empty;

            return precio;
        }
    }
}
