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
        
        
        public string CalcularPrecio(Compra objCompra, float cotizacion) 
        {
            float precioFinal = 0;
            float precioMejoras = 0;
            string precio = string.Empty;
            precioFinal = objCompra.vehiculos.Categoria.DevolverPrecio(cotizacion);
            precio = "PRECIO FINAL\n\nValor vehiculo: $" + objCompra.vehiculos.Categoria.DevolverPrecio(cotizacion);
            if (objCompra.Soft != null)
            {
                precioMejoras += objCompra.Soft.DevolverCosto(cotizacion);
                precio += "\n\n   Cargo por Software: $" + objCompra.Soft.DevolverCosto(cotizacion);
            }
            if (objCompra.Alarmas != null)
            {
                precioMejoras += objCompra.Alarmas.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Alarmas: $" + objCompra.Alarmas.DevolverCosto(cotizacion);
            }
            if (objCompra.Vidrio != null)
            {
                precioMejoras += objCompra.Vidrio.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Vidrio Polarizado: $" + objCompra.Vidrio.DevolverCosto(cotizacion);
            }
            if (objCompra.Balizas != null)
            {
                precioMejoras += objCompra.Balizas.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Balizas: $" + objCompra.Balizas.DevolverCosto(cotizacion);
            }
            if (objCompra.Luces != null)
            {
                precioMejoras += objCompra.Luces.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Luces de Neon: $" + objCompra.Luces.DevolverCosto(cotizacion);
            }
            precio += "\nPrecio de mejoras: $" + precioMejoras;
            precioFinal += precioMejoras;
            precio += "\n\nPrecio Final: $" + precioFinal;
            return precio;
        }
    }
}
