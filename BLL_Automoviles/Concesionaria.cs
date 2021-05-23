using System;
using System.Collections.Generic;

namespace BLL_Automoviles
{
    public class Concesionaria
    {
        private List<Vehiculo> _automovil = new(); //utilizo dos listas, porque uso dos combobox
        private List<Vehiculo> _camioneta = new();


        public List<Vehiculo> Automoviles
        {
            get { return _automovil; }
            set { _automovil = value; }
        }
        public List<Vehiculo> AutomovilesDisponibles()
        {
            Automovil catAuto = new(); //HARDCODE instancio dos autos
            Vehiculo objauto1 = new()
            {
                Modelo = "Ford Focus",
                Categoria = catAuto,
                VelMax = 218,
                KmRecorridos = 0,
                Tanque = 43.2f
            };
            Vehiculo objauto2 = new()
            {
                Modelo = "Audi A3",
                Categoria = catAuto,
                VelMax = 202,
                KmRecorridos = 6450,
                Tanque = 34.8f
            };

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
            Camioneta catCam = new(); //HARDCODE instancio una camioneta
            Vehiculo objCamioneta = new()
            {
                Modelo = "Ford Ranger",
                Categoria = catCam,
                VelMax = 170,
                KmRecorridos = 12000,
                Tanque = 55
            };

            this.Camionetas.Add(objCamioneta);

            return this.Camionetas;
        }
    }
}
