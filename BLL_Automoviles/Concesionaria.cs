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
        private List<Automovil> _automovil = new List<Automovil>();
        private List<Camioneta> _camioneta = new List<Camioneta>();
        private Mejoras _mejoras;


        public List<Automovil> Automovil
        {
            get { return _automovil; }
            set { _automovil = value; }
        }
        public List<Automovil> AutomovilesDisponibles()
        {
            Automovil objauto1 = new Automovil();
            Automovil objauto3 = new Automovil();

            objauto1.Modelo = "Ford Focus";
            objauto1.VelMax = 218;
            objauto1.KmRecorridos = 0;
            objauto1.Tanque = 43.2f;

            objauto3.Modelo = "Audi A3";
            objauto3.VelMax = 202;
            objauto3.KmRecorridos = 6450;
            objauto3.Tanque = 34.8f;

            this.Automovil.Add(objauto1);
            this.Automovil.Add(objauto3);

            return this.Automovil;
        }

        protected List<Camioneta> Camionetas
        {
            get { return _camioneta; }
            set { _camioneta = value; }
        }
        public List<Camioneta> CamionetasDisponibles()
        {
            Camioneta objCamioneta = new Camioneta();

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
